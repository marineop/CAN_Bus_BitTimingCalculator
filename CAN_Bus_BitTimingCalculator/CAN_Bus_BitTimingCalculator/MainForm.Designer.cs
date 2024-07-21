using System;

namespace CAN_Bus_BitTimingCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.uxNominalSolutions = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.uxBusPropagationDelay = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.uxBusLength = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.uxClockFrequency = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.uxTransceiverLoopDelay = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.uxIPT = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.uxTSeg1Min = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.uxNominalBitRate = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.uxTSeg1Max = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.uxTSeg2Min = new System.Windows.Forms.NumericUpDown();
			this.uxTSeg2Max = new System.Windows.Forms.NumericUpDown();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.uxDataTSeg1Min = new System.Windows.Forms.NumericUpDown();
			this.label25 = new System.Windows.Forms.Label();
			this.uxDataTSeg2Min = new System.Windows.Forms.NumericUpDown();
			this.uxDataTSeg1Max = new System.Windows.Forms.NumericUpDown();
			this.uxDataTSeg2Max = new System.Windows.Forms.NumericUpDown();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.uxDataBitRate = new System.Windows.Forms.ComboBox();
			this.uxCalculateCAN = new System.Windows.Forms.Button();
			this.label30 = new System.Windows.Forms.Label();
			this.uxWarning = new System.Windows.Forms.Label();
			this.uxCaculateCANResult = new System.Windows.Forms.Label();
			this.uxFDSolutions = new System.Windows.Forms.DataGridView();
			this.uxCalculateCANFD = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.uxCaculateCANFDResult = new System.Windows.Forms.Label();
			this.uxSetTSegToCANFDDefault = new System.Windows.Forms.Button();
			this.uxSetTSegToCAN20Default = new System.Windows.Forms.Button();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.uxBitTime = new System.Windows.Forms.Label();
			this.uxPropagationDelay = new System.Windows.Forms.Label();
			this.uxPercentage = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.uxNominalSamplingPointMin = new System.Windows.Forms.NumericUpDown();
			this.uxNominalSamplingPointMax = new System.Windows.Forms.NumericUpDown();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.uxDataSamplingPointMin = new System.Windows.Forms.NumericUpDown();
			this.uxDataSamplingPointMax = new System.Windows.Forms.NumericUpDown();
			this.label40 = new System.Windows.Forms.Label();
			this.uxSecondarySamplingPoint = new System.Windows.Forms.CheckBox();
			this.uxSSPPanel = new System.Windows.Forms.Panel();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.uxToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.nominalPrescalerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nominalResynchronizationJumpWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nominalTSeg1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nominalTSeg2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nominalSamplingPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataPrescalerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataResynchronizationJumpWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTSeg1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTSeg2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataSamplingPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clockTolerancePercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clockTolerancePPMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cANFDBitTimingUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clockTolerancePercentageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uxClockTolerancePPMColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cANBitTimingUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.uxNominalSolutions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxBusPropagationDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxBusLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxClockFrequency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTransceiverLoopDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxIPT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg1Min)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg1Max)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg2Min)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg2Max)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg1Min)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg2Min)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg1Max)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg2Max)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxFDSolutions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxNominalSamplingPointMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxNominalSamplingPointMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataSamplingPointMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataSamplingPointMax)).BeginInit();
			this.uxSSPPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cANFDBitTimingUIBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cANBitTimingUIBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// uxNominalSolutions
			// 
			this.uxNominalSolutions.AllowUserToAddRows = false;
			this.uxNominalSolutions.AllowUserToDeleteRows = false;
			this.uxNominalSolutions.AllowUserToOrderColumns = true;
			this.uxNominalSolutions.AllowUserToResizeRows = false;
			this.uxNominalSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uxNominalSolutions.AutoGenerateColumns = false;
			this.uxNominalSolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.uxNominalSolutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn22,
            this.clockTolerancePercentageDataGridViewTextBoxColumn1,
            this.uxClockTolerancePPMColumn});
			this.uxNominalSolutions.DataSource = this.cANBitTimingUIBindingSource;
			this.uxNominalSolutions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.uxNominalSolutions.Location = new System.Drawing.Point(26, 308);
			this.uxNominalSolutions.Name = "uxNominalSolutions";
			this.uxNominalSolutions.ReadOnly = true;
			this.uxNominalSolutions.RowHeadersVisible = false;
			this.uxNominalSolutions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.uxNominalSolutions.RowTemplate.Height = 24;
			this.uxNominalSolutions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.uxNominalSolutions.Size = new System.Drawing.Size(1318, 234);
			this.uxNominalSolutions.TabIndex = 0;
			this.uxNominalSolutions.VirtualMode = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(418, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bus Propagation Delay";
			// 
			// uxBusPropagationDelay
			// 
			this.uxBusPropagationDelay.Location = new System.Drawing.Point(560, 84);
			this.uxBusPropagationDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxBusPropagationDelay.Name = "uxBusPropagationDelay";
			this.uxBusPropagationDelay.Size = new System.Drawing.Size(68, 23);
			this.uxBusPropagationDelay.TabIndex = 2;
			this.uxBusPropagationDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxBusPropagationDelay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxBusPropagationDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(633, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "ns / m";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(418, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Bus Length";
			// 
			// uxBusLength
			// 
			this.uxBusLength.DecimalPlaces = 1;
			this.uxBusLength.Location = new System.Drawing.Point(560, 55);
			this.uxBusLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxBusLength.Name = "uxBusLength";
			this.uxBusLength.Size = new System.Drawing.Size(68, 23);
			this.uxBusLength.TabIndex = 2;
			this.uxBusLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxBusLength.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxBusLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(633, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "m";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(418, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "Clock Frequency";
			this.uxToolTip.SetToolTip(this.label5, "The system clock to the CAN controller before Prescaler");
			// 
			// uxClockFrequency
			// 
			this.uxClockFrequency.DecimalPlaces = 1;
			this.uxClockFrequency.Location = new System.Drawing.Point(560, 171);
			this.uxClockFrequency.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxClockFrequency.Name = "uxClockFrequency";
			this.uxClockFrequency.Size = new System.Drawing.Size(68, 23);
			this.uxClockFrequency.TabIndex = 2;
			this.uxClockFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxClockFrequency.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxClockFrequency.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(633, 173);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 15);
			this.label6.TabIndex = 3;
			this.label6.Text = "MHz";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(418, 115);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(127, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "Transceiver Loop Delay";
			this.uxToolTip.SetToolTip(this.label7, "Check transceiver datasheet\r\nThe delay time from TX change to RX change\r\nUse the " +
        "maximum value");
			// 
			// uxTransceiverLoopDelay
			// 
			this.uxTransceiverLoopDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.uxTransceiverLoopDelay.Location = new System.Drawing.Point(560, 113);
			this.uxTransceiverLoopDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxTransceiverLoopDelay.Name = "uxTransceiverLoopDelay";
			this.uxTransceiverLoopDelay.Size = new System.Drawing.Size(68, 23);
			this.uxTransceiverLoopDelay.TabIndex = 2;
			this.uxTransceiverLoopDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxTransceiverLoopDelay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxTransceiverLoopDelay.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(633, 115);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 15);
			this.label8.TabIndex = 3;
			this.label8.Text = "ns";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(418, 144);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 15);
			this.label9.TabIndex = 1;
			this.label9.Text = "CAN Controller IPT";
			this.uxToolTip.SetToolTip(this.label9, "IPT (Information Processing Time)\r\nCheck the MCU or CAN controller datasheet");
			// 
			// uxIPT
			// 
			this.uxIPT.Location = new System.Drawing.Point(560, 142);
			this.uxIPT.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.uxIPT.Name = "uxIPT";
			this.uxIPT.Size = new System.Drawing.Size(68, 23);
			this.uxIPT.TabIndex = 2;
			this.uxIPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxIPT.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxIPT.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(633, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(18, 15);
			this.label10.TabIndex = 3;
			this.label10.Text = "tq";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(399, 23);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 15);
			this.label11.TabIndex = 4;
			this.label11.Text = "Common Parameters";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(684, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(290, 15);
			this.label12.TabIndex = 4;
			this.label12.Text = "CAN 2.0 Parameters (or CAN FD Nominal Parameters)";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(1023, 23);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(138, 15);
			this.label13.TabIndex = 4;
			this.label13.Text = "CAN FD Data Parameters";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(711, 84);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 15);
			this.label14.TabIndex = 1;
			this.label14.Text = "TSeg1 Range";
			this.uxToolTip.SetToolTip(this.label14, "Check the reference manual of the CAN controller\r\n");
			// 
			// uxTSeg1Min
			// 
			this.uxTSeg1Min.Location = new System.Drawing.Point(841, 82);
			this.uxTSeg1Min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxTSeg1Min.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.uxTSeg1Min.Name = "uxTSeg1Min";
			this.uxTSeg1Min.Size = new System.Drawing.Size(51, 23);
			this.uxTSeg1Min.TabIndex = 2;
			this.uxTSeg1Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxTSeg1Min.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxTSeg1Min.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(711, 203);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(82, 15);
			this.label16.TabIndex = 1;
			this.label16.Text = "Target Bit Rate";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(967, 203);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(32, 15);
			this.label17.TabIndex = 3;
			this.label17.Text = "kbps";
			// 
			// uxNominalBitRate
			// 
			this.uxNominalBitRate.FormattingEnabled = true;
			this.uxNominalBitRate.Location = new System.Drawing.Point(841, 201);
			this.uxNominalBitRate.Name = "uxNominalBitRate";
			this.uxNominalBitRate.Size = new System.Drawing.Size(120, 23);
			this.uxNominalBitRate.TabIndex = 5;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(893, 87);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(15, 15);
			this.label18.TabIndex = 1;
			this.label18.Text = "~";
			// 
			// uxTSeg1Max
			// 
			this.uxTSeg1Max.Location = new System.Drawing.Point(910, 82);
			this.uxTSeg1Max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxTSeg1Max.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.uxTSeg1Max.Name = "uxTSeg1Max";
			this.uxTSeg1Max.Size = new System.Drawing.Size(51, 23);
			this.uxTSeg1Max.TabIndex = 2;
			this.uxTSeg1Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxTSeg1Max.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxTSeg1Max.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(711, 113);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 15);
			this.label15.TabIndex = 1;
			this.label15.Text = "TSeg2 Range";
			this.uxToolTip.SetToolTip(this.label15, "Check the reference manual of the CAN controller");
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(893, 116);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(15, 15);
			this.label19.TabIndex = 1;
			this.label19.Text = "~";
			// 
			// uxTSeg2Min
			// 
			this.uxTSeg2Min.Location = new System.Drawing.Point(841, 111);
			this.uxTSeg2Min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxTSeg2Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.uxTSeg2Min.Name = "uxTSeg2Min";
			this.uxTSeg2Min.Size = new System.Drawing.Size(51, 23);
			this.uxTSeg2Min.TabIndex = 2;
			this.uxTSeg2Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxTSeg2Min.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxTSeg2Min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// uxTSeg2Max
			// 
			this.uxTSeg2Max.Location = new System.Drawing.Point(910, 111);
			this.uxTSeg2Max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxTSeg2Max.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.uxTSeg2Max.Name = "uxTSeg2Max";
			this.uxTSeg2Max.Size = new System.Drawing.Size(51, 23);
			this.uxTSeg2Max.TabIndex = 2;
			this.uxTSeg2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxTSeg2Max.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxTSeg2Max.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(967, 84);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(18, 15);
			this.label20.TabIndex = 3;
			this.label20.Text = "tq";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(967, 113);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(18, 15);
			this.label21.TabIndex = 3;
			this.label21.Text = "tq";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(1056, 87);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(74, 15);
			this.label22.TabIndex = 1;
			this.label22.Text = "TSeg1 Range";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(1238, 88);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(15, 15);
			this.label23.TabIndex = 1;
			this.label23.Text = "~";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(1056, 116);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(74, 15);
			this.label24.TabIndex = 1;
			this.label24.Text = "TSeg2 Range";
			// 
			// uxDataTSeg1Min
			// 
			this.uxDataTSeg1Min.Location = new System.Drawing.Point(1186, 84);
			this.uxDataTSeg1Min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxDataTSeg1Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.uxDataTSeg1Min.Name = "uxDataTSeg1Min";
			this.uxDataTSeg1Min.Size = new System.Drawing.Size(51, 23);
			this.uxDataTSeg1Min.TabIndex = 2;
			this.uxDataTSeg1Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxDataTSeg1Min.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxDataTSeg1Min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(1238, 117);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(15, 15);
			this.label25.TabIndex = 1;
			this.label25.Text = "~";
			// 
			// uxDataTSeg2Min
			// 
			this.uxDataTSeg2Min.Location = new System.Drawing.Point(1186, 113);
			this.uxDataTSeg2Min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxDataTSeg2Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.uxDataTSeg2Min.Name = "uxDataTSeg2Min";
			this.uxDataTSeg2Min.Size = new System.Drawing.Size(51, 23);
			this.uxDataTSeg2Min.TabIndex = 2;
			this.uxDataTSeg2Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxDataTSeg2Min.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxDataTSeg2Min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// uxDataTSeg1Max
			// 
			this.uxDataTSeg1Max.Location = new System.Drawing.Point(1254, 84);
			this.uxDataTSeg1Max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxDataTSeg1Max.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.uxDataTSeg1Max.Name = "uxDataTSeg1Max";
			this.uxDataTSeg1Max.Size = new System.Drawing.Size(51, 23);
			this.uxDataTSeg1Max.TabIndex = 2;
			this.uxDataTSeg1Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxDataTSeg1Max.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxDataTSeg1Max.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// uxDataTSeg2Max
			// 
			this.uxDataTSeg2Max.Location = new System.Drawing.Point(1254, 113);
			this.uxDataTSeg2Max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.uxDataTSeg2Max.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.uxDataTSeg2Max.Name = "uxDataTSeg2Max";
			this.uxDataTSeg2Max.Size = new System.Drawing.Size(51, 23);
			this.uxDataTSeg2Max.TabIndex = 2;
			this.uxDataTSeg2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxDataTSeg2Max.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxDataTSeg2Max.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(1056, 206);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(82, 15);
			this.label26.TabIndex = 1;
			this.label26.Text = "Target Bit Rate";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(1312, 206);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(32, 15);
			this.label27.TabIndex = 3;
			this.label27.Text = "kbps";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(1312, 86);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(18, 15);
			this.label28.TabIndex = 3;
			this.label28.Text = "tq";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(1312, 115);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(18, 15);
			this.label29.TabIndex = 3;
			this.label29.Text = "tq";
			// 
			// uxDataBitRate
			// 
			this.uxDataBitRate.FormattingEnabled = true;
			this.uxDataBitRate.Location = new System.Drawing.Point(1186, 203);
			this.uxDataBitRate.Name = "uxDataBitRate";
			this.uxDataBitRate.Size = new System.Drawing.Size(120, 23);
			this.uxDataBitRate.TabIndex = 5;
			// 
			// uxCalculateCAN
			// 
			this.uxCalculateCAN.Location = new System.Drawing.Point(882, 233);
			this.uxCalculateCAN.Name = "uxCalculateCAN";
			this.uxCalculateCAN.Size = new System.Drawing.Size(117, 23);
			this.uxCalculateCAN.TabIndex = 6;
			this.uxCalculateCAN.Text = "Calculate CAN 2.0";
			this.uxCalculateCAN.UseVisualStyleBackColor = true;
			this.uxCalculateCAN.Click += new System.EventHandler(this.uxCalculateCAN_Click);
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(12, 290);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(107, 15);
			this.label30.TabIndex = 7;
			this.label30.Text = "CAN 2.0 Bit Timing";
			// 
			// uxWarning
			// 
			this.uxWarning.AutoSize = true;
			this.uxWarning.BackColor = System.Drawing.Color.LightPink;
			this.uxWarning.Location = new System.Drawing.Point(32, 113);
			this.uxWarning.Name = "uxWarning";
			this.uxWarning.Size = new System.Drawing.Size(289, 75);
			this.uxWarning.TabIndex = 8;
			this.uxWarning.Text = "Warning! Propgation delay is more than half Bit Time!\r\nTry\r\n1. Decrease Target Bi" +
    "t Rate\r\n2. Decrease Bus Length\r\n3. Use faster Transceiver\r\n";
			this.uxWarning.Visible = false;
			// 
			// uxCaculateCANResult
			// 
			this.uxCaculateCANResult.BackColor = System.Drawing.Color.LightGray;
			this.uxCaculateCANResult.Location = new System.Drawing.Point(711, 268);
			this.uxCaculateCANResult.Name = "uxCaculateCANResult";
			this.uxCaculateCANResult.Size = new System.Drawing.Size(288, 27);
			this.uxCaculateCANResult.TabIndex = 9;
			this.uxCaculateCANResult.Text = "N/A";
			this.uxCaculateCANResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// uxFDSolutions
			// 
			this.uxFDSolutions.AllowUserToAddRows = false;
			this.uxFDSolutions.AllowUserToDeleteRows = false;
			this.uxFDSolutions.AllowUserToOrderColumns = true;
			this.uxFDSolutions.AllowUserToResizeRows = false;
			this.uxFDSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uxFDSolutions.AutoGenerateColumns = false;
			this.uxFDSolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.uxFDSolutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nominalPrescalerDataGridViewTextBoxColumn,
            this.nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn,
            this.nominalResynchronizationJumpWidthDataGridViewTextBoxColumn,
            this.nominalTSeg1DataGridViewTextBoxColumn,
            this.nominalTSeg2DataGridViewTextBoxColumn,
            this.nominalSamplingPointDataGridViewTextBoxColumn,
            this.dataPrescalerDataGridViewTextBoxColumn,
            this.dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn,
            this.dataResynchronizationJumpWidthDataGridViewTextBoxColumn,
            this.dataTSeg1DataGridViewTextBoxColumn,
            this.dataTSeg2DataGridViewTextBoxColumn,
            this.dataSamplingPointDataGridViewTextBoxColumn,
            this.clockTolerancePercentageDataGridViewTextBoxColumn,
            this.clockTolerancePPMDataGridViewTextBoxColumn});
			this.uxFDSolutions.DataSource = this.cANFDBitTimingUIBindingSource;
			this.uxFDSolutions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.uxFDSolutions.Location = new System.Drawing.Point(26, 607);
			this.uxFDSolutions.Name = "uxFDSolutions";
			this.uxFDSolutions.RowHeadersVisible = false;
			this.uxFDSolutions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.uxFDSolutions.RowTemplate.Height = 24;
			this.uxFDSolutions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.uxFDSolutions.Size = new System.Drawing.Size(1318, 324);
			this.uxFDSolutions.TabIndex = 0;
			// 
			// uxCalculateCANFD
			// 
			this.uxCalculateCANFD.Location = new System.Drawing.Point(1214, 233);
			this.uxCalculateCANFD.Name = "uxCalculateCANFD";
			this.uxCalculateCANFD.Size = new System.Drawing.Size(130, 23);
			this.uxCalculateCANFD.TabIndex = 10;
			this.uxCalculateCANFD.Text = "Calculate CAN FD";
			this.uxCalculateCANFD.UseVisualStyleBackColor = true;
			this.uxCalculateCANFD.Click += new System.EventHandler(this.uxCalculateCANFD_Click);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(8, 558);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(106, 15);
			this.label31.TabIndex = 7;
			this.label31.Text = "CAN FD Bit Timing";
			// 
			// uxCaculateCANFDResult
			// 
			this.uxCaculateCANFDResult.BackColor = System.Drawing.Color.LightGray;
			this.uxCaculateCANFDResult.Location = new System.Drawing.Point(1056, 268);
			this.uxCaculateCANFDResult.Name = "uxCaculateCANFDResult";
			this.uxCaculateCANFDResult.Size = new System.Drawing.Size(288, 27);
			this.uxCaculateCANFDResult.TabIndex = 9;
			this.uxCaculateCANFDResult.Text = "N/A";
			this.uxCaculateCANFDResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// uxSetTSegToCANFDDefault
			// 
			this.uxSetTSegToCANFDDefault.Location = new System.Drawing.Point(1056, 49);
			this.uxSetTSegToCANFDDefault.Name = "uxSetTSegToCANFDDefault";
			this.uxSetTSegToCANFDDefault.Size = new System.Drawing.Size(288, 23);
			this.uxSetTSegToCANFDDefault.TabIndex = 11;
			this.uxSetTSegToCANFDDefault.Text = "Set TSeg Range to CAN FD Default";
			this.uxSetTSegToCANFDDefault.UseVisualStyleBackColor = true;
			this.uxSetTSegToCANFDDefault.Click += new System.EventHandler(this.uxSetTSegToCANFDDefault_Click);
			// 
			// uxSetTSegToCAN20Default
			// 
			this.uxSetTSegToCAN20Default.Location = new System.Drawing.Point(714, 49);
			this.uxSetTSegToCAN20Default.Name = "uxSetTSegToCAN20Default";
			this.uxSetTSegToCAN20Default.Size = new System.Drawing.Size(285, 23);
			this.uxSetTSegToCAN20Default.TabIndex = 11;
			this.uxSetTSegToCAN20Default.Text = "Set TSeg Range to CAN 2.0 Default";
			this.uxSetTSegToCAN20Default.UseVisualStyleBackColor = true;
			this.uxSetTSegToCAN20Default.Click += new System.EventHandler(this.uxSetTSegToCAN20Default_Click);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(32, 66);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(73, 15);
			this.label32.TabIndex = 12;
			this.label32.Text = "Bit Time (ns)";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(32, 49);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(127, 15);
			this.label33.TabIndex = 12;
			this.label33.Text = "Propagation Delay (ns)";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(32, 83);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(55, 15);
			this.label34.TabIndex = 13;
			this.label34.Text = "Ratio (%)";
			// 
			// uxBitTime
			// 
			this.uxBitTime.AutoSize = true;
			this.uxBitTime.Location = new System.Drawing.Point(165, 66);
			this.uxBitTime.Name = "uxBitTime";
			this.uxBitTime.Size = new System.Drawing.Size(29, 15);
			this.uxBitTime.TabIndex = 12;
			this.uxBitTime.Text = "N/A";
			// 
			// uxPropagationDelay
			// 
			this.uxPropagationDelay.AutoSize = true;
			this.uxPropagationDelay.Location = new System.Drawing.Point(165, 49);
			this.uxPropagationDelay.Name = "uxPropagationDelay";
			this.uxPropagationDelay.Size = new System.Drawing.Size(29, 15);
			this.uxPropagationDelay.TabIndex = 12;
			this.uxPropagationDelay.Text = "N/A";
			// 
			// uxPercentage
			// 
			this.uxPercentage.AutoSize = true;
			this.uxPercentage.Location = new System.Drawing.Point(165, 83);
			this.uxPercentage.Name = "uxPercentage";
			this.uxPercentage.Size = new System.Drawing.Size(29, 15);
			this.uxPercentage.TabIndex = 13;
			this.uxPercentage.Text = "N/A";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(711, 171);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(124, 15);
			this.label35.TabIndex = 1;
			this.label35.Text = "Sampling Point Range";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(893, 174);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(15, 15);
			this.label36.TabIndex = 1;
			this.label36.Text = "~";
			// 
			// uxNominalSamplingPointMin
			// 
			this.uxNominalSamplingPointMin.Location = new System.Drawing.Point(841, 169);
			this.uxNominalSamplingPointMin.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.uxNominalSamplingPointMin.Name = "uxNominalSamplingPointMin";
			this.uxNominalSamplingPointMin.Size = new System.Drawing.Size(51, 23);
			this.uxNominalSamplingPointMin.TabIndex = 2;
			this.uxNominalSamplingPointMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxNominalSamplingPointMin.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxNominalSamplingPointMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// uxNominalSamplingPointMax
			// 
			this.uxNominalSamplingPointMax.Location = new System.Drawing.Point(910, 169);
			this.uxNominalSamplingPointMax.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.uxNominalSamplingPointMax.Name = "uxNominalSamplingPointMax";
			this.uxNominalSamplingPointMax.Size = new System.Drawing.Size(51, 23);
			this.uxNominalSamplingPointMax.TabIndex = 2;
			this.uxNominalSamplingPointMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxNominalSamplingPointMax.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxNominalSamplingPointMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(967, 171);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(17, 15);
			this.label37.TabIndex = 3;
			this.label37.Text = "%";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(3, 4);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(124, 15);
			this.label38.TabIndex = 1;
			this.label38.Text = "Sampling Point Range";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(185, 7);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(15, 15);
			this.label39.TabIndex = 1;
			this.label39.Text = "~";
			// 
			// uxDataSamplingPointMin
			// 
			this.uxDataSamplingPointMin.Location = new System.Drawing.Point(133, 2);
			this.uxDataSamplingPointMin.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.uxDataSamplingPointMin.Name = "uxDataSamplingPointMin";
			this.uxDataSamplingPointMin.Size = new System.Drawing.Size(51, 23);
			this.uxDataSamplingPointMin.TabIndex = 2;
			this.uxDataSamplingPointMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxDataSamplingPointMin.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxDataSamplingPointMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// uxDataSamplingPointMax
			// 
			this.uxDataSamplingPointMax.Location = new System.Drawing.Point(202, 2);
			this.uxDataSamplingPointMax.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.uxDataSamplingPointMax.Name = "uxDataSamplingPointMax";
			this.uxDataSamplingPointMax.Size = new System.Drawing.Size(51, 23);
			this.uxDataSamplingPointMax.TabIndex = 2;
			this.uxDataSamplingPointMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.uxDataSamplingPointMax.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.uxDataSamplingPointMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(259, 4);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(17, 15);
			this.label40.TabIndex = 3;
			this.label40.Text = "%";
			// 
			// uxSecondarySamplingPoint
			// 
			this.uxSecondarySamplingPoint.AutoSize = true;
			this.uxSecondarySamplingPoint.Checked = true;
			this.uxSecondarySamplingPoint.CheckState = System.Windows.Forms.CheckState.Checked;
			this.uxSecondarySamplingPoint.Location = new System.Drawing.Point(1059, 142);
			this.uxSecondarySamplingPoint.Name = "uxSecondarySamplingPoint";
			this.uxSecondarySamplingPoint.Size = new System.Drawing.Size(165, 19);
			this.uxSecondarySamplingPoint.TabIndex = 14;
			this.uxSecondarySamplingPoint.Text = "Secondary Sampling Point";
			this.uxSecondarySamplingPoint.UseVisualStyleBackColor = true;
			this.uxSecondarySamplingPoint.CheckedChanged += new System.EventHandler(this.uxSecondarySamplingPoint_CheckedChanged);
			// 
			// uxSSPPanel
			// 
			this.uxSSPPanel.Controls.Add(this.label38);
			this.uxSSPPanel.Controls.Add(this.label39);
			this.uxSSPPanel.Controls.Add(this.uxDataSamplingPointMin);
			this.uxSSPPanel.Controls.Add(this.uxDataSamplingPointMax);
			this.uxSSPPanel.Controls.Add(this.label40);
			this.uxSSPPanel.Enabled = false;
			this.uxSSPPanel.Location = new System.Drawing.Point(1053, 167);
			this.uxSSPPanel.Name = "uxSSPPanel";
			this.uxSSPPanel.Size = new System.Drawing.Size(278, 27);
			this.uxSSPPanel.TabIndex = 15;
			// 
			// label41
			// 
			this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label41.Location = new System.Drawing.Point(27, 578);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(542, 26);
			this.label41.TabIndex = 16;
			this.label41.Text = "Norminal";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label42
			// 
			this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label42.Location = new System.Drawing.Point(568, 578);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(542, 26);
			this.label42.TabIndex = 16;
			this.label42.Text = "Data";
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nominalPrescalerDataGridViewTextBoxColumn
			// 
			this.nominalPrescalerDataGridViewTextBoxColumn.DataPropertyName = "NominalPrescaler";
			this.nominalPrescalerDataGridViewTextBoxColumn.HeaderText = "N.Prescaler";
			this.nominalPrescalerDataGridViewTextBoxColumn.Name = "nominalPrescalerDataGridViewTextBoxColumn";
			this.nominalPrescalerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn
			// 
			this.nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.DataPropertyName = "NominalNumberOfTimeQuantaPerBit";
			this.nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.HeaderText = "N.BT (tq)";
			this.nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.Name = "nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn";
			this.nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.ReadOnly = true;
			this.nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.Width = 80;
			// 
			// nominalResynchronizationJumpWidthDataGridViewTextBoxColumn
			// 
			this.nominalResynchronizationJumpWidthDataGridViewTextBoxColumn.DataPropertyName = "NominalResynchronizationJumpWidth";
			this.nominalResynchronizationJumpWidthDataGridViewTextBoxColumn.HeaderText = "N.SJW (tq)";
			this.nominalResynchronizationJumpWidthDataGridViewTextBoxColumn.Name = "nominalResynchronizationJumpWidthDataGridViewTextBoxColumn";
			this.nominalResynchronizationJumpWidthDataGridViewTextBoxColumn.ReadOnly = true;
			this.nominalResynchronizationJumpWidthDataGridViewTextBoxColumn.Width = 80;
			// 
			// nominalTSeg1DataGridViewTextBoxColumn
			// 
			this.nominalTSeg1DataGridViewTextBoxColumn.DataPropertyName = "NominalTSeg1";
			this.nominalTSeg1DataGridViewTextBoxColumn.HeaderText = "N.TSeg1 (tq)";
			this.nominalTSeg1DataGridViewTextBoxColumn.Name = "nominalTSeg1DataGridViewTextBoxColumn";
			this.nominalTSeg1DataGridViewTextBoxColumn.ReadOnly = true;
			this.nominalTSeg1DataGridViewTextBoxColumn.Width = 90;
			// 
			// nominalTSeg2DataGridViewTextBoxColumn
			// 
			this.nominalTSeg2DataGridViewTextBoxColumn.DataPropertyName = "NominalTSeg2";
			this.nominalTSeg2DataGridViewTextBoxColumn.HeaderText = "N.TSeg2 (tq)";
			this.nominalTSeg2DataGridViewTextBoxColumn.Name = "nominalTSeg2DataGridViewTextBoxColumn";
			this.nominalTSeg2DataGridViewTextBoxColumn.ReadOnly = true;
			this.nominalTSeg2DataGridViewTextBoxColumn.Width = 90;
			// 
			// nominalSamplingPointDataGridViewTextBoxColumn
			// 
			this.nominalSamplingPointDataGridViewTextBoxColumn.DataPropertyName = "NominalSamplingPoint";
			dataGridViewCellStyle3.Format = "N2";
			this.nominalSamplingPointDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.nominalSamplingPointDataGridViewTextBoxColumn.HeaderText = "N.Sampling Point (%)";
			this.nominalSamplingPointDataGridViewTextBoxColumn.Name = "nominalSamplingPointDataGridViewTextBoxColumn";
			this.nominalSamplingPointDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataPrescalerDataGridViewTextBoxColumn
			// 
			this.dataPrescalerDataGridViewTextBoxColumn.DataPropertyName = "DataPrescaler";
			this.dataPrescalerDataGridViewTextBoxColumn.HeaderText = "D.Prescaler";
			this.dataPrescalerDataGridViewTextBoxColumn.Name = "dataPrescalerDataGridViewTextBoxColumn";
			this.dataPrescalerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn
			// 
			this.dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.DataPropertyName = "DataNumberOfTimeQuantaPerBit";
			this.dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.HeaderText = "D.BT (tq)";
			this.dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.Name = "dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn";
			this.dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn.Width = 80;
			// 
			// dataResynchronizationJumpWidthDataGridViewTextBoxColumn
			// 
			this.dataResynchronizationJumpWidthDataGridViewTextBoxColumn.DataPropertyName = "DataResynchronizationJumpWidth";
			this.dataResynchronizationJumpWidthDataGridViewTextBoxColumn.HeaderText = "D.SJW (tq)";
			this.dataResynchronizationJumpWidthDataGridViewTextBoxColumn.Name = "dataResynchronizationJumpWidthDataGridViewTextBoxColumn";
			this.dataResynchronizationJumpWidthDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataResynchronizationJumpWidthDataGridViewTextBoxColumn.Width = 80;
			// 
			// dataTSeg1DataGridViewTextBoxColumn
			// 
			this.dataTSeg1DataGridViewTextBoxColumn.DataPropertyName = "DataTSeg1";
			this.dataTSeg1DataGridViewTextBoxColumn.HeaderText = "D.TSeg1 (tq)";
			this.dataTSeg1DataGridViewTextBoxColumn.Name = "dataTSeg1DataGridViewTextBoxColumn";
			this.dataTSeg1DataGridViewTextBoxColumn.ReadOnly = true;
			this.dataTSeg1DataGridViewTextBoxColumn.Width = 90;
			// 
			// dataTSeg2DataGridViewTextBoxColumn
			// 
			this.dataTSeg2DataGridViewTextBoxColumn.DataPropertyName = "DataTSeg2";
			this.dataTSeg2DataGridViewTextBoxColumn.HeaderText = "D.TSeg2 (tq)";
			this.dataTSeg2DataGridViewTextBoxColumn.Name = "dataTSeg2DataGridViewTextBoxColumn";
			this.dataTSeg2DataGridViewTextBoxColumn.ReadOnly = true;
			this.dataTSeg2DataGridViewTextBoxColumn.Width = 90;
			// 
			// dataSamplingPointDataGridViewTextBoxColumn
			// 
			this.dataSamplingPointDataGridViewTextBoxColumn.DataPropertyName = "DataSamplingPoint";
			dataGridViewCellStyle4.Format = "N2";
			this.dataSamplingPointDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataSamplingPointDataGridViewTextBoxColumn.HeaderText = "D.Smpling Point (%)";
			this.dataSamplingPointDataGridViewTextBoxColumn.Name = "dataSamplingPointDataGridViewTextBoxColumn";
			this.dataSamplingPointDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clockTolerancePercentageDataGridViewTextBoxColumn
			// 
			this.clockTolerancePercentageDataGridViewTextBoxColumn.DataPropertyName = "ClockTolerancePercentage";
			dataGridViewCellStyle5.Format = "N4";
			this.clockTolerancePercentageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.clockTolerancePercentageDataGridViewTextBoxColumn.HeaderText = "Clock Tolerance (%)";
			this.clockTolerancePercentageDataGridViewTextBoxColumn.Name = "clockTolerancePercentageDataGridViewTextBoxColumn";
			this.clockTolerancePercentageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clockTolerancePPMDataGridViewTextBoxColumn
			// 
			this.clockTolerancePPMDataGridViewTextBoxColumn.DataPropertyName = "ClockTolerancePPM";
			dataGridViewCellStyle6.Format = "N0";
			this.clockTolerancePPMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.clockTolerancePPMDataGridViewTextBoxColumn.HeaderText = "Clock Tolerance (ppm)";
			this.clockTolerancePPMDataGridViewTextBoxColumn.Name = "clockTolerancePPMDataGridViewTextBoxColumn";
			this.clockTolerancePPMDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cANFDBitTimingUIBindingSource
			// 
			this.cANFDBitTimingUIBindingSource.DataSource = typeof(CAN_Bus_BitTimingCalculator.CANFDBitTimingUI);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Prescaler";
			this.dataGridViewTextBoxColumn1.HeaderText = "Prescaler";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "NumberOfTimeQuantaPerBit";
			this.dataGridViewTextBoxColumn2.HeaderText = "NBT (tq)";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "PropagationTimeSegment";
			this.dataGridViewTextBoxColumn3.HeaderText = "Prop_Seg (tq)";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "PhraseBufferSegment1";
			this.dataGridViewTextBoxColumn4.HeaderText = "Phrase_Seg1 (tq)";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "PhraseBufferSegment2";
			this.dataGridViewTextBoxColumn5.HeaderText = "Phrase_Seg2 (tq)";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "ResynchronizationJumpWidth";
			this.dataGridViewTextBoxColumn6.HeaderText = "SJW (tq)";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "TSeg1";
			this.dataGridViewTextBoxColumn7.HeaderText = "TSeg1 (tq)";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "TSeg2";
			this.dataGridViewTextBoxColumn8.HeaderText = "TSeg2 (tq)";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.DataPropertyName = "SamplingPoint";
			dataGridViewCellStyle1.Format = "N2";
			this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn22.HeaderText = "Sampling Point (%)";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			// 
			// clockTolerancePercentageDataGridViewTextBoxColumn1
			// 
			this.clockTolerancePercentageDataGridViewTextBoxColumn1.DataPropertyName = "ClockTolerancePercentage";
			dataGridViewCellStyle2.Format = "N2";
			this.clockTolerancePercentageDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
			this.clockTolerancePercentageDataGridViewTextBoxColumn1.HeaderText = "Colock Tolerance (%)";
			this.clockTolerancePercentageDataGridViewTextBoxColumn1.Name = "clockTolerancePercentageDataGridViewTextBoxColumn1";
			this.clockTolerancePercentageDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// uxClockTolerancePPMColumn
			// 
			this.uxClockTolerancePPMColumn.DataPropertyName = "ClockTolerancePPM";
			this.uxClockTolerancePPMColumn.HeaderText = "Colock Tolerance (ppm)";
			this.uxClockTolerancePPMColumn.Name = "uxClockTolerancePPMColumn";
			this.uxClockTolerancePPMColumn.ReadOnly = true;
			// 
			// cANBitTimingUIBindingSource
			// 
			this.cANBitTimingUIBindingSource.DataSource = typeof(CAN_Bus_BitTimingCalculator.CANBitTimingUI);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1356, 943);
			this.Controls.Add(this.label42);
			this.Controls.Add(this.label41);
			this.Controls.Add(this.uxSSPPanel);
			this.Controls.Add(this.uxSecondarySamplingPoint);
			this.Controls.Add(this.uxPercentage);
			this.Controls.Add(this.label34);
			this.Controls.Add(this.uxPropagationDelay);
			this.Controls.Add(this.label33);
			this.Controls.Add(this.uxBitTime);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.uxSetTSegToCAN20Default);
			this.Controls.Add(this.uxSetTSegToCANFDDefault);
			this.Controls.Add(this.uxCalculateCANFD);
			this.Controls.Add(this.uxCaculateCANFDResult);
			this.Controls.Add(this.uxCaculateCANResult);
			this.Controls.Add(this.uxWarning);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.uxCalculateCAN);
			this.Controls.Add(this.uxDataBitRate);
			this.Controls.Add(this.uxNominalBitRate);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label37);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.uxIPT);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.uxTransceiverLoopDelay);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.uxDataTSeg2Max);
			this.Controls.Add(this.uxNominalSamplingPointMax);
			this.Controls.Add(this.uxTSeg2Max);
			this.Controls.Add(this.uxDataTSeg1Max);
			this.Controls.Add(this.uxTSeg1Max);
			this.Controls.Add(this.uxDataTSeg2Min);
			this.Controls.Add(this.uxNominalSamplingPointMin);
			this.Controls.Add(this.uxTSeg2Min);
			this.Controls.Add(this.label36);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.uxDataTSeg1Min);
			this.Controls.Add(this.uxTSeg1Min);
			this.Controls.Add(this.label35);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.uxClockFrequency);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.uxBusLength);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.uxBusPropagationDelay);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uxFDSolutions);
			this.Controls.Add(this.uxNominalSolutions);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "CAN Bus Bit Timing Calculator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.uxNominalSolutions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxBusPropagationDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxBusLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxClockFrequency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTransceiverLoopDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxIPT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg1Min)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg1Max)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg2Min)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxTSeg2Max)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg1Min)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg2Min)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg1Max)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataTSeg2Max)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxFDSolutions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxNominalSamplingPointMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxNominalSamplingPointMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataSamplingPointMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxDataSamplingPointMax)).EndInit();
			this.uxSSPPanel.ResumeLayout(false);
			this.uxSSPPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cANFDBitTimingUIBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cANBitTimingUIBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView uxNominalSolutions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown uxBusPropagationDelay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown uxBusLength;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown uxClockFrequency;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown uxTransceiverLoopDelay;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown uxIPT;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown uxTSeg1Min;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox uxNominalBitRate;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.NumericUpDown uxTSeg1Max;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.NumericUpDown uxTSeg2Min;
		private System.Windows.Forms.NumericUpDown uxTSeg2Max;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.NumericUpDown uxDataTSeg1Min;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.NumericUpDown uxDataTSeg2Min;
		private System.Windows.Forms.NumericUpDown uxDataTSeg1Max;
		private System.Windows.Forms.NumericUpDown uxDataTSeg2Max;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.ComboBox uxDataBitRate;
		private System.Windows.Forms.Button uxCalculateCAN;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label uxWarning;
		private System.Windows.Forms.Label uxCaculateCANResult;
		private System.Windows.Forms.DataGridView uxFDSolutions;
		private System.Windows.Forms.Button uxCalculateCANFD;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label uxCaculateCANFDResult;
		private System.Windows.Forms.Button uxSetTSegToCANFDDefault;
		private System.Windows.Forms.Button uxSetTSegToCAN20Default;
		private System.Windows.Forms.BindingSource cANBitTimingUIBindingSource;
		private System.Windows.Forms.BindingSource cANFDBitTimingUIBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn clockTolerancePercentageDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn uxClockTolerancePPMColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label uxBitTime;
		private System.Windows.Forms.Label uxPropagationDelay;
		private System.Windows.Forms.Label uxPercentage;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.NumericUpDown uxNominalSamplingPointMin;
		private System.Windows.Forms.NumericUpDown uxNominalSamplingPointMax;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.NumericUpDown uxDataSamplingPointMin;
		private System.Windows.Forms.NumericUpDown uxDataSamplingPointMax;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.DataGridViewTextBoxColumn nominalPrescalerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nominalNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nominalResynchronizationJumpWidthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nominalTSeg1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nominalTSeg2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nominalSamplingPointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataPrescalerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNumberOfTimeQuantaPerBitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataResynchronizationJumpWidthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTSeg1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTSeg2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataSamplingPointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clockTolerancePercentageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clockTolerancePPMDataGridViewTextBoxColumn;
		private System.Windows.Forms.CheckBox uxSecondarySamplingPoint;
		private System.Windows.Forms.Panel uxSSPPanel;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.ToolTip uxToolTip;
	}
}

