namespace Auto
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonPosition = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.numericUpDownClicks = new System.Windows.Forms.NumericUpDown();
            this.trackBarClicks = new System.Windows.Forms.TrackBar();
            this.labelClicks = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.trackBarInterval = new System.Windows.Forms.TrackBar();
            this.labelInterval = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelClickCount = new System.Windows.Forms.Label();
            this.labelClicksRemaining = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPosition
            // 
            this.buttonPosition.Location = new System.Drawing.Point(12, 12);
            this.buttonPosition.Name = "buttonPosition";
            this.buttonPosition.Size = new System.Drawing.Size(150, 30);
            this.buttonPosition.TabIndex = 0;
            this.buttonPosition.Text = "Выбрать позицию";
            this.buttonPosition.UseVisualStyleBackColor = true;
            this.buttonPosition.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(168, 19);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(51, 13);
            this.labelPosition.TabIndex = 1;
            this.labelPosition.Text = "X: 0, Y: 0";
            // 
            // numericUpDownClicks
            // 
            this.numericUpDownClicks.Location = new System.Drawing.Point(12, 60);
            this.numericUpDownClicks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownClicks.Name = "numericUpDownClicks";
            this.numericUpDownClicks.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownClicks.TabIndex = 2;
            this.numericUpDownClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // trackBarClicks
            // 
            this.trackBarClicks.Location = new System.Drawing.Point(98, 60);
            this.trackBarClicks.Maximum = 1000;
            this.trackBarClicks.Minimum = 1;
            this.trackBarClicks.Name = "trackBarClicks";
            this.trackBarClicks.Size = new System.Drawing.Size(200, 45);
            this.trackBarClicks.TabIndex = 3;
            this.trackBarClicks.Value = 1;
            // 
            // labelClicks
            // 
            this.labelClicks.AutoSize = true;
            this.labelClicks.Location = new System.Drawing.Point(12, 44);
            this.labelClicks.Name = "labelClicks";
            this.labelClicks.Size = new System.Drawing.Size(105, 13);
            this.labelClicks.TabIndex = 4;
            this.labelClicks.Text = "Количество кликов";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(12, 110);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownInterval.TabIndex = 5;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // trackBarInterval
            // 
            this.trackBarInterval.Location = new System.Drawing.Point(98, 110);
            this.trackBarInterval.Maximum = 1000;
            this.trackBarInterval.Minimum = 1;
            this.trackBarInterval.Name = "trackBarInterval";
            this.trackBarInterval.Size = new System.Drawing.Size(200, 45);
            this.trackBarInterval.TabIndex = 6;
            this.trackBarInterval.Value = 100;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(12, 94);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(79, 13);
            this.labelInterval.TabIndex = 7;
            this.labelInterval.Text = "Интервал (мс)";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 160);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(150, 30);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelClickCount
            // 
            this.labelClickCount.AutoSize = true;
            this.labelClickCount.Location = new System.Drawing.Point(12, 200);
            this.labelClickCount.Name = "labelClickCount";
            this.labelClickCount.Size = new System.Drawing.Size(56, 13);
            this.labelClickCount.TabIndex = 9;
            this.labelClickCount.Text = "Кликов: 0";
            // 
            // labelClicksRemaining
            // 
            this.labelClicksRemaining.AutoSize = true;
            this.labelClicksRemaining.Location = new System.Drawing.Point(12, 220);
            this.labelClicksRemaining.Name = "labelClicksRemaining";
            this.labelClicksRemaining.Size = new System.Drawing.Size(68, 13);
            this.labelClicksRemaining.TabIndex = 10;
            this.labelClicksRemaining.Text = "Осталось: 0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 240);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 23);
            this.progressBar.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 280);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelClicksRemaining);
            this.Controls.Add(this.labelClickCount);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.trackBarInterval);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.labelClicks);
            this.Controls.Add(this.trackBarClicks);
            this.Controls.Add(this.numericUpDownClicks);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.buttonPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автокликер";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.NumericUpDown numericUpDownClicks;
        private System.Windows.Forms.TrackBar trackBarClicks;
        private System.Windows.Forms.Label labelClicks;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.TrackBar trackBarInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelClickCount;
        private System.Windows.Forms.Label labelClicksRemaining;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}