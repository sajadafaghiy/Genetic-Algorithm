namespace GeneticAlgorithm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRun = new System.Windows.Forms.Button();
            this.TbxOutput = new System.Windows.Forms.TextBox();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.nudMutation = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCrossover = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudItrations = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPopulation = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulation)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Indigo;
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.Logo);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1000, 66);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::GeneticAlgorithm.Properties.Resources.Close;
            this.CloseButton.Location = new System.Drawing.Point(957, 18);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::GeneticAlgorithm.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(13, 8);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(50, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.DoubleClick += new System.EventHandler(this.Logo_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GA | Genetic Algorithm";
            // 
            // BtnRun
            // 
            this.BtnRun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRun.FlatAppearance.BorderSize = 0;
            this.BtnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.BtnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRun.Location = new System.Drawing.Point(624, 430);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(100, 35);
            this.BtnRun.TabIndex = 2;
            this.BtnRun.Text = "Start";
            this.BtnRun.UseVisualStyleBackColor = false;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // TbxOutput
            // 
            this.TbxOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxOutput.Location = new System.Drawing.Point(362, 73);
            this.TbxOutput.Multiline = true;
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.ReadOnly = true;
            this.TbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxOutput.Size = new System.Drawing.Size(625, 300);
            this.TbxOutput.TabIndex = 3;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.SettingsGroupBox.Controls.Add(this.nudMutation);
            this.SettingsGroupBox.Controls.Add(this.label11);
            this.SettingsGroupBox.Controls.Add(this.label8);
            this.SettingsGroupBox.Controls.Add(this.nudCrossover);
            this.SettingsGroupBox.Controls.Add(this.label9);
            this.SettingsGroupBox.Controls.Add(this.label6);
            this.SettingsGroupBox.Controls.Add(this.nudItrations);
            this.SettingsGroupBox.Controls.Add(this.label7);
            this.SettingsGroupBox.Controls.Add(this.label5);
            this.SettingsGroupBox.Controls.Add(this.nudPopulation);
            this.SettingsGroupBox.Controls.Add(this.label3);
            this.SettingsGroupBox.Location = new System.Drawing.Point(13, 73);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(319, 415);
            this.SettingsGroupBox.TabIndex = 4;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // nudMutation
            // 
            this.nudMutation.BackColor = System.Drawing.Color.LightGray;
            this.nudMutation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMutation.DecimalPlaces = 2;
            this.nudMutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMutation.Location = new System.Drawing.Point(193, 185);
            this.nudMutation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMutation.Name = "nudMutation";
            this.nudMutation.Size = new System.Drawing.Size(120, 24);
            this.nudMutation.TabIndex = 15;
            this.nudMutation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMutation.ThousandsSeparator = true;
            this.nudMutation.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Mutation (%):";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(34, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 2);
            this.label8.TabIndex = 12;
            // 
            // nudCrossover
            // 
            this.nudCrossover.BackColor = System.Drawing.Color.LightGray;
            this.nudCrossover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCrossover.DecimalPlaces = 2;
            this.nudCrossover.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCrossover.Location = new System.Drawing.Point(193, 135);
            this.nudCrossover.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCrossover.Name = "nudCrossover";
            this.nudCrossover.Size = new System.Drawing.Size(120, 24);
            this.nudCrossover.TabIndex = 11;
            this.nudCrossover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCrossover.ThousandsSeparator = true;
            this.nudCrossover.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Crossover (%):";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(34, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 2);
            this.label6.TabIndex = 8;
            // 
            // nudItrations
            // 
            this.nudItrations.BackColor = System.Drawing.Color.LightGray;
            this.nudItrations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudItrations.Location = new System.Drawing.Point(193, 85);
            this.nudItrations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudItrations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItrations.Name = "nudItrations";
            this.nudItrations.Size = new System.Drawing.Size(120, 24);
            this.nudItrations.TabIndex = 7;
            this.nudItrations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudItrations.ThousandsSeparator = true;
            this.nudItrations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Itrations:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(34, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 2);
            this.label5.TabIndex = 5;
            // 
            // nudPopulation
            // 
            this.nudPopulation.BackColor = System.Drawing.Color.LightGray;
            this.nudPopulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPopulation.Location = new System.Drawing.Point(193, 35);
            this.nudPopulation.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPopulation.Name = "nudPopulation";
            this.nudPopulation.Size = new System.Drawing.Size(120, 24);
            this.nudPopulation.TabIndex = 1;
            this.nudPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPopulation.ThousandsSeparator = true;
            this.nudPopulation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Population:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Indigo;
            this.label12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label12.Location = new System.Drawing.Point(0, 495);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1000, 5);
            this.label12.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Indigo;
            this.label16.Dock = System.Windows.Forms.DockStyle.Right;
            this.label16.Location = new System.Drawing.Point(995, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(5, 429);
            this.label16.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Indigo;
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Location = new System.Drawing.Point(0, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(5, 429);
            this.label17.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click Start to Run GA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sajad Afaghiy";
            // 
            // Main
            // 
            this.AcceptButton = this.BtnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.TbxOutput);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GA";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.TextBox TbxOutput;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.NumericUpDown nudPopulation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudItrations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCrossover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMutation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

