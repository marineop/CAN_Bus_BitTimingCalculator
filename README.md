# CAN Bus Bit Timing Calculator
![](images/ui.png)
1. List all possible bit timing parameters
1. Support both CAN 2.0 and CAN FD
1. Sorting according to clock tolerance allows you to choose the best parameters
1. Simple Windows Form project

# Fields Explanation
1. Common

	* Bus Length: According to your physical cable.
	* Bus Propagation Delay: According to the cable datasheet or actual measurement.
	* Transceiver Loop Delay: Check the CAN transceiver datasheet.
	* CAN Controller IPT: Information Processing Time. Check the datasheet of MCU.
	* Clock Frequency: Check the system clock and PLL settings of MCU and firmware.

2. CAN 2.0

	* TSeg1 and TSeg2 Range: Check the reference manual of the MCU.
	* Sampling Range: Filter to the result, in case your system require a specific range of sampling point.
3.  CAN FD

	* TSeg1 and TSeg2 Range: Check the reference manual of the MCU.
	* Secondary Sampling Point: Enable to allow a larger bit rate in data field.
	* Sampling Range: Filter to the result, in case your system require a specific range of sampling point.

# Reference
1. [FDCAN Normal Operating Mode](https://www.youtube.com/watch?v=xGRvVKfs2-0)
1. [AN1798: CAN Bit Timing Requirements](https://www.nxp.com/docs/en/application-note/AN1798.pdf) by Stuart Robb, East Kilbride, Scotland, NXP
1. [Bit Time Requirements for CAN FD](https://www.bosch-semiconductors.com/media/ip_modules/pdf_2/papers/icc14_2013_paper_hartwich_1.pdf) by Florian Hartwich, Robert Bosch GmbH
1. [Robustness of a CAN FD Bus System – About Oscillator Tolerance and Edge Deviations](https://www.bosch-semiconductors.com/media/ip_modules/pdf_2/papers/icc14_2013_paper_mutter_1.pdf) by Dr. Arthur Mutter, Robert Bosch GmbH

# TODO
1. Add document
