using System;
using lab6_3;
using lab6_rw;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    static class Library
    {
        public static List<Print_Edition> print_edition = new List<Print_Edition>();
        public static List<Print_Edition> all_print_editions { get; set; }
        public static List<TextBook> text_book = new List<TextBook>();
        public static List<TextBook> all_textbooks { get; set; }

        public static void Add(Print_Edition pe)
        {
            print_edition.Add(pe);
            Console.WriteLine("В список добавлен {0}", pe.Name);
        }

        public static Print_Edition Remove(Print_Edition pe)
        {
            foreach (Print_Edition item in print_edition)
            {
                if (pe == item)
                {
                    print_edition.Remove(pe);
                    return pe;
                }


            }
            Console.WriteLine("Такого печатного издания в списке нет");
            return null;
        }

        public static void ShowList()
        {
            Console.WriteLine("Полный список печатных изданий:");
            foreach (Print_Edition pe in print_edition)
            {
                Console.WriteLine($"Название кинги:{pe.Name} | Год издания:{pe.Year} | Стоимость:{pe.Price}");
            }
        }

        public static void AddTB(TextBook tb)
        {
            text_book.Add(tb);
            
        }

        public static TextBook RemoveTB(TextBook tb)
        {
            foreach (Print_Edition item in text_book)
            {
                if (tb == item)
                {
                    text_book.Remove(tb);
                    return tb;
                }


            }
            Console.WriteLine("Такого печатного издания в списке нет");
            return null;
        }

       

        public struct Library_S
        {

            public string sector;

            public enum Bookshelves : long
            {
                first = 1, second = 2, third = 3, fourth = 4, fifth = 5
            }

        }

    }


    
}
