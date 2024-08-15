using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersMobile.MVVM.ViewModels
{
    public class BMIViewModel : INotifyPropertyChanged
    {
        private Models.BMI _bmi;

        public Models.BMI BMI
        {
            get => _bmi;
            set
            {
                _bmi = value;
                OnPropertyChanged();
            }
        }

        public BMIViewModel()
        {
            BMI = new Models.BMI
            {
                Height = 180,
                Weight = 73
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}