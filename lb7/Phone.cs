using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7
{
    public abstract class Phone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Cost { get; set; }
        public int ReleaseYear { get; set; }
        public string YearOfPurchase { get; set; }


        public abstract void DisplayInfo();
    }
}
