using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCowork.BusinessLayer.Services;
using CoCowork.BusinessLayer.Configuration;
namespace CoCowork.BusinessLayer.Tests
{
    public class PaymentServiceTests
    {
        private readonly Mock<IPaymentRepository> _paymentRepositoryMock;
        private readonly PaymentTestData _paymentTestData;

        public PaymentServiceTests()
        {
            _paymentRepositoryMock = new Mock<IPaymentRepository>();
            _paymentTestData = new PaymentTestData();
        }

        [Test]
        public void AddOrder_ShouldAddOrderToDB()
        {
            //arrange
            var paymentModel = _paymentTestData.GetPaymentModelForTests();

            _paymentRepositoryMock.Setup(m => m.Add(It.IsAny<Payment>()));
            var sut = new PaymentService(_paymentRepositoryMock.Object);

            //act
            var actual = sut.Add(paymentModel);

            //assert
            Assert.AreEqual(actual, "Success");
            _paymentRepositoryMock.Verify(m => m.Add(It.IsAny<Payment>()), Times.Once());
        }
    }
}
