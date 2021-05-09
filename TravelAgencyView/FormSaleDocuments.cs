using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormSaleDocuments : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SaleDocumentLogic logic;

        public FormSaleDocuments(SaleDocumentLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormSaleDocuments_Load(object sender, EventArgs e)
        {
            LoadData(null);
        }
        private void LoadData(SaleDocumentBindingModel model)
        {
            try
            {
                var list = logic.Read(model);
                if (list != null)
                {
                    dataGridViewSaleDocuments.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void buttonUpdateCache_Click(object sender, EventArgs e)
        {
            logic.UpdateCashe();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadData(new SaleDocumentBindingModel
            {
                ClientFIO = textBoxFIO.Text
            });
        }
    }
}
