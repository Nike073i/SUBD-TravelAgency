using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormHotels : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly HotelLogic logic;

        public FormHotels(HotelLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormHotels_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);
                if (list != null)
                {
                    dataGridViewHotels.DataSource = list;
                    dataGridViewHotels.AutoResizeColumns();
                    dataGridViewHotels.Columns[0].Visible = false;
                    dataGridViewHotels.Columns[3].Visible = false;
                    dataGridViewHotels.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormHotel>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotels.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormHotel>();
                form.Id = Convert.ToInt32(dataGridViewHotels.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotels.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewHotels.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new HotelBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRatingFrom.Text))
            {
                MessageBox.Show("Заполните нижний рейтинг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxRatingTo.Text))
            {
                MessageBox.Show("Заполните верхний рейтинг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var list = logic.Read(new HotelBindingModel
                {
                    RatingFrom = Convert.ToInt32(textBoxRatingFrom.Text),
                    RatingTo = Convert.ToInt32(textBoxRatingTo.Text)
                });
                dataGridViewHotels.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
