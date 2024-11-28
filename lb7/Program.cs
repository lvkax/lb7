using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7
{
    internal class Program
    {
        static List<Phone> phones;
        static void Main(string[] args)
        {
            phones = new List<Phone>();
            FileStream fs = new FileStream("Phonee.phones", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            try
            {
                Phone ph;
                Console.WriteLine("\tЧитаємо данi з файлу...\n");
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    ph = new SmartPhone();
                    for (int i = 1; i <= 5; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                ph.Name = reader.ReadString();
                                break;
                            case 2:
                                ph.Model = reader.ReadString();
                                break;
                            case 3:
                                ph.Cost = reader.ReadInt32();
                                break;
                            case 4:
                                ph.ReleaseYear = reader.ReadInt32();
                                break;
                            case 5:
                                ph.YearOfPurchase = reader.ReadString();
                                break;
                        }
                    }
                    phones.Add(ph);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: {0}", ex.Message);
            }
            finally
            {
                reader.Close();
            }

            Console.WriteLine("Несортований перелік телефонів: {0}", phones.Count);
            PrintTelevisions();

            phones.Sort();
            Console.WriteLine("\nСортований перелік телефонів за брендом: {0}", phones.Count);
            PrintTelevisions();

            Console.WriteLine("\nДодаємо новий запис: Samsung Q90");
            phones.Add(new SmartPhone("Samsung", "Galaxy A6", 15000, 2015, "2020"));

            Console.WriteLine("\nПерелік телефонів: {0}", phones.Count);
            PrintTelevisions();

            Console.WriteLine("\nВидаляємо останнє значення");
            phones.RemoveAt(phones.Count - 1);

            Console.WriteLine("\nПерелік телефонів: {0}", phones.Count);
            PrintTelevisions();

            while (true) Console.ReadKey();
        }

        static void PrintTelevisions()
        {
            foreach (SmartPhone smartPhone in phones)
            {
                Console.WriteLine(smartPhone.Info().Replace('і', 'i'));
            }
            Console.WriteLine();
        }
    }
}
