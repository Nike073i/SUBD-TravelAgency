using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormTour : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly HotelLogic logicH;
        private readonly TourLogic logicT;
        private int? id;
        private DateTime PublicationDate;

        public FormTour(TourLogic logicT, HotelLogic logicH)
        {
            InitializeComponent();
            this.logicH = logicH;
            this.logicT = logicT;
        }
        private void FormTour_Load(object sender, EventArgs e)
        {
            var listHotels = logicH.Read(null);
            comboBoxHotels.DataSource = listHotels;
            comboBoxHotels.ValueMember = "Id";
            comboBoxHotels.DisplayMember = "Name";
            comboBoxHotels.SelectedItem = null;
            if (id.HasValue)
            {
                try
                {
                    var view = logicT.Read(new TourBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxCost.Text = view.Cost.ToString();
                        dateTimePickerDayOfBegining.Value = view.DateOfBegininng;
                        comboBoxHotels.SelectedValue = view.HotelId;
                        textBoxNumberOfDays.Text = view.NumberOfDays.ToString();
                        textBoxNumberOfPeople.Text = view.NumberOfPeople.ToString();
                        PublicationDate = view.PublicationDate;
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
            if (string.IsNullOrEmpty(textBoxCost.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dateTimePickerDayOfBegining.Value == null)
            {
                MessageBox.Show("Выберите время", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxHotels.SelectedValue == null)
            {
                MessageBox.Show("Выберите отель", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNumberOfDays.Text))
            {
                MessageBox.Show("Заполните количество дней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNumberOfPeople.Text))
            {
                MessageBox.Show("Заполните количество людей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicT.CreateOrUpdate(new TourBindingModel
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Cost = Convert.ToDecimal(textBoxCost.Text),
                    DateOfBegininng = dateTimePickerDayOfBegining.Value,
                    HotelId = (int)comboBoxHotels.SelectedValue,
                    NumberOfDays = Convert.ToInt32(textBoxNumberOfDays.Text),
                    NumberOfPeople = Convert.ToInt32(textBoxNumberOfPeople.Text),
                    PublicationDate = PublicationDate,
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
