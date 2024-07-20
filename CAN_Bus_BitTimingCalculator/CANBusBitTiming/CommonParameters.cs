using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANBusBitTiming
{
	public class CommonParameters
	{
		public double BusLength { get; set; } // m
		public double BusPropagationDelay { get; set; } // ns/m
		public int InformationProcessingTime { get; set; } // tq
		public long ClockFrequency { get; set; } // Hz
		public double TransceiverLoopDelay { get; set; } // ns
	}
}
