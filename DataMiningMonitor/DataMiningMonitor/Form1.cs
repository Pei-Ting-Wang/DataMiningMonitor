namespace DataMiningMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unrealizedProfitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnrealizedPnLForm unrealizedPnLForm = new UnrealizedPnLForm();
            unrealizedPnLForm.Show();
        }
    }
}
