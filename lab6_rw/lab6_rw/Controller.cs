using System;
using lab6_2;
using lab6_rw;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab6_3
{


    partial class Controller
    {

        static int pepricesum;
        static int textbookamount = 0;
            public static void TBPriceSummary(List<TextBook> tb)
        {

            foreach (TextBook item in tb)
            {
                textbookamount++;

            }
            Console.WriteLine($"Количество всех учебников в библиотеке - {textbookamount} единицы");
        }


        public static void ShowBooksNewerThan(List<Print_Edition> pe)
        {
            Console.WriteLine($"Фильтр -> год издания | Введите год, не ранее которого было выпущено желаемое печатное издание ");
            int year_limit = int.Parse(Console.ReadLine());
            foreach (Print_Edition item in pe)
            {
                if(item.Year >= year_limit)
                {
                    Console.WriteLine($"Название печатного издания в соответствии с фильтром: {item.Name}");
                }

            }

            foreach (Print_Edition item in pe)
            {
                pepricesum += item.Price;

            }
            Console.WriteLine($"Стоимость всех печатных изданий в библиотеке: {pepricesum} ");
        }

        public static void ReadCollectionFromFile()
        {
            string path = @"C:\Users\yegor\source\repos\lab6_rw\lab6_rw\lab6_rw\TextFile.txt";
            string temp;
            List<string> CollectionOfStrings = new List<string>();
            StreamReader sr = new StreamReader(path);
            do
            {
                temp = sr.ReadLine();
                CollectionOfStrings.Add(temp);
            }
            while (temp != null);
            foreach (string str in CollectionOfStrings)
            {
                Console.WriteLine(str);
            }
        }

    }
}
