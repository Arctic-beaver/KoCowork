using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.ViewModels
{
    public class PaymentViewModel : TabViewModel
    {
        private decimal? _amount;
        private DateTime? _paymentDate;
        private int? _orderId;
        private bool _isAddPaymentButtonAvailable;

        public PaymentViewModel()
        {

        }

        public decimal? Amount
        {
            get => _amount;
            set
            {
                if (value != _amount)
                {
                    _amount = value;
                    OnPropertyChanged(nameof(Amount));
                    CheckIfAllFieldsFilledCorrectly();
                }
            }
        }

        public DateTime? PaymentDate
        {
            get => _paymentDate;
            set
            {
                if (value != _paymentDate)
                {
                    _paymentDate = value;
                    OnPropertyChanged(nameof(PaymentDate));
                    CheckIfAllFieldsFilledCorrectly();
                }
            }
        }

        public int? OrderId
        {
            get => _orderId;
            set
            {
                if (value != _orderId)
                {
                    _orderId = value;
                    OnPropertyChanged(nameof(OrderId));
                    CheckIfAllFieldsFilledCorrectly();
                }
            }
        }

        public bool IsAddPaymentButtonAvailable
        {
            get => _isAddPaymentButtonAvailable;
            set
            {
                if (value != _isAddPaymentButtonAvailable)
                {
                    _isAddPaymentButtonAvailable = value;
                    OnPropertyChanged(nameof(IsPaymentButtonAvailable));
                }
            }
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            if (Amount != null &&
            PaymentDate != null &&
            OrderId != null) IsAddPaymentButtonAvailable = true;
            else IsAddPaymentButtonAvailable = false;
        }
            
    }
}
