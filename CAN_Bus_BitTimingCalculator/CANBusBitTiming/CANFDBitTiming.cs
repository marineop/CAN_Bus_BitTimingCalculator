using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANBusBitTiming
{
	public class CANFDBitTiming
	{
		public BitTiming NominalParameters { get; private set; }

		public BitTiming DataParameters { get; private set; }

		public double MinClockTolerance { get; private set; }

		public double ClockTolerance1 { get; private set; }
		public double ClockTolerance2 { get; private set; }
		public double ClockTolerance3 { get; private set; }
		public double ClockTolerance4 { get; private set; }
		public double ClockTolerance5 { get; private set; }

		public CANFDBitTiming(BitTiming n, BitTiming d)
		{
			this.NominalParameters = n;
			this.DataParameters = d;

			this.ClockTolerance1 = (double)n.ResynchronizationJumpWidth / (20.0 * (double)n.NumberOfTimeQuantaPerBit);
			this.ClockTolerance2 = (double)Math.Min(n.PhraseBufferSegment1, n.PhraseBufferSegment2) / (2.0 * (13.0 * (double)n.NumberOfTimeQuantaPerBit - (double)n.PhraseBufferSegment2));
			this.ClockTolerance3 = (double)d.ResynchronizationJumpWidth / (20.0 * (double)d.NumberOfTimeQuantaPerBit);
			this.ClockTolerance4 = (double)Math.Min(d.PhraseBufferSegment1, d.PhraseBufferSegment2) / (2.0 * ((6.0 * (double)d.NumberOfTimeQuantaPerBit - (double)d.PhraseBufferSegment2) * ((double)d.Prescaler / n.Prescaler) + 7.0 * d.NumberOfTimeQuantaPerBit));
			this.ClockTolerance5 = ((double)d.ResynchronizationJumpWidth - Math.Max(0.0, (((double)n.Prescaler / d.Prescaler) - 1.0))) / (2.0 * ((2.0 * (double)n.NumberOfTimeQuantaPerBit - (double)n.PhraseBufferSegment2) * ((double)n.Prescaler / d.Prescaler) + (double)d.PhraseBufferSegment2 + 4.0 * (double)d.NumberOfTimeQuantaPerBit));

			List<double> tolerances = new List<double>() { ClockTolerance1, ClockTolerance2, ClockTolerance3, ClockTolerance4, ClockTolerance5 };
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
