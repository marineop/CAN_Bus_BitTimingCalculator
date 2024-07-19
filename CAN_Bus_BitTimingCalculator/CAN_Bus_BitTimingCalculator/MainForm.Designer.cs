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
			this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
			this.label25 = new System.Windows.Forms.Label();
			this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.uxCalculate = new System.Windows.Forms.Button();
			this.label30 = new System.Windows.Forms.Label();
			this.uxWarning = new System.Windows.Forms.Label();
			this.uxNominalResult = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClockTolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
			this.SuspendLayout();
			// 
			// uxNominalSolutions
			// 
			this.uxNominalSolutions.AllowUserToAddRows = false;
			this.uxNominalSolutions.AllowUserToDeleteRows = false;
			this.uxNominalSolutions.AllowUserToOrderColumns = true;
			this.uxNominalSolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.uxNominalSolutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column9,
            this.ClockTolerance});
			this.uxNominalSolutions.Location = new System.Drawing.Point(12, 287);
			this.uxNominalSolutions.Name = "uxNominalSolutions";
			this.uxNominalSolutions.ReadOnly = true;
			this.uxNominalSolutions.RowHeadersVisible = false;
			this.uxNominalSolutions.RowTemplate.Height = 24;
			this.uxNominalSolutions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.uxNominalSolutions.Size = new System.Drawing.Size(574, 385);
			this.uxNominalSolutions.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bus Propagation Delay";
			// 
			// uxBusPropagationDelay
			// 
			this.uxBusPropagationDelay.Location = new System.Drawing.Point(170, 82);
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
			this.label2.Location = new System.Drawing.Point(243, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "ns / m";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Bus Length";
			// 
			// uxBusLength
			// 
			this.uxBusLength.DecimalPlaces = 1;
			this.uxBusLength.Location = new System.Drawing.Point(170, 53);
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
			this.label4.Location = new System.Drawing.Point(243, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "m";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "Clock Frequency";
			// 
			// uxClockFrequency
			// 
			this.uxClockFrequency.DecimalPlaces = 1;
			this.uxClockFrequency.Location = new System.Drawing.Point(170, 140);
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
			this.label6.Location = new System.Drawing.Point(243, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 15);
			this.label6.TabIndex = 3;
			this.label6.Text = "MHz";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(28, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(127, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "Transceiver Loop Delay";
			// 
			// uxTransceiverLoopDelay
			// 
			this.uxTransceiverLoopDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.uxTransceiverLoopDelay.Location = new System.Drawing.Point(170, 169);
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
			this.label8.Location = new System.Drawing.Point(243, 171);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 15);
			this.label8.TabIndex = 3;
			this.label8.Text = "ns";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(28, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 15);
			this.label9.TabIndex = 1;
			this.label9.Text = "CAN Controller IPT";
			// 
			// uxIPT
			// 
			this.uxIPT.Location = new System.Drawing.Point(170, 111);
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
			this.label10.Location = new System.Drawing.Point(243, 113);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(18, 15);
			this.label10.TabIndex = 3;
			this.label10.Text = "tq";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 23);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 15);
			this.label11.TabIndex = 4;
			this.label11.Text = "Common Parameters";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(294, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(182, 30);
			this.label12.TabIndex = 4;
			this.label12.Text = "CAN Bus 2.0 Parameters \r\n(or CAN FD Nominal Parameters)";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(633, 23);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(138, 15);
			this.label13.TabIndex = 4;
			this.label13.Text = "CAN FD Data Parameters";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(321, 76);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 15);
			this.label14.TabIndex = 1;
			this.label14.Text = "TSeg1 Range";
			// 
			// uxTSeg1Min
			// 
			this.uxTSeg1Min.Location = new System.Drawing.Point(432, 74);
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
			this.label16.Location = new System.Drawing.Point(321, 134);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(82, 15);
			this.label16.TabIndex = 1;
			this.label16.Text = "Target Bit Rate";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(575, 134);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(32, 15);
			this.label17.TabIndex = 3;
			this.label17.Text = "kbps";
			// 
			// uxNominalBitRate
			// 
			this.uxNominalBitRate.FormattingEnabled = true;
			this.uxNominalBitRate.Location = new System.Drawing.Point(432, 132);
			this.uxNominalBitRate.Name = "uxNominalBitRate";
			this.uxNominalBitRate.Size = new System.Drawing.Size(129, 23);
			this.uxNominalBitRate.TabIndex = 5;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(489, 82);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(15, 15);
			this.label18.TabIndex = 1;
			this.label18.Text = "~";
			// 
			// uxTSeg1Max
			// 
			this.uxTSeg1Max.Location = new System.Drawing.Point(510, 74);
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
			this.label15.Location = new System.Drawing.Point(321, 105);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 15);
			this.label15.TabIndex = 1;
			this.label15.Text = "TSeg2 Range";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(489, 111);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(15, 15);
			this.label19.TabIndex = 1;
			this.label19.Text = "~";
			// 
			// uxTSeg2Min
			// 
			this.uxTSeg2Min.Location = new System.Drawing.Point(432, 103);
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
			this.uxTSeg2Max.Location = new System.Drawing.Point(510, 103);
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
			this.label20.Location = new System.Drawing.Point(575, 76);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(18, 15);
			this.label20.TabIndex = 3;
			this.label20.Text = "tq";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(575, 105);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(18, 15);
			this.label21.TabIndex = 3;
			this.label21.Text = "tq";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(674, 70);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(74, 15);
			this.label22.TabIndex = 1;
			this.label22.Text = "TSeg1 Range";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(842, 76);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(15, 15);
			this.label23.TabIndex = 1;
			this.label23.Text = "~";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(674, 99);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(74, 15);
			this.label24.TabIndex = 1;
			this.label24.Text = "TSeg2 Range";
			// 
			// numericUpDown9
			// 
			this.numericUpDown9.Location = new System.Drawing.Point(785, 68);
			this.numericUpDown9.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown9.Name = "numericUpDown9";
			this.numericUpDown9.Size = new System.Drawing.Size(51, 23);
			this.numericUpDown9.TabIndex = 2;
			this.numericUpDown9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown9.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(842, 105);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(15, 15);
			this.label25.TabIndex = 1;
			this.label25.Text = "~";
			// 
			// numericUpDown10
			// 
			this.numericUpDown10.Location = new System.Drawing.Point(785, 97);
			this.numericUpDown10.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown10.Name = "numericUpDown10";
			this.numericUpDown10.Size = new System.Drawing.Size(51, 23);
			this.numericUpDown10.TabIndex = 2;
			this.numericUpDown10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown10.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numericUpDown10.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown11
			// 
			this.numericUpDown11.Location = new System.Drawing.Point(863, 68);
			this.numericUpDown11.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown11.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.numericUpDown11.Name = "numericUpDown11";
			this.numericUpDown11.Size = new System.Drawing.Size(51, 23);
			this.numericUpDown11.TabIndex = 2;
			this.numericUpDown11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown11.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numericUpDown11.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// numericUpDown12
			// 
			this.numericUpDown12.Location = new System.Drawing.Point(863, 97);
			this.numericUpDown12.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown12.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numericUpDown12.Name = "numericUpDown12";
			this.numericUpDown12.Size = new System.Drawing.Size(51, 23);
			this.numericUpDown12.TabIndex = 2;
			this.numericUpDown12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown12.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numericUpDown12.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(674, 128);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(82, 15);
			this.label26.TabIndex = 1;
			this.label26.Text = "Target Bit Rate";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(928, 128);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(32, 15);
			this.label27.TabIndex = 3;
			this.label27.Text = "kbps";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(928, 70);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(18, 15);
			this.label28.TabIndex = 3;
			this.label28.Text = "tq";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(928, 99);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(18, 15);
			this.label29.TabIndex = 3;
			this.label29.Text = "tq";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(785, 126);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(129, 23);
			this.comboBox2.TabIndex = 5;
			// 
			// uxCalculate
			// 
			this.uxCalculate.Location = new System.Drawing.Point(12, 214);
			this.uxCalculate.Name = "uxCalculate";
			this.uxCalculate.Size = new System.Drawing.Size(75, 23);
			this.uxCalculate.TabIndex = 6;
			this.uxCalculate.Text = "Calculate";
			this.uxCalculate.UseVisualStyleBackColor = true;
			this.uxCalculate.Click += new System.EventHandler(this.uxCalculate_Click);
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(13, 269);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(288, 15);
			this.label30.TabIndex = 7;
			this.label30.Text = "CAN Bus 2.0 Bit Timing (CAN FD Nominal Bit Timing)";
			// 
			// uxWarning
			// 
			this.uxWarning.AutoSize = true;
			this.uxWarning.BackColor = System.Drawing.Color.LightPink;
			this.uxWarning.Location = new System.Drawing.Point(294, 171);
			this.uxWarning.Name = "uxWarning";
			this.uxWarning.Size = new System.Drawing.Size(289, 75);
			this.uxWarning.TabIndex = 8;
			this.uxWarning.Text = "Warning! Propgation delay is more than half Bit Time!\r\nTry\r\n1. Decrease Target Bi" +
    "t Rate\r\n2. Decrease Bus Length\r\n3. Use faster Transceiver\r\n";
			this.uxWarning.Visible = false;
			// 
			// uxNominalResult
			// 
			this.uxNominalResult.Location = new System.Drawing.Point(324, 257);
			this.uxNominalResult.Name = "uxNominalResult";
			this.uxNominalResult.Size = new System.Drawing.Size(262, 27);
			this.uxNominalResult.TabIndex = 9;
			this.uxNominalResult.Text = "N/A";
			this.uxNominalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "Prescaler";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 79;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "Ntq";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 52;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column5.HeaderText = "TSeg1";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 63;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column6.HeaderText = "TSeg2";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 63;
			// 
			// Column10
			// 
			this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column10.HeaderText = "SJW (RJW)";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 86;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = null;
			this.Column9.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column9.HeaderText = "Sampling Point (%)";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 106;
			// 
			// ClockTolerance
			// 
			this.ClockTolerance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.Format = "N4";
			dataGridViewCellStyle2.NullValue = null;
			this.ClockTolerance.DefaultCellStyle = dataGridViewCellStyle2;
			this.ClockTolerance.HeaderText = "Clock Tolerance (%)";
			this.ClockTolerance.Name = "ClockTolerance";
			this.ClockTolerance.ReadOnly = true;
			this.ClockTolerance.Width = 108;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1174, 695);
			this.Controls.Add(this.uxNominalResult);
			this.Controls.Add(this.uxWarning);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.uxCalculate);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.uxNominalBitRate);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label29);
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
			this.Controls.Add(this.numericUpDown12);
			this.Controls.Add(this.uxTSeg2Max);
			this.Controls.Add(this.numericUpDown11);
			this.Controls.Add(this.uxTSeg1Max);
			this.Controls.Add(this.numericUpDown10);
			this.Controls.Add(this.uxTSeg2Min);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.numericUpDown9);
			this.Controls.Add(this.uxTSeg1Min);
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
			this.Controls.Add(this.uxNominalSolutions);
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
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
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
		private System.Windows.Forms.NumericUpDown numericUpDown9;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.NumericUpDown numericUpDown10;
		private System.Windows.Forms.NumericUpDown numericUpDown11;
		private System.Windows.Forms.NumericUpDown numericUpDown12;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button uxCalculate;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label uxWarning;
		private System.Windows.Forms.Label uxNominalResult;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClockTolerance;
	}
}

