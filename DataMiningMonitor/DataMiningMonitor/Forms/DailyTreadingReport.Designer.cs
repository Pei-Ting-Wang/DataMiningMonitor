namespace DataMiningMonitor.Forms
{
    partial class DailyTreadingReport
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
            DateLabel = new Label();
            SelectedTime = new DateTimePicker();
            PidLabel = new Label();
            InputPid = new TextBox();
            SelectBtn = new Button();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(42, 47);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(34, 15);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "日期:";
            // 
            // SelectedTime
            // 
            SelectedTime.CustomFormat = "yyyy-MM-dd";
            SelectedTime.Format = DateTimePickerFormat.Custom;
            SelectedTime.Location = new Point(82, 44);
            SelectedTime.Name = "SelectedTime";
            SelectedTime.Size = new Size(200, 23);
            SelectedTime.TabIndex = 1;
            // 
            // PidLabel
            // 
            PidLabel.AutoSize = true;
            PidLabel.Location = new Point(303, 47);
            PidLabel.Name = "PidLabel";
            PidLabel.Size = new Size(34, 15);
            PidLabel.TabIndex = 2;
            PidLabel.Text = "代碼:";
            // 
            // InputPid
            // 
            InputPid.Location = new Point(343, 44);
            InputPid.Name = "InputPid";
            InputPid.Size = new Size(100, 23);
            InputPid.TabIndex = 3;
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(482, 44);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(75, 23);
            SelectBtn.TabIndex = 5;
            SelectBtn.Text = "查詢";
            SelectBtn.UseVisualStyleBackColor = true;
            SelectBtn.Click += GetDailyReport;
            // 
            // DailyTreadingReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectBtn);
            Controls.Add(InputPid);
            Controls.Add(PidLabel);
            Controls.Add(SelectedTime);
            Controls.Add(DateLabel);
            Name = "DailyTreadingReport";
            Text = "DailyTreadingReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateLabel;
        private DateTimePicker SelectedTime;
        private Label PidLabel;
        private TextBox InputPid;
        private Button SelectBtn;
    }
}