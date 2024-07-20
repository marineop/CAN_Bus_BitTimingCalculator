using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANBusBitTiming
{
	public class CANControllerParameters
	{
		public int TSeg1Min { get; set; }
		public int TSeg1Max { get; set; }

		public int TSeg2Min { get; set; }
		public int TSeg2Max { get; set; }

		public int TargetBitRate { get; set; }
	}
}
