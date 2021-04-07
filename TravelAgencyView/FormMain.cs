using System;
using System.Windows.Forms;
using Unity;

namespace TravelAgencyView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void страныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCountries>();
            form.ShowDialog();
        }
    }
}
