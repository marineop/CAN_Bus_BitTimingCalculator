using CANBusBitTiming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_Bus_BitTimingCalculator
{
	public class CANBitTimingUI
	{
		[System.ComponentModel.DisplayName("Prescaler")]
		public int Prescaler { get; set; }

		[System.ComponentModel.DisplayName("NBT (tq)")]
		public int NumberOfTimeQuantaPerBit { get; set; }

		[System.ComponentModel.DisplayName("Prop_Seg (tq)")]
		public int PropagationTimeSegment { get; set; }

		[System.ComponentModel.DisplayName("Phrase_Seg1 (tq)")]
		public int PhraseBufferSegment1 { get; set; }

		[System.ComponentModel.DisplayName("Phrase_Seg2 (tq)")]
		public int PhraseBufferSegment2 { get; set; }

		[System.ComponentModel.DisplayName("SJW (tq)")]
		public int ResynchronizationJumpWidth { get; set; }

		[System.ComponentModel.DisplayName("TSeg1 (tq)")]
		public int TSeg1 { get; set; }

		[System.ComponentModel.DisplayName("TSeg2 (tq)")]
		public int TSeg2 { get; set; }

		[System.ComponentModel.DisplayName("Sampling Point (%)")]
		public double SamplingPoint { get; set; }

		[System.ComponentModel.DisplayName("Colock Tolerance (%)")]
		public double ClockTolerancePercentage { get; set; }

		[System.ComponentModel.DisplayName("Colock Tolerance (ppm)")]
		public int ClockTolerancePPM { get; set; }

		public CANBitTimingUI(CANBitTiming bitTiming)
		{
			BitTiming p = bitTiming.Parameters;

			Prescaler = p.Prescaler;
			NumberOfTimeQuantaPerBit = p.NumberOfTimeQuantaPerBit;
			PropagationTimeSegment = p.PropagationTimeSegment;
			PhraseBufferSegment1 = p.PhraseBufferSegment1;
			PhraseBufferSegment2 = p.PhraseBufferSegment2;
			ResynchronizationJumpWidth = p.ResynchronizationJumpWidth;
			TSeg1 = p.TSeg1;
			TSeg2 = p.TSeg2;
			SamplingPoint = p.SamplingPoint * 1e2;

			ClockTolerancePercentage = ((Math.Ceiling(bitTiming.MinClockTolerance * 1e6)) / 1e6) * 1e2;
			ClockTolerancePPM = (int)(Math.Ceiling(bitTiming.MinClockTolerance * 1e6));
		}
	}
}
