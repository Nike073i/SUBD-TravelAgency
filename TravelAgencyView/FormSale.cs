using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormSale : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly SaleLogic logicS;
        private readonly TourLogic logicT;
        private readonly ClientLogic logicC;
        private int? id;

        public FormSale(SaleLogic logicS, TourLogic logicT, ClientLogic logicC)
        {
            InitializeComponent();
            this.logicS = logicS;
            this.logicT = logicT;
            this.logicC = logicC;
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            var listClients = logicC.Read(null);
            var listTours = logicT.Read(null);
            comboBoxClients.DataSource = listClients;
            comboBoxClients.ValueMember = "Id";
            comboBoxClients.DisplayMember = "FIO";
            comboBoxClients.SelectedItem = null;
            comboBoxTours.DataSource = listTours;
            comboBoxTours.ValueMember = "Id";
            comboBoxTours.DisplayMember = "Name";
            comboBoxTours.SelectedItem = null;

            if (id.HasValue)
            {
                try
                {
                    var view = logicS.Read(new SaleBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        comboBoxClients.Text = view.ClientFIO;
                        comboBoxTours.Text = view.TourName;
                        dateTimePickerDateOfSale.Value = view.DateOfSale;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxTours.SelectedValue == null)
            {
                MessageBox.Show("Выберите тур", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicS.CreateOrUpdate(new SaleBindingModel
                {
                    Id = id,
                    ClientId = (int)comboBoxClients.SelectedValue,
                    TourId = (int)comboBoxTours.SelectedValue,
                    DateOfSale = dateTimePickerDateOfSale.Value
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
