using BindingExample.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace BindingExample.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            AddCarCommand = new RelayCommand(AddCar);
            Cars = new ObservableCollection<Car>();
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Blue),
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Red),
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Yellow),
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Green),
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Green),
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Green),
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Green),
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Green),
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Green),
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Green),
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = new SolidColorBrush(Colors.Cyan),
                Year = 2016
            });

            Vehicles = new ObservableCollection<string> { "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", };
        }

        private void AddCar()
        {
            Car car = new Car()
            {
                Color = new SolidColorBrush(Colors.Coral),
                Manufacturer = "Renault",
                Model = "Laguna",
                Year = 2009
            };
            Cars.Add(car);
        }

        private ObservableCollection<Car> _cars;

        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
            set
            {
                _cars = value;
                RaisePropertyChanged();
            }
        }


        //public List<Car> Cars { get; set; }

        public ObservableCollection<string> Vehicles { get; set; }

        public RelayCommand AddCarCommand { get; set; }

    }
}
