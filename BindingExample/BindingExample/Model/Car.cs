using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace BindingExample.Model
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Brush Color { get; set; }
        public int Year { get; set; }
    }
}
