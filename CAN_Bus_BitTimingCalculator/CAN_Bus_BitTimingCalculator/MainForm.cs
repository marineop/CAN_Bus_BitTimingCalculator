using CANBusBitTiming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_Bus_BitTimingCalculator
{
	public partial class MainForm : Form
	{
		private SortableBindingList<CANBitTimingUI> _canBitTimingsUI = new SortableBindingList<CANBitTimingUI>();
		private SortableBindingList<CANFDBitTimingUI> _canFdbitTimingsUI = new SortableBindingList<CANFDBitTimingUI>();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			uxNominalBitRate.DataSource = null;
			uxNominalBitRate.DataSource = new List<int>() { 125, 250, 500, 800, 1000 };
			uxNominalBitRate.SelectedItem = 1000;

			SetDoubleBuffer(uxNominalSolutions);

			uxDataBitRate.DataSource = null;
			uxDataBitRate.DataSource = new List<int>() { 125, 250, 500, 800, 1000, 2000, 4000, 5000, 8000 };
			uxDataBitRate.SelectedItem = 2000;

			SetDoubleBuffer(uxFDSolutions);
		}

		private void SetDoubleBuffer(Control control)
		{
			typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, control, new object[] { DoubleBuffered });
		}

		private void uxCalculateCAN_Click(object sender, EventArgs e)
		{
			try
			{
				uxWarning.Visible = false;
				uxNominalSolutions.DataSource = null;

				CommonParameters commonParameters = new CommonParameters();
				commonParameters.BusLength = (double)uxBusLength.Value;
				commonParameters.BusPropagationDelay = (double)uxBusPropagationDelay.Value;
				commonParameters.InformationProcessingTime = (int)uxIPT.Value;
				commonParameters.ClockFrequency = (long)((double)uxClockFrequency.Value * 1e6);
				commonParameters.TransceiverLoopDelay = (double)uxTransceiverLoopDelay.Value;

				CANControllerParameters nominal = new CANControllerParameters();
				nominal.TSeg1Min = (int)uxTSeg1Min.Value;
				nominal.TSeg1Max = (int)uxTSeg1Max.Value;

				nominal.TSeg2Min = (int)uxTSeg2Min.Value;
				nominal.TSeg2Max = (int)uxTSeg2Max.Value;

				double targetBitRateDobule = (double.Parse(uxNominalBitRate.Text) * 1000);
				if(targetBitRateDobule > long.MaxValue)
				{
					throw new Exception("Target bit Rate is too large!");
				}
				nominal.TargetBitRate = (long)targetBitRateDobule;

				nominal.SamplingPointMin = (double)uxNominalSamplingPointMin.Value * 1e-2;
				nominal.SamplingPointMax = (double)uxNominalSamplingPointMax.Value * 1e-2;
				if (nominal.SamplingPointMin > nominal.SamplingPointMax)
				{
					throw new Exception("Sampling Point Min must be less than or equal to Sampling Point Max!");
				}

				int minNumberOfTimeQuanta = 1 + nominal.TSeg1Min + nominal.TSeg2Min;
				int maxNumberOfTimeQuanta = 1 + nominal.TSeg1Max + nominal.TSeg2Max;

				CheckPropagationDelayRatio(commonParameters, nominal);

				if (commonParameters.ClockFrequency % nominal.TargetBitRate != 0)
				{
					SetResult(uxCaculateCANResult, false, "Clock Frequency not divisible!");
				}
				else
				{
					Calculator calculator = new Calculator();
					List<CANBitTiming> bitTimings = calculator.CalculateCANBitTiming(commonParameters, nominal);

					if (bitTimings.Count > 0)
					{
						_canBitTimingsUI.Clear();
						for (int i = 0; i < bitTimings.Count; ++i)
						{
							_canBitTimingsUI.Add(new CANBitTimingUI(bitTimings[i]));
						}

						uxNominalSolutions.DataSource = _canBitTimingsUI;

						SetResult(uxCaculateCANResult, true, $"{_canBitTimingsUI.Count} Solution{(_canBitTimingsUI.Count > 1 ? "s" : "")} Found");
					}
					else
					{
						SetResult(uxCaculateCANResult, false, "No Solution!");
					}
				}
			}
			catch (Exception ex)
			{
				ShowError(ex);
			}
		}

		private void uxCalculateCANFD_Click(object sender, EventArgs e)
		{
			try
			{
				uxWarning.Visible = false;
				uxFDSolutions.DataSource = null;

				CommonParameters commonParameters = new CommonParameters();
				commonParameters.BusLength = (double)uxBusLength.Value;
				commonParameters.BusPropagationDelay = (double)uxBusPropagationDelay.Value;
				commonParameters.InformationProcessingTime = (int)uxIPT.Value;
				commonParameters.ClockFrequency = (long)((double)uxClockFrequency.Value * 1e6);
				commonParameters.TransceiverLoopDelay = (double)uxTransceiverLoopDelay.Value;

				CANControllerParameters nominal = new CANControllerParameters();
				nominal.TSeg1Min = (int)uxTSeg1Min.Value;
				nominal.TSeg1Max = (int)uxTSeg1Max.Value;

				nominal.TSeg2Min = (int)uxTSeg2Min.Value;
				nominal.TSeg2Max = (int)uxTSeg2Max.Value;

				double targetBitRateDobule = (double.Parse(uxNominalBitRate.Text) * 1000);
				if (targetBitRateDobule > long.MaxValue)
				{
					throw new Exception("Target bit Rate is too large!");
				}
				nominal.TargetBitRate = (long)targetBitRateDobule;

				nominal.SamplingPointMin = (double)uxNominalSamplingPointMin.Value * 1e-2;
				nominal.SamplingPointMax = (double)uxNominalSamplingPointMax.Value * 1e-2;
				if(nominal.SamplingPointMin > nominal.SamplingPointMax)
				{
					throw new Exception("Sampling Point Min must be less than or equal to Sampling Point Max!");
				}

				CANControllerParameters data = new CANControllerParameters();
				data.TSeg1Min = (int)uxDataTSeg1Min.Value;
				data.TSeg1Max = (int)uxDataTSeg1Max.Value;

				data.TSeg2Min = (int)uxDataTSeg2Min.Value;
				data.TSeg2Max = (int)uxDataTSeg2Max.Value;

				targetBitRateDobule = (double.Parse(uxDataBitRate.Text) * 1000);
				if (targetBitRateDobule > long.MaxValue)
				{
					throw new Exception("Target bit Rate is too large!");
				}
				data.TargetBitRate = (long)targetBitRateDobule;

				data.SamplingPointMin = (double)uxDataSamplingPointMin.Value * 1e-2;
				data.SamplingPointMax = (double)uxDataSamplingPointMax.Value * 1e-2;
				if (data.SamplingPointMin > data.SamplingPointMax)
				{
					throw new Exception("Sampling Point Min must be less than or equal to Sampling Point Max!");
				}

				data.UseSecondarySamplingPoint = uxSecondarySamplingPoint.Checked;

				int minNumberOfTimeQuanta = 1 + nominal.TSeg1Min + nominal.TSeg2Min;
				int maxNumberOfTimeQuanta = 1 + nominal.TSeg1Max + nominal.TSeg2Max;

				CheckPropagationDelayRatio(commonParameters, nominal);

				if (commonParameters.ClockFrequency % nominal.TargetBitRate != 0)
				{
					SetResult(uxCaculateCANFDResult, false, "Clock Frequency not divisible!");
				}
				else
				{
					Calculator calculator = new Calculator();
					List<CANFDBitTiming> bitTimings = calculator.CalculateCANFDBitTiming(commonParameters, nominal, data);

					if (bitTimings.Count > 0)
					{
						_canFdbitTimingsUI.Clear();
						for (int i = 0; i < bitTimings.Count; ++i)
						{
							_canFdbitTimingsUI.Add(new CANFDBitTimingUI(bitTimings[i]));
						}

						uxFDSolutions.DataSource = _canFdbitTimingsUI;

						SetResult(uxCaculateCANFDResult, true, $"{_canFdbitTimingsUI.Count} Solution{(_canFdbitTimingsUI.Count > 1 ? "s":"")} Found");
					}
					else
					{
						SetResult(uxCaculateCANFDResult, false, "No Solution!");
					}
				}
			}
			catch (Exception ex)
			{
				ShowError(ex);
			}
		}

		private void CheckPropagationDelayRatio(CommonParameters commonParameters, CANControllerParameters nominal)
		{
			double bitTime = 1.0 / (double)nominal.TargetBitRate;
			double bitTimeNs = bitTime * 1e9;
			double tProgNs = 2.0 * (commonParameters.TransceiverLoopDelay + commonParameters.BusLength * commonParameters.BusPropagationDelay);

			double propRatio = tProgNs / bitTimeNs;
			if (propRatio > 0.5)
			{
				uxWarning.Visible = true;
			}

			uxBitTime.Text = bitTimeNs.ToString("N0");
			uxPropagationDelay.Text = tProgNs.ToString("N0");
			uxPercentage.Text = (propRatio * 100).ToString("N2");
		}

		private void SetResult(Label labe1, bool success, string message)
		{
			if (success)
			{
				labe1.BackColor = Color.LightGreen;
			}
			else
			{
				labe1.BackColor = Color.LightPink;
			}

			labe1.Text = message;
		}

		private void ShowError(Exception ex)
		{
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void uxSetTSegToCANFDDefault_Click(object sender, EventArgs e)
		{
			uxTSeg1Min.Value = 2;
			uxTSeg1Max.Value = 256;

			uxTSeg2Min.Value = 1;
			uxTSeg2Max.Value = 128;

			uxDataTSeg1Min.Value = 1;
			uxDataTSeg1Max.Value = 32;

			uxDataTSeg2Min.Value = 1;
			uxDataTSeg2Max.Value = 16;
		}

		private void uxSetTSegToCAN20Default_Click(object sender, EventArgs e)
		{
			uxTSeg1Min.Value = 2;
			uxTSeg1Max.Value = 16;

			uxTSeg2Min.Value = 1;
			uxTSeg2Max.Value = 8;
		}

		private void uxSecondarySamplingPoint_CheckedChanged(object sender, EventArgs e)
		{
			uxSSPPanel.Enabled = !uxSecondarySamplingPoint.Checked;
			if(uxSecondarySamplingPoint.Checked)
			{
				uxDataColumnHeader.Width = 542;
				dataSamplingPointDataGridViewTextBoxColumn.Visible = true;
			}
			else
			{
				uxDataColumnHeader.Width = 441;
				dataSamplingPointDataGridViewTextBoxColumn.Visible = false;
			}
			
		}
	}
}
