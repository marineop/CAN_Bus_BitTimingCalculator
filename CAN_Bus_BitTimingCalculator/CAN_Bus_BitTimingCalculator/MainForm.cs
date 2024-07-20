using CANBusBitTiming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			uxNominalBitRate.DataSource = null;
			uxNominalBitRate.DataSource = new List<int>() { 125, 250, 500, 800, 1000 };
			uxNominalBitRate.SelectedItem = 1000;

			foreach (DataGridViewColumn column in uxNominalSolutions.Columns)
			{
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}

			SetDoubleBuffer(uxNominalSolutions);

			uxDataBitRate.DataSource = null;
			uxDataBitRate.DataSource = new List<int>() { 125, 250, 500, 800, 1000, 2000, 4000, 5000, 8000 };
			uxDataBitRate.SelectedItem = 2000;

			foreach (DataGridViewColumn column in uxFDSolutions.Columns)
			{
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}

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

				nominal.TargetBitRate = (int)(double.Parse(uxNominalBitRate.Text) * 1000);

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
						SortableBindingList<CANBitTimingUI> bitTimingsUI = new SortableBindingList<CANBitTimingUI>();
						for (int i = 0; i < bitTimings.Count; ++i)
						{
							bitTimingsUI.Add(new CANBitTimingUI(bitTimings[i]));
						}

						uxNominalSolutions.DataSource = bitTimingsUI;

						uxNominalSolutions.Sort(uxNominalSolutions.Columns["uxClockTolerancePPMColumn"], ListSortDirection.Descending);

						SetResult(uxCaculateCANResult, true, "");
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
				commonParameters.ClockFrequency = (int)((double)uxClockFrequency.Value * 1e6);
				commonParameters.TransceiverLoopDelay = (double)uxTransceiverLoopDelay.Value;

				CANControllerParameters nominal = new CANControllerParameters();
				nominal.TSeg1Min = (int)uxTSeg1Min.Value;
				nominal.TSeg1Max = (int)uxTSeg1Max.Value;

				nominal.TSeg2Min = (int)uxTSeg2Min.Value;
				nominal.TSeg2Max = (int)uxTSeg2Max.Value;

				nominal.TargetBitRate = (int)(double.Parse(uxNominalBitRate.Text) * 1000);

				CANControllerParameters data = new CANControllerParameters();
				data.TSeg1Min = (int)uxDataTSeg1Min.Value;
				data.TSeg1Max = (int)uxDataTSeg1Max.Value;

				data.TSeg2Min = (int)uxDataTSeg2Min.Value;
				data.TSeg2Max = (int)uxDataTSeg2Max.Value;

				data.TargetBitRate = (int)(double.Parse(uxDataBitRate.Text) * 1000);

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
						SortableBindingList<CANFDBitTimingUI> bitTimingsUI = new SortableBindingList<CANFDBitTimingUI>();
						for (int i = 0; i < bitTimings.Count; ++i)
						{
							bitTimingsUI.Add(new CANFDBitTimingUI(bitTimings[i]));
						}

						uxFDSolutions.DataSource = bitTimingsUI;

						uxFDSolutions.Sort(uxFDSolutions.Columns["uxCANFDClockTolerancePPMColumn"], ListSortDirection.Descending);

						SetResult(uxCaculateCANFDResult, true, "");
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
			double tProg = 2.0 * (commonParameters.TransceiverLoopDelay + commonParameters.BusLength * commonParameters.BusPropagationDelay);

			double propRatio = tProg / (1.0 / nominal.TargetBitRate * 1e9);
			if (propRatio > 0.5)
			{
				uxWarning.Visible = true;
			}
		}

		private void SetResult(Label labe1, bool success, string message)
		{
			if (success)
			{
				labe1.BackColor = Color.LightGreen;
				labe1.Text = "Solution Found";
			}
			else
			{
				labe1.BackColor = Color.LightPink;
				labe1.Text = message;
			}
		}

		private void ShowError(Exception ex)
		{
			MessageBox.Show(ex.Message);
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
	}
}
