using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormSalesForPeriod : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SaleLogic logicS;
        private readonly TourLogic logicT;

        public FormSalesForPeriod(SaleLogic logicS, TourLogic logicT)
        {
            InitializeComponent();
            this.logicS = logicS;
            this.logicT = logicT;
        }
        private void ButtonMake_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var sales = logicS.Read(new SaleBindingModel
                {
                    DateFrom = dateTimePickerFrom.Value,
                    DateTo = dateTimePickerTo.Value,
                });
                dataGridViewSales.Rows.Clear();
                foreach (var sale in sales)
                {
                    var tour = logicT.Read(new TourBindingModel
                    {
                        Id = sale.TourId
                    })?[0];
                    dataGridViewSales.Rows.Add(new object[] {
                    sale.Id,
                    sale.ClientFIO,
                    sale.TourName,
                    tour?.Cost,
                    sale.DateOfSale.ToShortDateString()
                });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
