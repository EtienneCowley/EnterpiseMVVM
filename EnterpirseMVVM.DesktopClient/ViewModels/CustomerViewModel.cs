using EnterpiseMVVM.Windows;
using System.ComponentModel.DataAnnotations;

namespace EnterpirseMVVM.DesktopClient.ViewModels
{
    public class CustomerViewModel : ViewModel
    {
        private string customerName;

        [Required]
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged();
            }
        }
    }
}
