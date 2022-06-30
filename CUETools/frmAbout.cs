using System.Windows.Forms;

namespace JDP
{
	public partial class frmAbout : Form
	{
		public frmAbout()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start((sender as LinkLabel).Text.Substring(e.Link.Start, e.Link.Length));
		}

        private void frmAbout_Load(object sender, System.EventArgs e)
        {

        }
    }
}