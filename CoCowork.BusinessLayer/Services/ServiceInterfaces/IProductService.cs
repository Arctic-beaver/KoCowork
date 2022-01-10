using CoCowork.BusinessLayer.Models;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    internal interface IProductService
    {
        List<ProductModel> GetAll();
    }
}