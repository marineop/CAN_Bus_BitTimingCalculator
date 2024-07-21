using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANBusBitTiming
{
	public class BitTiming
	{
		public int Prescaler { get; set; }
		public int NumberOfTimeQuantaPerBit { get; set; }
		public int PropagationTimeSegment { get; set; }
		public int PhraseBufferSegment1 { get; set; }
		public int PhraseBufferSegment2 { get; set; }
		public int ResynchronizationJumpWidth { get; set; }
		public int TSeg1 { get; set; }
		public int TSeg2 { get; set; }
		public double SamplingPoint => (1.0 + (double)TSeg1) / (double)NumberOfTimeQuantaPerBit;

		public override string ToString()
		{
			return $"NBT={NumberOfTimeQuantaPerBit}, Pre={Prescaler}, TSeg1={TSeg1}, TSeg2={TSeg2}, SJW={ResynchronizationJumpWidth}";
		}
	}
}
