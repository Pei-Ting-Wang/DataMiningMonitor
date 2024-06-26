namespace DataMiningMonitor
{
    partial class UnrealizedPnLForm
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
            Date = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            Pips = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(27, 38);
            Date.Name = "Date";
            Date.Size = new Size(54, 19);
            Date.TabIndex = 0;
            Date.Text = "日期：";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(87, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Value = new DateTime(2024, 6, 23, 21, 25, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 2;
            label1.Text = "分點：";
            // 
            // Pips
            // 
            Pips.Location = new Point(413, 30);
            Pips.Name = "Pips";
            Pips.Size = new Size(125, 27);
            Pips.TabIndex = 3;
            // 
            // submit
            // 
            submit.Location = new Point(581, 28);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 4;
            submit.Text = "查詢";
            submit.UseVisualStyleBackColor = true;
            // 
            // UnrealizedPnLForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(Pips);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Date);
            Name = "UnrealizedPnLForm";
            Text = "權證未實現損益";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Date;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox Pips;
        private Button submit;
    }
}