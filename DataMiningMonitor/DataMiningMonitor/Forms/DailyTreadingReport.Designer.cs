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
            DailyReportGridView = new DataGridView();
            dateResult = new Label();
            pidResult = new Label();
            status = new Label();
            ((System.ComponentModel.ISupportInitialize)DailyReportGridView).BeginInit();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(30, 25);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(34, 15);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "日期:";
            // 
            // SelectedTime
            // 
            SelectedTime.CustomFormat = "yyyy-MM-dd";
            SelectedTime.Format = DateTimePickerFormat.Custom;
            SelectedTime.Location = new Point(70, 22);
            SelectedTime.Name = "SelectedTime";
            SelectedTime.Size = new Size(200, 23);
            SelectedTime.TabIndex = 1;
            // 
            // PidLabel
            // 
            PidLabel.AutoSize = true;
            PidLabel.Location = new Point(291, 25);
            PidLabel.Name = "PidLabel";
            PidLabel.Size = new Size(34, 15);
            PidLabel.TabIndex = 2;
            PidLabel.Text = "代碼:";
            // 
            // InputPid
            // 
            InputPid.Location = new Point(331, 22);
            InputPid.Name = "InputPid";
            InputPid.Size = new Size(100, 23);
            InputPid.TabIndex = 3;
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(457, 22);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(75, 23);
            SelectBtn.TabIndex = 5;
            SelectBtn.Text = "查詢";
            SelectBtn.UseVisualStyleBackColor = true;
            SelectBtn.Click += GetDailyReport;
            SelectBtn.Enter += GetDailyReport;
            // 
            // DailyReportGridView
            // 
            DailyReportGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DailyReportGridView.Location = new Point(30, 100);
            DailyReportGridView.Name = "DailyReportGridView";
            DailyReportGridView.ReadOnly = true;
            DailyReportGridView.Size = new Size(734, 335);
            DailyReportGridView.TabIndex = 6;
            // 
            // dateResult
            // 
            dateResult.AutoSize = true;
            dateResult.Location = new Point(30, 77);
            dateResult.Name = "dateResult";
            dateResult.Size = new Size(0, 15);
            dateResult.TabIndex = 7;
            // 
            // pidResult
            // 
            pidResult.AutoSize = true;
            pidResult.Location = new Point(152, 77);
            pidResult.Name = "pidResult";
            pidResult.Size = new Size(0, 15);
            pidResult.TabIndex = 8;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(30, 54);
            status.Name = "status";
            status.Size = new Size(0, 15);
            status.TabIndex = 9;
            // 
            // DailyTreadingReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(status);
            Controls.Add(pidResult);
            Controls.Add(dateResult);
            Controls.Add(DailyReportGridView);
            Controls.Add(SelectBtn);
            Controls.Add(InputPid);
            Controls.Add(PidLabel);
            Controls.Add(SelectedTime);
            Controls.Add(DateLabel);
            Name = "DailyTreadingReport";
            Text = "買賣日報表";
            ((System.ComponentModel.ISupportInitialize)DailyReportGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateLabel;
        private DateTimePicker SelectedTime;
        private Label PidLabel;
        private TextBox InputPid;
        private Button SelectBtn;
        private DataGridView DailyReportGridView;
        private Label dateResult;
        private Label pidResult;
        private Label status;
    }
}