using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormTours : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly TourLogic logic;

        public FormTours(TourLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormTours_Load(object sender, EventArgs e)
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
                    dataGridViewTours.DataSource = list;
                    dataGridViewTours.Columns[0].Visible = false;
                    dataGridViewTours.Columns[6].Visible = false;
                    dataGridViewTours.AutoResizeColumns();
                    dataGridViewTours.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormTour>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormTour>();
                form.Id = Convert.ToInt32(dataGridViewTours.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewTours.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new TourBindingModel { Id = id });
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
        private void ButtonToursVerboseMode_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormToursVerboseMode>();
            form.ShowDialog();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCostFrom.Text))
            {
                MessageBox.Show("Заполните нижнюю цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCostTo.Text))
            {
                MessageBox.Show("Заполните верхнюю цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var list = logic.Read(new TourBindingModel
                {
                    CostFrom = Convert.ToDecimal(textBoxCostFrom.Text),
                    CostTo = Convert.ToDecimal(textBoxCostTo.Text)
                });
                dataGridViewTours.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
