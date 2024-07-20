using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CANBusBitTiming
{
	public class CANBitTiming
	{
		public BitTiming Parameters { get; set; } = new BitTiming();

		public double MinClockTolerance { get; set; }

		public double ClockTolerance1 { get; private set; }
		public double ClockTolerance2 { get; private set; }

		public CANBitTiming(BitTiming bitTiming)
		{
			this.Parameters = bitTiming;

			this.ClockTolerance1 = (double)bitTiming.ResynchronizationJumpWidth / (20.0 * (double)bitTiming.NumberOfTimeQuantaPerBit);
			this.ClockTolerance2 = (double)Math.Min(bitTiming.PhraseBufferSegment1, bitTiming.PhraseBufferSegment2) / (2.0 * (13.0 * (double)bitTiming.NumberOfTimeQuantaPerBit - (double)bitTiming.PhraseBufferSegment2));

			List<double> tolerances = new List<double>() { ClockTolerance1, ClockTolerance2 };
			double minTolerance = ClockTolerance1;
			for (int i = 1; i < tolerances.Count; ++i)
			{
				if (tolerances[i] < minTolerance)
				{
					minTolerance = tolerances[i];
				}
			}

			this.MinClockTolerance = minTolerance;
		}
	}
}
