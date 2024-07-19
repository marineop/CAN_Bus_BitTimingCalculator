using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
		}

		private void uxCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				uxNominalSolutions.Rows.Clear();
				uxWarning.Visible = false;

				double busLength = (double)uxBusLength.Value;
				double busProgationDelay = (double)uxBusPropagationDelay.Value;
				int ipt = (int)uxIPT.Value;
				int clockFrequency = (int)((double)uxClockFrequency.Value * 1e6);
				double transceiverLoopDelay = (double)uxTransceiverLoopDelay.Value;

				int tseg1Min = (int)uxTSeg1Min.Value;
				int tseg1Max = (int)uxTSeg1Max.Value;

				int tseg2Min = (int)uxTSeg2Min.Value;
				int tseg2Max = (int)uxTSeg2Max.Value;

				int nominalBitRate = (int)(double.Parse(uxNominalBitRate.Text) * 1000);

				int minNumberOfTimeQuanta = 1 + tseg1Min + tseg2Min;
				int maxNumberOfTimeQuanta = 1 + tseg1Max + tseg2Max;

				double tProg = 2.0 * (transceiverLoopDelay + busLength * busProgationDelay);

				double propRatio = tProg / (1.0 / nominalBitRate * 1e9);
				if (propRatio > 0.5)
				{
					uxWarning.Visible = true;
				}

				if (clockFrequency % nominalBitRate != 0)
				{
					SetResult(false, "Clock Frequency not divisible!");
					return;
				}

				int phraseSeg1 = 0;
				int phraseSeg2 = 0;
				int sjw = 0;

				for (int numberOfTimeQuanta = minNumberOfTimeQuanta; numberOfTimeQuanta < maxNumberOfTimeQuanta + 1; ++numberOfTimeQuanta)
				{
					int prescaler = 0;
					while (true)
					{
						++prescaler;
						if (clockFrequency % prescaler != 0)
						{
							continue;
						}
						else
						{
							int newClockFrequency = clockFrequency / prescaler;
							if (newClockFrequency % nominalBitRate != 0)
							{
								continue;
							}

							if (newClockFrequency / nominalBitRate < numberOfTimeQuanta)
							{
								break;
							}
							else if (newClockFrequency / nominalBitRate == numberOfTimeQuanta)
							{
								double timeQuantum = 1.0 / (double)newClockFrequency * 1e9;
								int porpSeg = (int)Math.Ceiling(tProg / timeQuantum);

								int remain = numberOfTimeQuanta - 1 - porpSeg;

								if (remain < ipt + 1 || remain < 2)
								{
									break;
								}

								if (remain % 2 != 0)
								{
									++porpSeg;
									--remain;
								}

								phraseSeg1 = remain / 2;
								phraseSeg2 = phraseSeg1;

								if(phraseSeg2 < ipt)
								{
									porpSeg -= (ipt - phraseSeg2);
									phraseSeg2 = ipt;
								}

								sjw = Math.Min(phraseSeg1, 4);

								int tseg1 = porpSeg + phraseSeg1;
								int tseg2 = phraseSeg2;

								double samplingPoint = (double)(1 + tseg1) / (double)numberOfTimeQuanta * 100.0;

								double clockTolerance1 = (double)sjw / (20.0 * (double)numberOfTimeQuanta);
								double clockTolerance2 = (double)Math.Min(phraseSeg1, phraseSeg2) / (2.0 * (13.0 * numberOfTimeQuanta - (double)phraseSeg2));
								double clockTolerance = Math.Min(clockTolerance1, clockTolerance2) * 100.0;

								uxNominalSolutions.Rows.Add(prescaler, numberOfTimeQuanta, tseg1, tseg2, sjw, samplingPoint, clockTolerance);

								break;
							}
						}
					}
				}

				uxNominalSolutions.Sort(uxNominalSolutions.Columns["ClockTolerance"], ListSortDirection.Descending);
			}
			catch (Exception ex)
			{
				ShowError(ex);
			}
		}

		private void SetResult(bool success, string message)
		{
			if (success)
			{
				uxNominalResult.BackColor = Color.LightGreen;
				uxNominalResult.Text = "Solution Found";
			}
			else
			{
				uxNominalResult.BackColor = Color.LightPink;
				uxNominalResult.Text = message;
			}
		}

		private void ShowError(Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}
