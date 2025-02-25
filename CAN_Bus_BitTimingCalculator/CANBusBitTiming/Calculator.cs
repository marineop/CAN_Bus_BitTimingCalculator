﻿using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace CANBusBitTiming
{
	public class Calculator
	{
		public List<CANFDBitTiming> CalculateCANFDBitTiming(CommonParameters commonParameters, CANControllerParameters nominal, CANControllerParameters data)
		{
			List<CANFDBitTiming> fdBitTimings = new List<CANFDBitTiming>();

			List<BitTiming> nominalTimings = CalculateCANBitTimingInner(commonParameters, nominal);

			List<BitTiming> dataTimings = CalculateCANFDBitTimingInner(commonParameters, data);

			foreach (BitTiming n in nominalTimings)
			{
				foreach (BitTiming d in dataTimings)
				{
					CANFDBitTiming cANFDBitTiming = new CANFDBitTiming(n, d);

					if (cANFDBitTiming.MinClockTolerance <= 0.0)
					{
						continue;
					}

					fdBitTimings.Add(cANFDBitTiming);
				}
			}


			fdBitTimings.Sort((x, y) =>
			{
				return y.MinClockTolerance.CompareTo(x.MinClockTolerance);
			});


			return fdBitTimings;
		}

		public List<CANBitTiming> CalculateCANBitTiming(CommonParameters commonParameters, CANControllerParameters controllerParameters)
		{
			List<BitTiming> bitTimingsInner = CalculateCANBitTimingInner(commonParameters, controllerParameters);

			List<CANBitTiming> bitTimings = new List<CANBitTiming>();

			foreach (BitTiming bitTiming in bitTimingsInner)
			{
				bitTimings.Add(new CANBitTiming(bitTiming));
			}

			bitTimings.Sort((x, y) =>
			{
				return y.MinClockTolerance.CompareTo(x.MinClockTolerance);
			});

			return bitTimings;
		}

		private List<BitTiming> CalculateCANBitTimingInner(CommonParameters commonParameters, CANControllerParameters controllerParameters)
		{
			List<BitTiming> bitTimings = new List<BitTiming>();

			int minNumberOfTimeQuanta = 1 + controllerParameters.TSeg1Min + controllerParameters.TSeg2Min;
			int maxNumberOfTimeQuanta = 1 + controllerParameters.TSeg1Max + controllerParameters.TSeg2Max;

			if (commonParameters.ClockFrequency % controllerParameters.TargetBitRate == 0)
			{
				long fineNumberOfTimeQuanta = commonParameters.ClockFrequency / controllerParameters.TargetBitRate;

				double tProg = 2.0 * (commonParameters.TransceiverLoopDelay + commonParameters.BusLength * commonParameters.BusPropagationDelay);

				for (int numberOfTimeQuanta = minNumberOfTimeQuanta; numberOfTimeQuanta < maxNumberOfTimeQuanta + 1; ++numberOfTimeQuanta)
				{
					if (numberOfTimeQuanta > fineNumberOfTimeQuanta)
					{
						break;
					}

					if (fineNumberOfTimeQuanta % numberOfTimeQuanta == 0)
					{
						int prescaler = (int)(fineNumberOfTimeQuanta / numberOfTimeQuanta);

						long newClockFrequency = commonParameters.ClockFrequency / prescaler;

						double timeQuantum = 1.0 / (double)newClockFrequency * 1e9;
						int minPorpSeg = (int)Math.Ceiling(tProg / timeQuantum);
						int syncSeg = 1;
						int minPhraseSeg1 = 1;
						int minPhraseSeg2 = Math.Max(1, commonParameters.InformationProcessingTime);
						int maxPropSeg = numberOfTimeQuanta - syncSeg - minPhraseSeg1 - minPhraseSeg2;

						for (int porpSegNow = minPorpSeg; porpSegNow <= maxPropSeg; ++porpSegNow)
						{
							int porpSeg = porpSegNow;
							int remain = numberOfTimeQuanta - syncSeg - porpSeg;

							if (remain % 2 != 0 && porpSegNow != maxPropSeg)
							{
								continue;
							}

							int phraseSeg1 = remain / 2;
							int phraseSeg2 = phraseSeg1;

							if (phraseSeg2 < commonParameters.InformationProcessingTime)
							{
								porpSeg -= (commonParameters.InformationProcessingTime - phraseSeg2);
								phraseSeg2 = commonParameters.InformationProcessingTime;
							}

							int sjw = Math.Min(phraseSeg1, 4);

							BitTiming bitTiming = new BitTiming();
							bitTiming.Prescaler = prescaler;
							bitTiming.NumberOfTimeQuantaPerBit = numberOfTimeQuanta;
							bitTiming.PropagationTimeSegment = porpSeg;
							bitTiming.PhraseBufferSegment1 = phraseSeg1;
							bitTiming.PhraseBufferSegment2 = phraseSeg2;
							bitTiming.ResynchronizationJumpWidth = sjw;
							bitTiming.TSeg1 = porpSeg + phraseSeg1;
							bitTiming.TSeg2 = phraseSeg2;

							if (bitTiming.SamplingPoint >= controllerParameters.SamplingPointMin && bitTiming.SamplingPoint <= controllerParameters.SamplingPointMax)
							{
								bitTimings.Add(bitTiming);
							}
						}
					}
				}
			}

			return bitTimings;
		}

		private List<BitTiming> CalculateCANFDBitTimingInner(CommonParameters commonParameters, CANControllerParameters controllerParameters)
		{
			List<BitTiming> bitTimings = new List<BitTiming>();

			int minNumberOfTimeQuanta = 1 + controllerParameters.TSeg1Min + controllerParameters.TSeg2Min;
			int maxNumberOfTimeQuanta = 1 + controllerParameters.TSeg1Max + controllerParameters.TSeg2Max;

			if (commonParameters.ClockFrequency % controllerParameters.TargetBitRate == 0)
			{
				long fineNumberOfTimeQuanta = commonParameters.ClockFrequency / controllerParameters.TargetBitRate;

				for (int numberOfTimeQuanta = minNumberOfTimeQuanta; numberOfTimeQuanta < maxNumberOfTimeQuanta + 1; ++numberOfTimeQuanta)
				{
					if (numberOfTimeQuanta > fineNumberOfTimeQuanta)
					{
						break;
					}

					if (fineNumberOfTimeQuanta % numberOfTimeQuanta == 0)
					{
						int prescaler = (int)(fineNumberOfTimeQuanta / numberOfTimeQuanta);
						int minPhraseSeg2 = Math.Max(1, commonParameters.InformationProcessingTime);
						for (int phraseSeg2 = minPhraseSeg2; phraseSeg2 < (numberOfTimeQuanta - 1) / 2 + 1; ++phraseSeg2)
						{
							BitTiming bitTiming = new BitTiming();
							bitTiming.Prescaler = prescaler;
							bitTiming.NumberOfTimeQuantaPerBit = numberOfTimeQuanta;

							bitTiming.PhraseBufferSegment2 = phraseSeg2;
							bitTiming.PhraseBufferSegment1 = phraseSeg2;
							bitTiming.TSeg2 = phraseSeg2;
							bitTiming.TSeg1 = numberOfTimeQuanta - phraseSeg2 - 1;

							bitTiming.PropagationTimeSegment = bitTiming.TSeg1 - bitTiming.PhraseBufferSegment1;

							bitTiming.ResynchronizationJumpWidth = phraseSeg2;

							if (controllerParameters.UseSecondarySamplingPoint ||
								(bitTiming.SamplingPoint >= controllerParameters.SamplingPointMin && bitTiming.SamplingPoint <= controllerParameters.SamplingPointMax))
							{
								bitTimings.Add(bitTiming);
							}
						}
					}
				}
			}

			return bitTimings;
		}
	}
}
