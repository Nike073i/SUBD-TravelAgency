using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogic;
using Unity;

namespace TravelAgencyView
{
    public partial class FormToursVerboseMode : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly TourLogic logicT;
        private readonly HotelLogic logicH;

        public FormToursVerboseMode(TourLogic logicT, HotelLogic logicH)
        {
            InitializeComponent();
            this.logicT = logicT;
            this.logicH = logicH;
        }
        private void FormToursVerboseMode_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var tours = logicT.Read(null);
                dataGridViewTours.Rows.Clear();
                foreach (var tour in tours)
                {
                    var hotel = logicH.Read(new HotelBindingModel
                    {
                        Id = tour.HotelId
                    })?[0];
                    dataGridViewTours.Rows.Add(new object[]
                    {
                        tour.Id,
                        tour.Name,
                        hotel?.CountryName,
                        hotel.Address,
                        tour.NumberOfPeople,
                        tour.DateOfBegininng.ToShortDateString(),
                        tour.NumberOfDays
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
