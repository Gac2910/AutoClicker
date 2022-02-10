namespace AutoClicker
{
    partial class AutoClickerApp
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.IntervalBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ClickButtonComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClickLimitBox = new System.Windows.Forms.NumericUpDown();
            this.RepeatUntilStopRadio = new System.Windows.Forms.RadioButton();
            this.RepeatUntilLimitRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClickLimitBox)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Location = new System.Drawing.Point(8, 9);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(152, 70);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.TabStop = false;
            this.BtnStart.Text = "Start (F6)";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // IntervalBox
            // 
            this.IntervalBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IntervalBox.Location = new System.Drawing.Point(8, 43);
            this.IntervalBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.IntervalBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IntervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(320, 35);
            this.IntervalBox.TabIndex = 4;
            this.IntervalBox.TabStop = false;
            this.IntervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntervalBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Interval (milliseconds)";
            // 
            // CounterLabel
            // 
            this.CounterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(351, 11);
            this.CounterLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(26, 29);
            this.CounterLabel.TabIndex = 9;
            this.CounterLabel.Text = "0";
            this.CounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number Of Clicks:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 335);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 95);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.IntervalBox, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.44068F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.55932F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(336, 89);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // ClickButtonComboBox
            // 
            this.ClickButtonComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClickButtonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClickButtonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickButtonComboBox.FormattingEnabled = true;
            this.ClickButtonComboBox.Items.AddRange(new object[] {
            "Left Click",
            "Right Click"});
            this.ClickButtonComboBox.Location = new System.Drawing.Point(352, 59);
            this.ClickButtonComboBox.Name = "ClickButtonComboBox";
            this.ClickButtonComboBox.Size = new System.Drawing.Size(326, 37);
            this.ClickButtonComboBox.TabIndex = 0;
            this.ClickButtonComboBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mouse Button:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickLimitBox
            // 
            this.ClickLimitBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClickLimitBox.Location = new System.Drawing.Point(263, 71);
            this.ClickLimitBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ClickLimitBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ClickLimitBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ClickLimitBox.Name = "ClickLimitBox";
            this.ClickLimitBox.Size = new System.Drawing.Size(280, 35);
            this.ClickLimitBox.TabIndex = 5;
            this.ClickLimitBox.TabStop = false;
            this.ClickLimitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClickLimitBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RepeatUntilStopRadio
            // 
            this.RepeatUntilStopRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepeatUntilStopRadio.AutoSize = true;
            this.RepeatUntilStopRadio.Checked = true;
            this.RepeatUntilStopRadio.Location = new System.Drawing.Point(18, 13);
            this.RepeatUntilStopRadio.Name = "RepeatUntilStopRadio";
            this.RepeatUntilStopRadio.Size = new System.Drawing.Size(219, 33);
            this.RepeatUntilStopRadio.TabIndex = 6;
            this.RepeatUntilStopRadio.TabStop = true;
            this.RepeatUntilStopRadio.Text = "Repeat Until Stop";
            this.RepeatUntilStopRadio.UseVisualStyleBackColor = true;
            // 
            // RepeatUntilLimitRadio
            // 
            this.RepeatUntilLimitRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepeatUntilLimitRadio.AutoSize = true;
            this.RepeatUntilLimitRadio.Location = new System.Drawing.Point(46, 72);
            this.RepeatUntilLimitRadio.Name = "RepeatUntilLimitRadio";
            this.RepeatUntilLimitRadio.Size = new System.Drawing.Size(163, 33);
            this.RepeatUntilLimitRadio.TabIndex = 7;
            this.RepeatUntilLimitRadio.Text = "Repeat Until";
            this.RepeatUntilLimitRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clicks";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.21212F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.78788F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.RepeatUntilStopRadio, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.RepeatUntilLimitRadio, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.ClickLimitBox, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(12, 122);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(687, 119);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClickButtonComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CounterLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 104);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BtnClose, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnStart, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(345, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(337, 89);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClose.BackColor = System.Drawing.Color.SlateGray;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(176, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(152, 70);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AutoClickerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 443);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AutoClickerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker App";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AutoClickerApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IntervalBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClickLimitBox)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.NumericUpDown IntervalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox ClickButtonComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RepeatUntilLimitRadio;
        private System.Windows.Forms.RadioButton RepeatUntilStopRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ClickLimitBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnClose;
    }
}

