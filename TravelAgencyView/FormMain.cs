using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using TravelAgencyBusinessLogic.Interfaces;
using Unity;

namespace TravelAgencyView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SaleLogic logicS;
        private readonly TransferLogic logicT;
        private readonly IHotelDocumentStorageRedis hotelDocumentStorage;
        public FormMain(SaleLogic logicS, TransferLogic transferLogic, IHotelDocumentStorageRedis hotelDocumentStorage)
        {
            InitializeComponent();
            this.logicS = logicS;
            this.logicT = transferLogic;
            this.hotelDocumentStorage = hotelDocumentStorage;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var sales = logicS.Read(null);
                if (sales != null)
                {
                    dataGridViewSales.DataSource = sales;
                    dataGridViewSales.Columns[0].Visible = false;
                    dataGridViewSales.Columns[1].Visible = false;
                    dataGridViewSales.Columns[3].Visible = false;
                    dataGridViewSales.AutoResizeColumns();
                    dataGridViewSales.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSale>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormSale>();
                form.Id = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logicS.Delete(new SaleBindingModel { Id = id });
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

        private void ButtonSalesForPeriod_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSalesForPeriod>();
            form.ShowDialog();
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

        private void отелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormHotels>();
            form.ShowDialog();
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormTours>();
            form.ShowDialog();
        }

        private void перенестиДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicT.TransferAll();
        }

        private void отелидокументыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormHotelDocuments>();
            form.ShowDialog();
        }

        private void продажидокументыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSaleDocuments>();
            form.ShowDialog();
        }
    }
}
