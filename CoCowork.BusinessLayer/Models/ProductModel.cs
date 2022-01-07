using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;

namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : ItemModel
    {
        public string TypeForDisplayInUI = "Продукты";

        public override void CalculateSubtotalPrice(decimal price)
        {
            SubtotalPrice = price;
        }
    }
}
