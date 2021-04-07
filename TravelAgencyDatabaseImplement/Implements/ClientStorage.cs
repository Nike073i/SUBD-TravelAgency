﻿using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.DatabaseContext;
using TravelAgencyDatabaseImplement.Models;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class ClientStorage : IClientStorage
    {
        public List<ClientViewModel> GetFullList()
        {
            using (var context = new TravelAgencyDatabase())
            {
                return context.Client
                .Select(rec => new ClientViewModel
                {
                    Id = rec.Id,
                    FirstName = rec.Firstname,
                    SecondName = rec.Secondname,
                    MiddleName = rec.Middlename,
                    ContactNumber = rec.Contactnumber
                }).ToList();
            }
        }
        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                return context.Client
                .Where(rec => rec.Secondname.Contains(model.SecondName))
               .Select(rec => new ClientViewModel
               {
                   Id = rec.Id,
                   FirstName = rec.Firstname,
                   SecondName = rec.Secondname,
                   MiddleName = rec.Middlename,
                   ContactNumber = rec.Contactnumber
               }).ToList();
            }
        }
        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                var client = context.Client
                .FirstOrDefault(rec => rec.Contactnumber.Equals(model.ContactNumber) || rec.Id == model.Id);
                return client != null ?
                new ClientViewModel
                {
                    Id = client.Id,
                    FirstName = client.Firstname,
                    SecondName = client.Secondname,
                    MiddleName = client.Middlename,
                    ContactNumber = client.Contactnumber
                } : null;
            }
        }
        public void Insert(ClientBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                context.Client.Add(CreateModel(model, new Client()));
                context.SaveChanges();
            }
        }
        public void Update(ClientBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                var client = context.Client.FirstOrDefault(rec => rec.Id == model.Id);
                if (client == null)
                {
                    throw new Exception("Клиент не найден");
                }
                CreateModel(model, client);
                context.SaveChanges();
            }
        }
        public void Delete(ClientBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                Client client = context.Client.FirstOrDefault(rec => rec.Id == model.Id);
                if (client != null)
                {
                    context.Client.Remove(client);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Клиент не найден");
                }
            }
        }
        private Client CreateModel(ClientBindingModel model, Client client)
        {
            client.Firstname = model.FirstName;
            client.Secondname = model.SecondName;
            client.Middlename = model.MiddleName;
            client.Contactnumber = model.ContactNumber;
            return client;
        }
    }
}
