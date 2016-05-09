using BindingExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            Cars = new List<Car>();
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });
            Cars.Add(new Car
            {
                Manufacturer = "Audi",
                Model = "S3",
                Color = "Silver",
                Year = 2016
            });

            Vehicles = new ObservableCollection<string> { "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", "Audi", };
        }
        public List<Car> Cars { get; set; }

        public ObservableCollection<string> Vehicles { get; set; }
    }
}
