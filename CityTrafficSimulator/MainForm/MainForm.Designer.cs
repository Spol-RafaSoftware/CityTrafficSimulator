﻿/*
 *  CityTrafficSimulator - a tool to simulate traffic in urban areas and on intersections
 *  Copyright (C) 2005-2010, Christian Schulte zu Berge
 *  
 *  This program is free software; you can redistribute it and/or modify it under the 
 *  terms of the GNU General Public License as published by the Free Software 
 *  Foundation; either version 3 of the License, or (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful, but WITHOUT ANY 
 *  WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A 
 *  PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License along with this 
 *  program; if not, see <http://www.gnu.org/licenses/>.
 * 
 *  Web:  http://www.cszb.net
 *  Mail: software@cszb.net
 */

namespace CityTrafficSimulator
    {
	/// <summary>
	/// Hauptformular von CityTrafficSimulator
	/// </summary>
    partial class MainForm
        {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
            {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnlSimulationSetup = new System.Windows.Forms.Panel();
			this.stepsPerSecondSpinEdit = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.timerOnCheckBox = new System.Windows.Forms.CheckBox();
			this.stepButton = new System.Windows.Forms.Button();
			this.killAllVehiclesButton = new System.Windows.Forms.Button();
			this.simulationSpeedSpinEdit = new System.Windows.Forms.NumericUpDown();
			this.pnlMainGrid = new System.Windows.Forms.Panel();
			this.pnlNetworkInfo = new System.Windows.Forms.Panel();
			this.SpeichernButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.aboutBoxButton = new System.Windows.Forms.Button();
			this.titleEdit = new System.Windows.Forms.TextBox();
			this.LadenButton = new System.Windows.Forms.Button();
			this.infoEdit = new System.Windows.Forms.TextBox();
			this.pnlRenderSetup = new System.Windows.Forms.Panel();
			this.cbRenderLineChangePoints = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbRenderIntersections = new System.Windows.Forms.CheckBox();
			this.zoomComboBox = new System.Windows.Forms.ComboBox();
			this.cbRenderVehiclesDebug = new System.Windows.Forms.CheckBox();
			this.cbRenderStatistics = new System.Windows.Forms.CheckBox();
			this.cbRenderVehicles = new System.Windows.Forms.CheckBox();
			this.renderQualityComboBox = new System.Windows.Forms.ComboBox();
			this.cbRenderConnectionsDebug = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cbRenderConnections = new System.Windows.Forms.CheckBox();
			this.cbRenderLineNodes = new System.Windows.Forms.CheckBox();
			this.cbRenderLineNodesDebug = new System.Windows.Forms.CheckBox();
			this.pnlSignalAssignment = new System.Windows.Forms.Panel();
			this.freeNodeButton = new System.Windows.Forms.Button();
			this.pnlCanvasSetup = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.canvasHeigthSpinEdit = new System.Windows.Forms.NumericUpDown();
			this.canvasWidthSpinEdit = new System.Windows.Forms.NumericUpDown();
			this.lockNodesCheckBox = new System.Windows.Forms.CheckBox();
			this.HintergrundbildGroupBox = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.backgroundImageScalingSpinEdit = new System.Windows.Forms.NumericUpDown();
			this.clearBackgroudnImageButton = new System.Windows.Forms.Button();
			this.BildLadenButton = new System.Windows.Forms.Button();
			this.backgroundImageEdit = new System.Windows.Forms.TextBox();
			this.pnlConnectionSetup = new System.Windows.Forms.Panel();
			this.spinTargetVelocity = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.enableIncomingLineChangeCheckBox = new System.Windows.Forms.CheckBox();
			this.findLineChangePointsButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.enableOutgoingLineChangeCheckBox = new System.Windows.Forms.CheckBox();
			this.nodeConnectionPrioritySpinEdit = new System.Windows.Forms.NumericUpDown();
			this.tramAllowedCheckBox = new System.Windows.Forms.CheckBox();
			this.carsAllowedCheckBox = new System.Windows.Forms.CheckBox();
			this.busAllowedCheckBox = new System.Windows.Forms.CheckBox();
			this.statusleiste = new System.Windows.Forms.StatusStrip();
			this.statusMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.thumbGrid = new CityTrafficSimulator.RechenkaestchenControl();
			this.DaGrid = new CityTrafficSimulator.RechenkaestchenControl();
			this.trafficLightTreeView = new CityTrafficSimulator.Timeline.TrafficLightTreeView(this.components);
			this.cbRenderFps = new System.Windows.Forms.CheckBox();
			this.pnlSimulationSetup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.stepsPerSecondSpinEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.simulationSpeedSpinEdit)).BeginInit();
			this.pnlMainGrid.SuspendLayout();
			this.pnlNetworkInfo.SuspendLayout();
			this.pnlRenderSetup.SuspendLayout();
			this.pnlSignalAssignment.SuspendLayout();
			this.pnlCanvasSetup.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvasHeigthSpinEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.canvasWidthSpinEdit)).BeginInit();
			this.HintergrundbildGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.backgroundImageScalingSpinEdit)).BeginInit();
			this.pnlConnectionSetup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinTargetVelocity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nodeConnectionPrioritySpinEdit)).BeginInit();
			this.statusleiste.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 67;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pnlSimulationSetup
			// 
			this.pnlSimulationSetup.AutoScroll = true;
			this.pnlSimulationSetup.Controls.Add(this.stepsPerSecondSpinEdit);
			this.pnlSimulationSetup.Controls.Add(this.label11);
			this.pnlSimulationSetup.Controls.Add(this.label12);
			this.pnlSimulationSetup.Controls.Add(this.timerOnCheckBox);
			this.pnlSimulationSetup.Controls.Add(this.stepButton);
			this.pnlSimulationSetup.Controls.Add(this.killAllVehiclesButton);
			this.pnlSimulationSetup.Controls.Add(this.simulationSpeedSpinEdit);
			this.pnlSimulationSetup.Location = new System.Drawing.Point(795, 14);
			this.pnlSimulationSetup.Name = "pnlSimulationSetup";
			this.pnlSimulationSetup.Size = new System.Drawing.Size(307, 200);
			this.pnlSimulationSetup.TabIndex = 9;
			// 
			// stepsPerSecondSpinEdit
			// 
			this.stepsPerSecondSpinEdit.Location = new System.Drawing.Point(188, 29);
			this.stepsPerSecondSpinEdit.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.stepsPerSecondSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.stepsPerSecondSpinEdit.Name = "stepsPerSecondSpinEdit";
			this.stepsPerSecondSpinEdit.Size = new System.Drawing.Size(88, 20);
			this.stepsPerSecondSpinEdit.TabIndex = 26;
			this.stepsPerSecondSpinEdit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.stepsPerSecondSpinEdit.ValueChanged += new System.EventHandler(this.stepsPerSecondSpinEdit_ValueChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 5);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(92, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "Simulation Speed:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 31);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(70, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "Sim. Steps/s:";
			// 
			// timerOnCheckBox
			// 
			this.timerOnCheckBox.AutoSize = true;
			this.timerOnCheckBox.Location = new System.Drawing.Point(6, 59);
			this.timerOnCheckBox.Name = "timerOnCheckBox";
			this.timerOnCheckBox.Size = new System.Drawing.Size(110, 17);
			this.timerOnCheckBox.TabIndex = 6;
			this.timerOnCheckBox.Text = "Enable Simulation";
			this.timerOnCheckBox.UseVisualStyleBackColor = true;
			this.timerOnCheckBox.CheckedChanged += new System.EventHandler(this.timerOnCheckBox_CheckedChanged);
			// 
			// stepButton
			// 
			this.stepButton.Location = new System.Drawing.Point(188, 55);
			this.stepButton.Name = "stepButton";
			this.stepButton.Size = new System.Drawing.Size(88, 23);
			this.stepButton.TabIndex = 9;
			this.stepButton.Text = "Single Step";
			this.stepButton.UseVisualStyleBackColor = true;
			this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
			// 
			// killAllVehiclesButton
			// 
			this.killAllVehiclesButton.Location = new System.Drawing.Point(114, 84);
			this.killAllVehiclesButton.Name = "killAllVehiclesButton";
			this.killAllVehiclesButton.Size = new System.Drawing.Size(162, 23);
			this.killAllVehiclesButton.TabIndex = 11;
			this.killAllVehiclesButton.Text = "Remove all Vehicles";
			this.killAllVehiclesButton.UseVisualStyleBackColor = true;
			this.killAllVehiclesButton.Click += new System.EventHandler(this.killAllVehiclesButton_Click);
			// 
			// simulationSpeedSpinEdit
			// 
			this.simulationSpeedSpinEdit.Location = new System.Drawing.Point(188, 3);
			this.simulationSpeedSpinEdit.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.simulationSpeedSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.simulationSpeedSpinEdit.Name = "simulationSpeedSpinEdit";
			this.simulationSpeedSpinEdit.Size = new System.Drawing.Size(88, 20);
			this.simulationSpeedSpinEdit.TabIndex = 23;
			this.simulationSpeedSpinEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.simulationSpeedSpinEdit.ValueChanged += new System.EventHandler(this.simulationSpeedSpinEdit_ValueChanged);
			// 
			// pnlMainGrid
			// 
			this.pnlMainGrid.AutoScroll = true;
			this.pnlMainGrid.Controls.Add(this.thumbGrid);
			this.pnlMainGrid.Controls.Add(this.DaGrid);
			this.pnlMainGrid.Controls.Add(this.pnlNetworkInfo);
			this.pnlMainGrid.Controls.Add(this.pnlSimulationSetup);
			this.pnlMainGrid.Controls.Add(this.pnlRenderSetup);
			this.pnlMainGrid.Controls.Add(this.pnlSignalAssignment);
			this.pnlMainGrid.Controls.Add(this.pnlCanvasSetup);
			this.pnlMainGrid.Controls.Add(this.pnlConnectionSetup);
			this.pnlMainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMainGrid.Location = new System.Drawing.Point(0, 0);
			this.pnlMainGrid.Name = "pnlMainGrid";
			this.pnlMainGrid.Size = new System.Drawing.Size(1090, 651);
			this.pnlMainGrid.TabIndex = 8;
			// 
			// pnlNetworkInfo
			// 
			this.pnlNetworkInfo.AutoScroll = true;
			this.pnlNetworkInfo.Controls.Add(this.SpeichernButton);
			this.pnlNetworkInfo.Controls.Add(this.label7);
			this.pnlNetworkInfo.Controls.Add(this.aboutBoxButton);
			this.pnlNetworkInfo.Controls.Add(this.titleEdit);
			this.pnlNetworkInfo.Controls.Add(this.LadenButton);
			this.pnlNetworkInfo.Controls.Add(this.infoEdit);
			this.pnlNetworkInfo.Location = new System.Drawing.Point(169, 14);
			this.pnlNetworkInfo.Name = "pnlNetworkInfo";
			this.pnlNetworkInfo.Size = new System.Drawing.Size(307, 203);
			this.pnlNetworkInfo.TabIndex = 4;
			this.pnlNetworkInfo.Resize += new System.EventHandler(this.pnlNetworkInfo_Resize);
			// 
			// SpeichernButton
			// 
			this.SpeichernButton.Location = new System.Drawing.Point(190, 148);
			this.SpeichernButton.Name = "SpeichernButton";
			this.SpeichernButton.Size = new System.Drawing.Size(85, 23);
			this.SpeichernButton.TabIndex = 21;
			this.SpeichernButton.Text = "Save Network";
			this.SpeichernButton.UseVisualStyleBackColor = true;
			this.SpeichernButton.Click += new System.EventHandler(this.SpeichernButton_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(0, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Title:";
			// 
			// aboutBoxButton
			// 
			this.aboutBoxButton.Location = new System.Drawing.Point(99, 177);
			this.aboutBoxButton.Name = "aboutBoxButton";
			this.aboutBoxButton.Size = new System.Drawing.Size(176, 23);
			this.aboutBoxButton.TabIndex = 12;
			this.aboutBoxButton.Text = "About CityTrafficSimulator";
			this.aboutBoxButton.UseVisualStyleBackColor = true;
			this.aboutBoxButton.Click += new System.EventHandler(this.aboutBoxButton_Click);
			// 
			// titleEdit
			// 
			this.titleEdit.Location = new System.Drawing.Point(39, 8);
			this.titleEdit.Name = "titleEdit";
			this.titleEdit.Size = new System.Drawing.Size(237, 20);
			this.titleEdit.TabIndex = 1;
			this.titleEdit.TextChanged += new System.EventHandler(this.titleEdit_TextChanged);
			this.titleEdit.Leave += new System.EventHandler(this.titleEdit_Leave);
			// 
			// LadenButton
			// 
			this.LadenButton.Location = new System.Drawing.Point(99, 148);
			this.LadenButton.Name = "LadenButton";
			this.LadenButton.Size = new System.Drawing.Size(85, 23);
			this.LadenButton.TabIndex = 20;
			this.LadenButton.Text = "Load Network";
			this.LadenButton.UseVisualStyleBackColor = true;
			this.LadenButton.Click += new System.EventHandler(this.LadenButton_Click);
			// 
			// infoEdit
			// 
			this.infoEdit.Location = new System.Drawing.Point(3, 34);
			this.infoEdit.Multiline = true;
			this.infoEdit.Name = "infoEdit";
			this.infoEdit.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.infoEdit.Size = new System.Drawing.Size(273, 108);
			this.infoEdit.TabIndex = 0;
			this.infoEdit.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// pnlRenderSetup
			// 
			this.pnlRenderSetup.AutoScroll = true;
			this.pnlRenderSetup.Controls.Add(this.cbRenderFps);
			this.pnlRenderSetup.Controls.Add(this.cbRenderLineChangePoints);
			this.pnlRenderSetup.Controls.Add(this.label2);
			this.pnlRenderSetup.Controls.Add(this.cbRenderIntersections);
			this.pnlRenderSetup.Controls.Add(this.zoomComboBox);
			this.pnlRenderSetup.Controls.Add(this.cbRenderVehiclesDebug);
			this.pnlRenderSetup.Controls.Add(this.cbRenderStatistics);
			this.pnlRenderSetup.Controls.Add(this.cbRenderVehicles);
			this.pnlRenderSetup.Controls.Add(this.renderQualityComboBox);
			this.pnlRenderSetup.Controls.Add(this.cbRenderConnectionsDebug);
			this.pnlRenderSetup.Controls.Add(this.label13);
			this.pnlRenderSetup.Controls.Add(this.cbRenderConnections);
			this.pnlRenderSetup.Controls.Add(this.cbRenderLineNodes);
			this.pnlRenderSetup.Controls.Add(this.cbRenderLineNodesDebug);
			this.pnlRenderSetup.Location = new System.Drawing.Point(482, 223);
			this.pnlRenderSetup.Name = "pnlRenderSetup";
			this.pnlRenderSetup.Size = new System.Drawing.Size(307, 189);
			this.pnlRenderSetup.TabIndex = 4;
			// 
			// cbRenderLineChangePoints
			// 
			this.cbRenderLineChangePoints.AutoSize = true;
			this.cbRenderLineChangePoints.Location = new System.Drawing.Point(120, 163);
			this.cbRenderLineChangePoints.Name = "cbRenderLineChangePoints";
			this.cbRenderLineChangePoints.Size = new System.Drawing.Size(118, 17);
			this.cbRenderLineChangePoints.TabIndex = 22;
			this.cbRenderLineChangePoints.Text = "Line Change Points";
			this.cbRenderLineChangePoints.UseVisualStyleBackColor = true;
			this.cbRenderLineChangePoints.CheckedChanged += new System.EventHandler(this.cbRenderLineChangePoints_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Zoom:";
			// 
			// cbRenderIntersections
			// 
			this.cbRenderIntersections.AutoSize = true;
			this.cbRenderIntersections.Location = new System.Drawing.Point(120, 140);
			this.cbRenderIntersections.Name = "cbRenderIntersections";
			this.cbRenderIntersections.Size = new System.Drawing.Size(86, 17);
			this.cbRenderIntersections.TabIndex = 21;
			this.cbRenderIntersections.Text = "Intersections";
			this.cbRenderIntersections.UseVisualStyleBackColor = true;
			this.cbRenderIntersections.CheckedChanged += new System.EventHandler(this.cbRenderIntersections_CheckedChanged);
			// 
			// zoomComboBox
			// 
			this.zoomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.zoomComboBox.FormattingEnabled = true;
			this.zoomComboBox.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%",
            "25%",
            "33%",
            "50%",
            "67%",
            "100%",
            "150%",
            "200%"});
			this.zoomComboBox.Location = new System.Drawing.Point(111, 6);
			this.zoomComboBox.Name = "zoomComboBox";
			this.zoomComboBox.Size = new System.Drawing.Size(156, 21);
			this.zoomComboBox.TabIndex = 8;
			this.zoomComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomComboBox_SelectedIndexChanged);
			// 
			// cbRenderVehiclesDebug
			// 
			this.cbRenderVehiclesDebug.AutoSize = true;
			this.cbRenderVehiclesDebug.Location = new System.Drawing.Point(120, 117);
			this.cbRenderVehiclesDebug.Name = "cbRenderVehiclesDebug";
			this.cbRenderVehiclesDebug.Size = new System.Drawing.Size(156, 17);
			this.cbRenderVehiclesDebug.TabIndex = 20;
			this.cbRenderVehiclesDebug.Text = "Vehicles Debug Information";
			this.cbRenderVehiclesDebug.UseVisualStyleBackColor = true;
			this.cbRenderVehiclesDebug.CheckedChanged += new System.EventHandler(this.cbRenderVehiclesDebug_CheckedChanged);
			// 
			// cbRenderStatistics
			// 
			this.cbRenderStatistics.AutoSize = true;
			this.cbRenderStatistics.Location = new System.Drawing.Point(6, 140);
			this.cbRenderStatistics.Name = "cbRenderStatistics";
			this.cbRenderStatistics.Size = new System.Drawing.Size(68, 17);
			this.cbRenderStatistics.TabIndex = 12;
			this.cbRenderStatistics.Text = "Statistics";
			this.cbRenderStatistics.UseVisualStyleBackColor = true;
			this.cbRenderStatistics.CheckedChanged += new System.EventHandler(this.visualizationCheckBox_CheckedChanged);
			// 
			// cbRenderVehicles
			// 
			this.cbRenderVehicles.AutoSize = true;
			this.cbRenderVehicles.Checked = true;
			this.cbRenderVehicles.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRenderVehicles.Location = new System.Drawing.Point(6, 117);
			this.cbRenderVehicles.Name = "cbRenderVehicles";
			this.cbRenderVehicles.Size = new System.Drawing.Size(66, 17);
			this.cbRenderVehicles.TabIndex = 19;
			this.cbRenderVehicles.Text = "Vehicles";
			this.cbRenderVehicles.UseVisualStyleBackColor = true;
			this.cbRenderVehicles.CheckedChanged += new System.EventHandler(this.cbRenderVehicles_CheckedChanged);
			// 
			// renderQualityComboBox
			// 
			this.renderQualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.renderQualityComboBox.FormattingEnabled = true;
			this.renderQualityComboBox.Items.AddRange(new object[] {
            "High",
            "Low"});
			this.renderQualityComboBox.Location = new System.Drawing.Point(111, 33);
			this.renderQualityComboBox.Name = "renderQualityComboBox";
			this.renderQualityComboBox.Size = new System.Drawing.Size(156, 21);
			this.renderQualityComboBox.TabIndex = 13;
			// 
			// cbRenderConnectionsDebug
			// 
			this.cbRenderConnectionsDebug.AutoSize = true;
			this.cbRenderConnectionsDebug.Location = new System.Drawing.Point(120, 94);
			this.cbRenderConnectionsDebug.Name = "cbRenderConnectionsDebug";
			this.cbRenderConnectionsDebug.Size = new System.Drawing.Size(141, 17);
			this.cbRenderConnectionsDebug.TabIndex = 18;
			this.cbRenderConnectionsDebug.Text = "Connections Debug Info";
			this.cbRenderConnectionsDebug.UseVisualStyleBackColor = true;
			this.cbRenderConnectionsDebug.CheckedChanged += new System.EventHandler(this.cbRenderConnectionsDebug_CheckedChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 36);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 13);
			this.label13.TabIndex = 14;
			this.label13.Text = "Render Quality:";
			// 
			// cbRenderConnections
			// 
			this.cbRenderConnections.AutoSize = true;
			this.cbRenderConnections.Checked = true;
			this.cbRenderConnections.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRenderConnections.Location = new System.Drawing.Point(6, 94);
			this.cbRenderConnections.Name = "cbRenderConnections";
			this.cbRenderConnections.Size = new System.Drawing.Size(85, 17);
			this.cbRenderConnections.TabIndex = 17;
			this.cbRenderConnections.Text = "Connections";
			this.cbRenderConnections.UseVisualStyleBackColor = true;
			this.cbRenderConnections.CheckedChanged += new System.EventHandler(this.cbRenderConnections_CheckedChanged);
			// 
			// cbRenderLineNodes
			// 
			this.cbRenderLineNodes.AutoSize = true;
			this.cbRenderLineNodes.Checked = true;
			this.cbRenderLineNodes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRenderLineNodes.Location = new System.Drawing.Point(6, 71);
			this.cbRenderLineNodes.Name = "cbRenderLineNodes";
			this.cbRenderLineNodes.Size = new System.Drawing.Size(57, 17);
			this.cbRenderLineNodes.TabIndex = 15;
			this.cbRenderLineNodes.Text = "Nodes";
			this.cbRenderLineNodes.UseVisualStyleBackColor = true;
			this.cbRenderLineNodes.CheckedChanged += new System.EventHandler(this.cbRenderLineNodes_CheckedChanged);
			// 
			// cbRenderLineNodesDebug
			// 
			this.cbRenderLineNodesDebug.AutoSize = true;
			this.cbRenderLineNodesDebug.Location = new System.Drawing.Point(120, 71);
			this.cbRenderLineNodesDebug.Name = "cbRenderLineNodesDebug";
			this.cbRenderLineNodesDebug.Size = new System.Drawing.Size(147, 17);
			this.cbRenderLineNodesDebug.TabIndex = 16;
			this.cbRenderLineNodesDebug.Text = "Nodes Debug Information";
			this.cbRenderLineNodesDebug.UseVisualStyleBackColor = true;
			this.cbRenderLineNodesDebug.CheckedChanged += new System.EventHandler(this.cbRenderLineNodesDebug_CheckedChanged);
			// 
			// pnlSignalAssignment
			// 
			this.pnlSignalAssignment.AutoScroll = true;
			this.pnlSignalAssignment.Controls.Add(this.freeNodeButton);
			this.pnlSignalAssignment.Controls.Add(this.trafficLightTreeView);
			this.pnlSignalAssignment.Location = new System.Drawing.Point(482, 14);
			this.pnlSignalAssignment.Name = "pnlSignalAssignment";
			this.pnlSignalAssignment.Size = new System.Drawing.Size(307, 203);
			this.pnlSignalAssignment.TabIndex = 7;
			this.pnlSignalAssignment.Resize += new System.EventHandler(this.pnlSignalAssignment_Resize);
			// 
			// freeNodeButton
			// 
			this.freeNodeButton.Location = new System.Drawing.Point(179, 162);
			this.freeNodeButton.Name = "freeNodeButton";
			this.freeNodeButton.Size = new System.Drawing.Size(85, 23);
			this.freeNodeButton.TabIndex = 2;
			this.freeNodeButton.Text = "Free Node";
			this.freeNodeButton.UseVisualStyleBackColor = true;
			this.freeNodeButton.Click += new System.EventHandler(this.freeNodeButton_Click);
			// 
			// pnlCanvasSetup
			// 
			this.pnlCanvasSetup.AutoScroll = true;
			this.pnlCanvasSetup.Controls.Add(this.groupBox2);
			this.pnlCanvasSetup.Controls.Add(this.HintergrundbildGroupBox);
			this.pnlCanvasSetup.Location = new System.Drawing.Point(795, 223);
			this.pnlCanvasSetup.Name = "pnlCanvasSetup";
			this.pnlCanvasSetup.Size = new System.Drawing.Size(307, 203);
			this.pnlCanvasSetup.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.canvasHeigthSpinEdit);
			this.groupBox2.Controls.Add(this.canvasWidthSpinEdit);
			this.groupBox2.Controls.Add(this.lockNodesCheckBox);
			this.groupBox2.Location = new System.Drawing.Point(3, 110);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(273, 78);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Network Canvas";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(108, 47);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Height in Pixels:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(107, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Width in Pixels:";
			// 
			// canvasHeigthSpinEdit
			// 
			this.canvasHeigthSpinEdit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.canvasHeigthSpinEdit.Location = new System.Drawing.Point(192, 45);
			this.canvasHeigthSpinEdit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.canvasHeigthSpinEdit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.canvasHeigthSpinEdit.Name = "canvasHeigthSpinEdit";
			this.canvasHeigthSpinEdit.Size = new System.Drawing.Size(75, 20);
			this.canvasHeigthSpinEdit.TabIndex = 1;
			this.canvasHeigthSpinEdit.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.canvasHeigthSpinEdit.ValueChanged += new System.EventHandler(this.canvasHeigthSpinEdit_ValueChanged);
			// 
			// canvasWidthSpinEdit
			// 
			this.canvasWidthSpinEdit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.canvasWidthSpinEdit.Location = new System.Drawing.Point(192, 19);
			this.canvasWidthSpinEdit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.canvasWidthSpinEdit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.canvasWidthSpinEdit.Name = "canvasWidthSpinEdit";
			this.canvasWidthSpinEdit.Size = new System.Drawing.Size(75, 20);
			this.canvasWidthSpinEdit.TabIndex = 0;
			this.canvasWidthSpinEdit.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.canvasWidthSpinEdit.ValueChanged += new System.EventHandler(this.canvasWidthSpinEdit_ValueChanged);
			// 
			// lockNodesCheckBox
			// 
			this.lockNodesCheckBox.AutoSize = true;
			this.lockNodesCheckBox.Location = new System.Drawing.Point(6, 20);
			this.lockNodesCheckBox.Name = "lockNodesCheckBox";
			this.lockNodesCheckBox.Size = new System.Drawing.Size(84, 17);
			this.lockNodesCheckBox.TabIndex = 13;
			this.lockNodesCheckBox.Text = "Lock Nodes";
			this.lockNodesCheckBox.UseVisualStyleBackColor = true;
			// 
			// HintergrundbildGroupBox
			// 
			this.HintergrundbildGroupBox.Controls.Add(this.label8);
			this.HintergrundbildGroupBox.Controls.Add(this.backgroundImageScalingSpinEdit);
			this.HintergrundbildGroupBox.Controls.Add(this.clearBackgroudnImageButton);
			this.HintergrundbildGroupBox.Controls.Add(this.BildLadenButton);
			this.HintergrundbildGroupBox.Controls.Add(this.backgroundImageEdit);
			this.HintergrundbildGroupBox.Location = new System.Drawing.Point(3, 3);
			this.HintergrundbildGroupBox.Name = "HintergrundbildGroupBox";
			this.HintergrundbildGroupBox.Size = new System.Drawing.Size(273, 101);
			this.HintergrundbildGroupBox.TabIndex = 22;
			this.HintergrundbildGroupBox.TabStop = false;
			this.HintergrundbildGroupBox.Text = "Background Image";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(130, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Background Image Zoom:";
			// 
			// backgroundImageScalingSpinEdit
			// 
			this.backgroundImageScalingSpinEdit.Location = new System.Drawing.Point(192, 74);
			this.backgroundImageScalingSpinEdit.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
			this.backgroundImageScalingSpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.backgroundImageScalingSpinEdit.Name = "backgroundImageScalingSpinEdit";
			this.backgroundImageScalingSpinEdit.Size = new System.Drawing.Size(75, 20);
			this.backgroundImageScalingSpinEdit.TabIndex = 3;
			this.backgroundImageScalingSpinEdit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.backgroundImageScalingSpinEdit.ValueChanged += new System.EventHandler(this.backgroundImageScalingSpinEdit_ValueChanged);
			// 
			// clearBackgroudnImageButton
			// 
			this.clearBackgroudnImageButton.Location = new System.Drawing.Point(111, 45);
			this.clearBackgroudnImageButton.Name = "clearBackgroudnImageButton";
			this.clearBackgroudnImageButton.Size = new System.Drawing.Size(75, 23);
			this.clearBackgroudnImageButton.TabIndex = 2;
			this.clearBackgroudnImageButton.Text = "Remove";
			this.clearBackgroudnImageButton.UseVisualStyleBackColor = true;
			this.clearBackgroudnImageButton.Click += new System.EventHandler(this.clearBackgroudnImageButton_Click);
			// 
			// BildLadenButton
			// 
			this.BildLadenButton.Location = new System.Drawing.Point(192, 45);
			this.BildLadenButton.Name = "BildLadenButton";
			this.BildLadenButton.Size = new System.Drawing.Size(75, 23);
			this.BildLadenButton.TabIndex = 1;
			this.BildLadenButton.Text = "Load Image";
			this.BildLadenButton.UseVisualStyleBackColor = true;
			this.BildLadenButton.Click += new System.EventHandler(this.BildLadenButton_Click);
			// 
			// backgroundImageEdit
			// 
			this.backgroundImageEdit.Location = new System.Drawing.Point(6, 19);
			this.backgroundImageEdit.Name = "backgroundImageEdit";
			this.backgroundImageEdit.Size = new System.Drawing.Size(261, 20);
			this.backgroundImageEdit.TabIndex = 0;
			// 
			// pnlConnectionSetup
			// 
			this.pnlConnectionSetup.AutoScroll = true;
			this.pnlConnectionSetup.Controls.Add(this.spinTargetVelocity);
			this.pnlConnectionSetup.Controls.Add(this.label1);
			this.pnlConnectionSetup.Controls.Add(this.enableIncomingLineChangeCheckBox);
			this.pnlConnectionSetup.Controls.Add(this.findLineChangePointsButton);
			this.pnlConnectionSetup.Controls.Add(this.label4);
			this.pnlConnectionSetup.Controls.Add(this.enableOutgoingLineChangeCheckBox);
			this.pnlConnectionSetup.Controls.Add(this.nodeConnectionPrioritySpinEdit);
			this.pnlConnectionSetup.Controls.Add(this.tramAllowedCheckBox);
			this.pnlConnectionSetup.Controls.Add(this.carsAllowedCheckBox);
			this.pnlConnectionSetup.Controls.Add(this.busAllowedCheckBox);
			this.pnlConnectionSetup.Location = new System.Drawing.Point(169, 223);
			this.pnlConnectionSetup.Name = "pnlConnectionSetup";
			this.pnlConnectionSetup.Size = new System.Drawing.Size(307, 189);
			this.pnlConnectionSetup.TabIndex = 6;
			// 
			// spinTargetVelocity
			// 
			this.spinTargetVelocity.Location = new System.Drawing.Point(188, 33);
			this.spinTargetVelocity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.spinTargetVelocity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.spinTargetVelocity.Name = "spinTargetVelocity";
			this.spinTargetVelocity.Size = new System.Drawing.Size(88, 20);
			this.spinTargetVelocity.TabIndex = 8;
			this.spinTargetVelocity.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
			this.spinTargetVelocity.ValueChanged += new System.EventHandler(this.spinTargetVelocity_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Target Velocity (m/s):";
			// 
			// enableIncomingLineChangeCheckBox
			// 
			this.enableIncomingLineChangeCheckBox.AutoSize = true;
			this.enableIncomingLineChangeCheckBox.Checked = true;
			this.enableIncomingLineChangeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableIncomingLineChangeCheckBox.Location = new System.Drawing.Point(6, 94);
			this.enableIncomingLineChangeCheckBox.Name = "enableIncomingLineChangeCheckBox";
			this.enableIncomingLineChangeCheckBox.Size = new System.Drawing.Size(160, 17);
			this.enableIncomingLineChangeCheckBox.TabIndex = 6;
			this.enableIncomingLineChangeCheckBox.Text = "Allow Incoming Line Change";
			this.enableIncomingLineChangeCheckBox.UseVisualStyleBackColor = true;
			this.enableIncomingLineChangeCheckBox.Click += new System.EventHandler(this.enableIncomingLineChangeCheckBox_Click);
			// 
			// findLineChangePointsButton
			// 
			this.findLineChangePointsButton.Location = new System.Drawing.Point(6, 113);
			this.findLineChangePointsButton.Name = "findLineChangePointsButton";
			this.findLineChangePointsButton.Size = new System.Drawing.Size(160, 23);
			this.findLineChangePointsButton.TabIndex = 22;
			this.findLineChangePointsButton.Text = "Recalculate Line Changes";
			this.findLineChangePointsButton.UseVisualStyleBackColor = true;
			this.findLineChangePointsButton.Click += new System.EventHandler(this.findLineChangePointsButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Connection Priority:";
			// 
			// enableOutgoingLineChangeCheckBox
			// 
			this.enableOutgoingLineChangeCheckBox.AutoSize = true;
			this.enableOutgoingLineChangeCheckBox.Checked = true;
			this.enableOutgoingLineChangeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableOutgoingLineChangeCheckBox.Location = new System.Drawing.Point(6, 71);
			this.enableOutgoingLineChangeCheckBox.Name = "enableOutgoingLineChangeCheckBox";
			this.enableOutgoingLineChangeCheckBox.Size = new System.Drawing.Size(160, 17);
			this.enableOutgoingLineChangeCheckBox.TabIndex = 5;
			this.enableOutgoingLineChangeCheckBox.Text = "Allow Outgoing Line Change";
			this.enableOutgoingLineChangeCheckBox.UseVisualStyleBackColor = true;
			this.enableOutgoingLineChangeCheckBox.Click += new System.EventHandler(this.enableOutgoingLineChangeCheckBox_Click);
			// 
			// nodeConnectionPrioritySpinEdit
			// 
			this.nodeConnectionPrioritySpinEdit.Location = new System.Drawing.Point(188, 7);
			this.nodeConnectionPrioritySpinEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nodeConnectionPrioritySpinEdit.Name = "nodeConnectionPrioritySpinEdit";
			this.nodeConnectionPrioritySpinEdit.Size = new System.Drawing.Size(88, 20);
			this.nodeConnectionPrioritySpinEdit.TabIndex = 0;
			this.nodeConnectionPrioritySpinEdit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nodeConnectionPrioritySpinEdit.ValueChanged += new System.EventHandler(this.nodeConnectionPrioritySpinEdit_ValueChanged);
			// 
			// tramAllowedCheckBox
			// 
			this.tramAllowedCheckBox.AutoSize = true;
			this.tramAllowedCheckBox.Location = new System.Drawing.Point(188, 117);
			this.tramAllowedCheckBox.Name = "tramAllowedCheckBox";
			this.tramAllowedCheckBox.Size = new System.Drawing.Size(83, 17);
			this.tramAllowedCheckBox.TabIndex = 4;
			this.tramAllowedCheckBox.Text = "Allow Trams";
			this.tramAllowedCheckBox.UseVisualStyleBackColor = true;
			this.tramAllowedCheckBox.CheckedChanged += new System.EventHandler(this.tramAllowedCheckBox_CheckedChanged);
			// 
			// carsAllowedCheckBox
			// 
			this.carsAllowedCheckBox.AutoSize = true;
			this.carsAllowedCheckBox.Checked = true;
			this.carsAllowedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.carsAllowedCheckBox.Location = new System.Drawing.Point(188, 71);
			this.carsAllowedCheckBox.Name = "carsAllowedCheckBox";
			this.carsAllowedCheckBox.Size = new System.Drawing.Size(75, 17);
			this.carsAllowedCheckBox.TabIndex = 2;
			this.carsAllowedCheckBox.Text = "Allow Cars";
			this.carsAllowedCheckBox.UseVisualStyleBackColor = true;
			this.carsAllowedCheckBox.CheckedChanged += new System.EventHandler(this.carsAllowedCheckBox_CheckedChanged);
			// 
			// busAllowedCheckBox
			// 
			this.busAllowedCheckBox.AutoSize = true;
			this.busAllowedCheckBox.Location = new System.Drawing.Point(188, 94);
			this.busAllowedCheckBox.Name = "busAllowedCheckBox";
			this.busAllowedCheckBox.Size = new System.Drawing.Size(88, 17);
			this.busAllowedCheckBox.TabIndex = 3;
			this.busAllowedCheckBox.Text = "Allow Busses";
			this.busAllowedCheckBox.UseVisualStyleBackColor = true;
			this.busAllowedCheckBox.CheckedChanged += new System.EventHandler(this.busAllowedCheckBox_CheckedChanged);
			// 
			// statusleiste
			// 
			this.statusleiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenu,
            this.statusLabel});
			this.statusleiste.Location = new System.Drawing.Point(0, 629);
			this.statusleiste.Name = "statusleiste";
			this.statusleiste.Size = new System.Drawing.Size(1090, 22);
			this.statusleiste.TabIndex = 8;
			this.statusleiste.Text = "statusStrip1";
			// 
			// statusMenu
			// 
			this.statusMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.statusMenu.Image = ((System.Drawing.Image)(resources.GetObject("statusMenu.Image")));
			this.statusMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.statusMenu.Name = "statusMenu";
			this.statusMenu.Size = new System.Drawing.Size(29, 20);
			this.statusMenu.Text = "toolStripDropDownButton1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(195, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "Speichern";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(114, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 20;
			this.button2.Text = "Laden";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// thumbGrid
			// 
			this.thumbGrid.BackColor = System.Drawing.Color.White;
			this.thumbGrid.CellHeight = 0;
			this.thumbGrid.CellSize = new System.Drawing.Size(0, 0);
			this.thumbGrid.CellWidth = 0;
			this.thumbGrid.Dimension = new System.Drawing.Point(0, 0);
			this.thumbGrid.DrawGrid = false;
			this.thumbGrid.Location = new System.Drawing.Point(626, 418);
			this.thumbGrid.Max_X = 0;
			this.thumbGrid.Max_Y = 0;
			this.thumbGrid.Name = "thumbGrid";
			this.thumbGrid.Size = new System.Drawing.Size(139, 127);
			this.thumbGrid.TabIndex = 15;
			this.thumbGrid.MouseLeave += new System.EventHandler(this.thumbGrid_MouseLeave);
			this.thumbGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.thumbGrid_Paint);
			this.thumbGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.thumbGrid_MouseMove);
			this.thumbGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.thumbGrid_MouseDown);
			this.thumbGrid.Resize += new System.EventHandler(this.thumbGrid_Resize);
			this.thumbGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.thumbGrid_MouseUp);
			// 
			// DaGrid
			// 
			this.DaGrid.AllowDrop = true;
			this.DaGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DaGrid.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.DaGrid.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.DaGrid.CellHeight = 16;
			this.DaGrid.CellSize = new System.Drawing.Size(16, 16);
			this.DaGrid.CellWidth = 16;
			this.DaGrid.Dimension = new System.Drawing.Point(64, 64);
			this.DaGrid.DrawGrid = false;
			this.DaGrid.Location = new System.Drawing.Point(0, 0);
			this.DaGrid.Max_X = 64;
			this.DaGrid.Max_Y = 64;
			this.DaGrid.Name = "DaGrid";
			this.DaGrid.Size = new System.Drawing.Size(100, 100);
			this.DaGrid.TabIndex = 3;
			this.DaGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.DaGrid_Paint);
			this.DaGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DaGrid_MouseMove);
			this.DaGrid.Leave += new System.EventHandler(this.DaGrid_Leave);
			this.DaGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DaGrid_MouseDown);
			this.DaGrid.Enter += new System.EventHandler(this.DaGrid_Enter);
			this.DaGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DaGrid_MouseUp);
			this.DaGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DaGrid_KeyDown);
			// 
			// trafficLightTreeView
			// 
			this.trafficLightTreeView.Location = new System.Drawing.Point(3, 3);
			this.trafficLightTreeView.Name = "trafficLightTreeView";
			this.trafficLightTreeView.Size = new System.Drawing.Size(261, 127);
			this.trafficLightTreeView.steuerung = null;
			this.trafficLightTreeView.TabIndex = 1;
			this.trafficLightTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trafficLightTreeView_AfterSelect);
			// 
			// cbRenderFps
			// 
			this.cbRenderFps.AutoSize = true;
			this.cbRenderFps.Location = new System.Drawing.Point(6, 163);
			this.cbRenderFps.Name = "cbRenderFps";
			this.cbRenderFps.Size = new System.Drawing.Size(105, 17);
			this.cbRenderFps.TabIndex = 23;
			this.cbRenderFps.Text = "Performance/fps";
			this.cbRenderFps.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1090, 651);
			this.Controls.Add(this.statusleiste);
			this.Controls.Add(this.pnlMainGrid);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "CityTrafficSimulator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.pnlSimulationSetup.ResumeLayout(false);
			this.pnlSimulationSetup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.stepsPerSecondSpinEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.simulationSpeedSpinEdit)).EndInit();
			this.pnlMainGrid.ResumeLayout(false);
			this.pnlNetworkInfo.ResumeLayout(false);
			this.pnlNetworkInfo.PerformLayout();
			this.pnlRenderSetup.ResumeLayout(false);
			this.pnlRenderSetup.PerformLayout();
			this.pnlSignalAssignment.ResumeLayout(false);
			this.pnlCanvasSetup.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvasHeigthSpinEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.canvasWidthSpinEdit)).EndInit();
			this.HintergrundbildGroupBox.ResumeLayout(false);
			this.HintergrundbildGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.backgroundImageScalingSpinEdit)).EndInit();
			this.pnlConnectionSetup.ResumeLayout(false);
			this.pnlConnectionSetup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinTargetVelocity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nodeConnectionPrioritySpinEdit)).EndInit();
			this.statusleiste.ResumeLayout(false);
			this.statusleiste.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

            }

        #endregion

		private System.Windows.Forms.Timer timer1;
		private RechenkaestchenControl DaGrid;
        private System.Windows.Forms.GroupBox HintergrundbildGroupBox;
        private System.Windows.Forms.Button BildLadenButton;
		private System.Windows.Forms.TextBox backgroundImageEdit;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SpeichernButton;
		private System.Windows.Forms.Button LadenButton;
		private System.Windows.Forms.CheckBox timerOnCheckBox;
		private System.Windows.Forms.StatusStrip statusleiste;
		private System.Windows.Forms.ToolStripDropDownButton statusMenu;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nodeConnectionPrioritySpinEdit;
		private System.Windows.Forms.Button stepButton;
		private System.Windows.Forms.Button killAllVehiclesButton;
		private System.Windows.Forms.ComboBox zoomComboBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button clearBackgroudnImageButton;
		private System.Windows.Forms.TextBox infoEdit;
		private System.Windows.Forms.Button aboutBoxButton;
		private System.Windows.Forms.CheckBox lockNodesCheckBox;
		private System.Windows.Forms.CheckBox busAllowedCheckBox;
		private System.Windows.Forms.CheckBox carsAllowedCheckBox;
		private System.Windows.Forms.CheckBox tramAllowedCheckBox;
		private System.Windows.Forms.CheckBox cbRenderStatistics;
		private System.Windows.Forms.Button findLineChangePointsButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox titleEdit;
		private System.Windows.Forms.CheckBox enableOutgoingLineChangeCheckBox;
		private System.Windows.Forms.CheckBox enableIncomingLineChangeCheckBox;
		private CityTrafficSimulator.Timeline.TrafficLightTreeView trafficLightTreeView;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown backgroundImageScalingSpinEdit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown canvasHeigthSpinEdit;
		private System.Windows.Forms.NumericUpDown canvasWidthSpinEdit;
		private System.Windows.Forms.NumericUpDown simulationSpeedSpinEdit;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown stepsPerSecondSpinEdit;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox renderQualityComboBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button freeNodeButton;
		private System.Windows.Forms.CheckBox cbRenderVehiclesDebug;
		private System.Windows.Forms.CheckBox cbRenderVehicles;
		private System.Windows.Forms.CheckBox cbRenderConnectionsDebug;
		private System.Windows.Forms.CheckBox cbRenderConnections;
		private System.Windows.Forms.CheckBox cbRenderLineNodesDebug;
		private System.Windows.Forms.CheckBox cbRenderLineNodes;
		private System.Windows.Forms.CheckBox cbRenderLineChangePoints;
		private System.Windows.Forms.CheckBox cbRenderIntersections;
		private System.Windows.Forms.Panel pnlRenderSetup;
		private System.Windows.Forms.Panel pnlConnectionSetup;
		private System.Windows.Forms.Panel pnlCanvasSetup;
		private System.Windows.Forms.Panel pnlSignalAssignment;
		private System.Windows.Forms.Panel pnlNetworkInfo;
		private System.Windows.Forms.NumericUpDown spinTargetVelocity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlMainGrid;
		private System.Windows.Forms.Panel pnlSimulationSetup;
		private RechenkaestchenControl thumbGrid;
		private System.Windows.Forms.CheckBox cbRenderFps;

        }
    }

