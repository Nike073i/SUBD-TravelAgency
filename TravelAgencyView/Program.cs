using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BusinessLogic;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyDatabaseImplement.Implements;
using Unity;
using Unity.Lifetime;

namespace TravelAgencyView
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IClientStorage, ClientStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICountryStorage, CountryStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IHotelStorage, HotelStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ISaleStorage, SaleStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITourStorage, TourStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ClientLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<CountryLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<HotelLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<SaleLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<TourLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
