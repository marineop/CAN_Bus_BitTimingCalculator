using CANBusBitTiming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_Bus_BitTimingCalculator
{
	public class CANFDBitTimingUI
	{
		[System.ComponentModel.DisplayName("N.Prescaler")]
		public int NominalPrescaler { get; private set; }

		[System.ComponentModel.DisplayName("N.BT (tq)")]
		public int NominalNumberOfTimeQuantaPerBit { get; private set; }

		[System.ComponentModel.DisplayName("N.Prop_Seg (tq)")]
		[Browsable(false)]
		public int NominalPropagationTimeSegment { get; private set; }

		[System.ComponentModel.DisplayName("N.Phrase_Seg1 (tq)")]
		[Browsable(false)]
		public int NominalPhraseBufferSegment1 { get; private set; }

		[System.ComponentModel.DisplayName("N.Phrase_Seg2 (tq)")]
		[Browsable(false)]
		public int NominalPhraseBufferSegment2 { get; private set; }

		[System.ComponentModel.DisplayName("N.SJW (tq)")]
		public int NominalResynchronizationJumpWidth { get; private set; }

		[System.ComponentModel.DisplayName("N.TSeg1 (tq)")]
		public int NominalTSeg1 { get; private set; }

		[System.ComponentModel.DisplayName("N.TSeg2 (tq)")]
		public int NominalTSeg2 { get; private set; }

		[System.ComponentModel.DisplayName("N.Sampling Point (%)")]
		public double NominalSamplingPoint { get; private set; }

		[System.ComponentModel.DisplayName("D.Prescaler")]
		public int DataPrescaler { get; private set; }

		[System.ComponentModel.DisplayName("D.BT (tq)")]
		public int DataNumberOfTimeQuantaPerBit { get; private set; }

		[System.ComponentModel.DisplayName("N.Prop_Seg (tq)")]
		[Browsable(false)]
		public int DataPropagationTimeSegment { get; private set; }

		[System.ComponentModel.DisplayName("N.Phrase_Seg1 (tq)")]
		[Browsable(false)]
		public int DataPhraseBufferSegment1 { get; private set; }

		[System.ComponentModel.DisplayName("N.Phrase_Seg2 (tq)")]
		[Browsable(false)]
		public int DataPhraseBufferSegment2 { get; private set; }

		[System.ComponentModel.DisplayName("D.SJW (tq)")]
		public int DataResynchronizationJumpWidth { get; private set; }

		[System.ComponentModel.DisplayName("D.TSeg1 (tq)")]
		public int DataTSeg1 { get; private set; }

		[System.ComponentModel.DisplayName("D.TSeg2 (tq)")]
		public int DataTSeg2 { get; private set; }

		[System.ComponentModel.DisplayName("D.Smpling Point (%)")]
		public double DataSamplingPoint { get; private set; }

		[System.ComponentModel.DisplayName("Clock Tolerance")]
		[Browsable(false)]
		public double ClockTolerance { get; private set; }

		[System.ComponentModel.DisplayName("Clock Tolerance (%)")]
		public double ClockTolerancePercentage { get; private set; }

		[System.ComponentModel.DisplayName("Clock Tolerance (ppm)")]
		public double ClockTolerancePPM { get; private set; }

		public CANFDBitTimingUI(CANFDBitTiming canFDBitTiming)
		{
			NominalPrescaler = canFDBitTiming.NominalParameters.Prescaler;
			NominalNumberOfTimeQuantaPerBit = canFDBitTiming.NominalParameters.NumberOfTimeQuantaPerBit;
			NominalResynchronizationJumpWidth = canFDBitTiming.NominalParameters.ResynchronizationJumpWidth;
			NominalTSeg1 = canFDBitTiming.NominalParameters.TSeg1;
			NominalTSeg2 = canFDBitTiming.NominalParameters.TSeg2;
			NominalSamplingPoint = canFDBitTiming.NominalParameters.SamplingPoint * 1e2;

			DataPrescaler = canFDBitTiming.DataParameters.Prescaler;
			DataNumberOfTimeQuantaPerBit = canFDBitTiming.DataParameters.NumberOfTimeQuantaPerBit;
			DataResynchronizationJumpWidth = canFDBitTiming.DataParameters.ResynchronizationJumpWidth;
			DataTSeg1 = canFDBitTiming.DataParameters.TSeg1;
			DataTSeg2 = canFDBitTiming.DataParameters.TSeg2;
			DataSamplingPoint = canFDBitTiming.DataParameters.SamplingPoint * 1e2;

			ClockTolerance = canFDBitTiming.MinClockTolerance;
			ClockTolerancePercentage = ((Math.Ceiling(canFDBitTiming.MinClockTolerance * 1e6)) / 1e6) * 1e2;
			ClockTolerancePPM = (int)(Math.Ceiling(canFDBitTiming.MinClockTolerance * 1e6));
		}
	}
}
