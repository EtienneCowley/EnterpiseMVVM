using EnterpiseMVVM.Windows;
using System.ComponentModel.DataAnnotations;

namespace EnterpirseMVVM.DesktopClient.ViewModels
{
    public class CustomerViewModel : ViewModel
    {
        private string customerName;

        [Required]
        [StringLength(32, MinimumLength = 4)]
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged();
            }
        }

        protected override string OnValidate(string propertyName)
        {
            if (CustomerName != null && !CustomerName.Contains(" "))
                return "Customer name must include both a first and last name";

            return base.OnValidate(propertyName);
        }
    }
}
