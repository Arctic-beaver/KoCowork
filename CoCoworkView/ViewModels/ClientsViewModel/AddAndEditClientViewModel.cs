using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.ViewModels
{
    public abstract class AddAndEditClientViewModel : InnerGridViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _email;
        private DateTime _dateBirth;
        private int _paperAmount;
        private DateTime _paperEndDate;


        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public DateTime DateBirth
        {
            get => _dateBirth;
            set
            {
                _dateBirth = value;
                OnPropertyChanged(nameof(DateBirth));
            }
        }

        public int PaperAmount
        {
            get => _paperAmount;
            set
            {
                _paperAmount = value;
                OnPropertyChanged(nameof(PaperAmount));
            }
        }

        public DateTime PaperEndDate
        {
            get => _paperEndDate;
            set
            {
                _paperEndDate = value;
                OnPropertyChanged(nameof(PaperAmount));
            }
        }
    }
}
