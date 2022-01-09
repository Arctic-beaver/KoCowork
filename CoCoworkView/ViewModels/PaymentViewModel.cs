using CoCowork.UI.Commands;
using System;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class PaymentViewModel : InnerGridViewModel
    {
        private decimal? _amount;
        private DateTime? _paymentDate;
        private int? _orderId;
        private bool _isAddPaymentButtonAvailable;

        public PaymentViewModel()
        {
            GridVisibility = Visibility.Collapsed;
            Amount = 34;

            ChangePaymentVisibility = new VisibilityOfInnerGridCommand(this);
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
                    OnPropertyChanged(nameof(IsAddPaymentButtonAvailable));
                }
            }
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            IsAddPaymentButtonAvailable = (Amount != null && PaymentDate != null);
        }

        public ICommand ChangePaymentVisibility { get; set; }
    }
}
