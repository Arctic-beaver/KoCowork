using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.BusinessLayer.Tests.ItemOrderServiceTests;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests.ItemOrderServiceTests
{
    class ProductOrderServiceTests
    {

        private readonly Mock<IProductOrderRepository> _productOrderRepository;
        private readonly OrdersTestData _ordersTestData;

        public ProductOrderServiceTests()
        {
            _productOrderRepository = new Mock<IProductOrderRepository>();
            _ordersTestData = new OrdersTestData();
        }

        [Test]
        public void AddProductOrder()
        {
            //arrange
            var product = _ordersTestData.GetProductModelForTests();
            _productOrderRepository.Setup(m => m.Add(It.IsAny<ProductOrder>()));
            var sut = new ProductService(_productOrderRepository.Object);

            ////act
            var actual = sut.AddItemOrder(product);

            //assert
            _productOrderRepository.Verify(m => m.Add(It.IsAny<ProductOrder>()), Times.Once());
        }
    }
}
