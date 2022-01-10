using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
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
        public void AddPayment_ShouldAddPaymentToDB()
        {
            //arrange
            var paymentModel = _paymentTestData.GetPaymentModelForTests();

            _paymentRepositoryMock.Setup(m => m.Add(It.IsAny<Payment>())).Returns(1);
            var sut = new PaymentService(_paymentRepositoryMock.Object);

            //act
            var actual = sut.Add(paymentModel);

            //assert
            _paymentRepositoryMock.Verify(m => m.Add(It.IsAny<Payment>()), Times.Once());
        }
    }
}
