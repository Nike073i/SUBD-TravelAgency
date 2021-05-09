using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormHotelDocuments : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly HotelDocumentLogic logic;

        public FormHotelDocuments(HotelDocumentLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormHotelDocuments_Load(object sender, EventArgs e)
        {
            LoadData(null);
        }
        private void LoadData(HotelDocumentBindingModel model)
        {
            try
            {
                var list = logic.Read(model);
                if (list != null)
                {
                    dataGridViewHotelDocuments.DataSource = list;
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
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadData(new HotelDocumentBindingModel
            {
                Name = textBoxName.Text
            });
        }
    }
}
