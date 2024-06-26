using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataMiningMonitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            stockToolStripMenuItem = new ToolStripMenuItem();
            warrantToolStripMenuItem = new ToolStripMenuItem();
            marketMakingToolStripMenuItem = new ToolStripMenuItem();
            hitRateQueryToolStripMenuItem = new ToolStripMenuItem();
            realTimeProfitAndLossToolStripMenuItem = new ToolStripMenuItem();
            warrantToolsToolStripMenuItem = new ToolStripMenuItem();
            unrealizedProfitAndLossToolStripMenuItem = new ToolStripMenuItem();
            tradingDailyReportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stockToolStripMenuItem, warrantToolStripMenuItem, tradingDailyReportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(53, 24);
            stockToolStripMenuItem.Text = "現股";
            // 
            // warrantToolStripMenuItem
            // 
            warrantToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { marketMakingToolStripMenuItem, hitRateQueryToolStripMenuItem, realTimeProfitAndLossToolStripMenuItem, warrantToolsToolStripMenuItem, unrealizedProfitAndLossToolStripMenuItem });
            warrantToolStripMenuItem.Name = "warrantToolStripMenuItem";
            warrantToolStripMenuItem.Size = new Size(53, 24);
            warrantToolStripMenuItem.Text = "權證";
            // 
            // marketMakingToolStripMenuItem
            // 
            marketMakingToolStripMenuItem.Name = "marketMakingToolStripMenuItem";
            marketMakingToolStripMenuItem.Size = new Size(224, 26);
            marketMakingToolStripMenuItem.Text = "劵商造市";
            // 
            // hitRateQueryToolStripMenuItem
            // 
            hitRateQueryToolStripMenuItem.Name = "hitRateQueryToolStripMenuItem";
            hitRateQueryToolStripMenuItem.Size = new Size(224, 26);
            hitRateQueryToolStripMenuItem.Text = "命中率查詢";
            // 
            // realTimeProfitAndLossToolStripMenuItem
            // 
            realTimeProfitAndLossToolStripMenuItem.Name = "realTimeProfitAndLossToolStripMenuItem";
            realTimeProfitAndLossToolStripMenuItem.Size = new Size(224, 26);
            realTimeProfitAndLossToolStripMenuItem.Text = "即使損益";
            // 
            // warrantToolsToolStripMenuItem
            // 
            warrantToolsToolStripMenuItem.Name = "warrantToolsToolStripMenuItem";
            warrantToolsToolStripMenuItem.Size = new Size(224, 26);
            warrantToolsToolStripMenuItem.Text = "權證工具";
            // 
            // unrealizedProfitAndLossToolStripMenuItem
            // 
            unrealizedProfitAndLossToolStripMenuItem.Name = "unrealizedProfitAndLossToolStripMenuItem";
            unrealizedProfitAndLossToolStripMenuItem.Size = new Size(224, 26);
            unrealizedProfitAndLossToolStripMenuItem.Text = "未實現損益";
            unrealizedProfitAndLossToolStripMenuItem.Click += unrealizedProfitAndLossToolStripMenuItem_Click;
            // 
            // tradingDailyReportToolStripMenuItem
            // 
            tradingDailyReportToolStripMenuItem.Name = "tradingDailyReportToolStripMenuItem";
            tradingDailyReportToolStripMenuItem.Size = new Size(98, 24);
            tradingDailyReportToolStripMenuItem.Text = "買賣日報表";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem warrantToolStripMenuItem;
        private ToolStripMenuItem tradingDailyReportToolStripMenuItem;
        private ToolStripMenuItem marketMakingToolStripMenuItem;
        private ToolStripMenuItem hitRateQueryToolStripMenuItem;
        private ToolStripMenuItem realTimeProfitAndLossToolStripMenuItem;
        private ToolStripMenuItem warrantToolsToolStripMenuItem;
        private ToolStripMenuItem unrealizedProfitAndLossToolStripMenuItem;
    }
}
