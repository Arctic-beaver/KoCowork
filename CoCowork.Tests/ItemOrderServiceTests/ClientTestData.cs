using CoCowork.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Tests.ItemOrderServiceTests
{
    public class ClientTestData
    {
        public Client GetClientForTests()
        {
            Client client = new Client
            {
                Id = 1,
                FirstName = "клёвый",
                LastName = "чел",
                DateBirth = DateTime.Now,
                PaperEndDay = DateTime.Now,
                Email = "bububu",
                PaperAmount = 10,
                Phone = "555"
            };
            return client;
        }
    }
}
