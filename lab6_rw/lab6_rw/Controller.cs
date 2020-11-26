using System;
using lab6_2;
using lab6_rw;
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





        //}

        //partial class Controller : IComparer<Fighter>
        //{
        //    public int Compare(Fighter p1, Fighter p2)
        //    {
        //        if (p1.Name.Length > p2.Name.Length)
        //            return 1;
        //        else if (p1.Name.Length < p2.Name.Length)
        //            return -1;
        //        else
        //            return 0;
        //    }


        //    public static List<Fighter> SortByPower(List<Fighter> fighters)
        //    {
        //        Fighter temp;
        //        for (int i = 0; i < fighters.Count; i++)
        //        {
        //            for (int j = i + 1; j < fighters.Count; j++)
        //            {
        //                if (fighters[i].AttackPower > fighters[j].AttackPower)
        //                {
        //                    temp = fighters[i];
        //                    fighters[i] = fighters[j];
        //                    fighters[j] = temp;
        //                }
        //            }
        //        }


        //        return fighters;
        //    }
    }
}
