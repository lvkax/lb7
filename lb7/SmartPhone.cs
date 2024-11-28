using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lb7
{
    public class SmartPhone : Phone, IComparable
    {
        public bool IsOn { get; set; }
        public int Brightness { get; set; }

        public SmartPhone()
        { }
        public SmartPhone(string name, string model, int cost, int releaseYear, string yearOfPurchase)
        {
            Name = name;
            Model = model;
            Cost = cost;
            ReleaseYear = releaseYear;
            YearOfPurchase = yearOfPurchase;
        }
        public int CompareTo(object obj)
        {
            SmartPhone television = obj as SmartPhone;
            return string.Compare(this.Name, television.Name);
        }

        public string Info()
        {
            return Name + ", " + Model;
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Телефон увімкнено.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Телефон вимкнено.");
        }

        public void AdjustBrightness(int level)
        {
            if (level < 0 || level > 100)
            {
                Console.WriteLine("Рівень яскравості повинен бути від 0 до 100.");
            }
            else
            {
                Brightness = level;
                Console.WriteLine($"Яскравість встановлена на рівні {Brightness}%.");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Бренд: {Name}");
            Console.WriteLine($"Модель: {Model}");            
            Console.WriteLine($"Ціна: {Cost} грн");
            Console.WriteLine($"Рік випуску: {ReleaseYear}\"");
            Console.WriteLine($"Рік покупки: {YearOfPurchase}");
            Console.WriteLine($"Стан: {(IsOn ? "Увімкнено" : "Вимкнено")}");
            Console.WriteLine($"Яскравість: {Brightness}");
        }
    }
}
