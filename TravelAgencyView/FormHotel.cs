using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormHotel : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly HotelLogic logicH;
        private readonly CountryLogic logicC;
        private int? id;

        public FormHotel(HotelLogic logicH, CountryLogic logicC)
        {
            InitializeComponent();
            this.logicH = logicH;
            this.logicC = logicC;
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {
            var listCountries = logicC.Read(null);
            comboBoxCountries.DataSource = listCountries;
            comboBoxCountries.ValueMember = "Id";
            comboBoxCountries.DisplayMember = "Name";
            comboBoxCountries.SelectedItem = null;
            if (id.HasValue)
            {
                try
                {
                    var view = logicH.Read(new HotelBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxRating.Text = view.Rating.ToString();
                        comboBoxCountries.SelectedValue = view.CountryId;
                        textBoxAddress.Text = view.Address;
                        textBoxCNumber.Text = view.ContactNumber;
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
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCountries.SelectedValue == null)
            {
                MessageBox.Show("Выберите страну", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Заполните адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCNumber.Text))
            {
                MessageBox.Show("Заполните номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicH.CreateOrUpdate(new HotelBindingModel
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Rating = (textBoxRating.Text.Length > 0) ? Convert.ToInt32(textBoxRating.Text) : 0,
                    Address = textBoxAddress.Text,
                    CountryId = (int)comboBoxCountries.SelectedValue,
                    ContactNumber = textBoxCNumber.Text
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
