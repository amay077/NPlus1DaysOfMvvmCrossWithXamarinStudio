using System;
using Cirrious.MvvmCross.ViewModels;

namespace FirstDemo.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged(() => FullName);}
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged(() => FullName);}
        }

        public string FullName
        {
            get { return String.Format("{0} {1}", _firstName, _lastName); }
        }
    }
}

