using System;
using lab6_2;
using lab6_3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;


namespace lab6_rw
{
    interface IBook
    {
        bool Firm_Binding();
        string Pages_Amount();

    }



    interface IPaper
    {
        void Clone();
    }





    public abstract class Publishing_House : IBook
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract string Pages_Amount();
        virtual public bool Firm_Binding()
        {
            return true;
        }
        
        public abstract void Clone();

    }

    public class Print_Edition : Publishing_House, IPaper
    {

        protected string name;
        protected int year;
        protected int price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        public override string ToString()
        {
            Console.WriteLine(Name + " " + Year + " " + Price + " ");
            return " type " + base.ToString();
        }

        public override void Clone()
        {
            Console.WriteLine("Метод абстрактного класса");
        }

        void IPaper.Clone()
        {
            Console.WriteLine("Метод интерфейса");
        }


        public override bool Firm_Binding()
        {
            return false;
        }

        public override string Pages_Amount()
        {
            return "Количество книг в этом печатном издании не определено";

        }
    }







    sealed public class Book : Print_Edition, IPaper
    {



        public Book(string name, int year, int price)
        {
            this.name = name;
            this.year = year;
            this.price = price;
        }


        public override string ToString()
        {
            Console.WriteLine(Name + " " + Year + " " + Price + " ");
            return " type " + base.ToString();
        }

    }

    sealed public class TextBook : Print_Edition, IPaper
    {



        public TextBook(string name, int year, int price)
        {
            this.name = name;
            this.year = year;
            this.price = price;
        }


        public override string ToString()
        {
            Console.WriteLine(Name + " " + Year + " " + Price + " ");
            return " type " + base.ToString();
        }

    }


    sealed public class Magazine : Print_Edition, IPaper
    {



        public Magazine(string name, int year, int price)
        {
            this.name = name;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            Console.WriteLine(Name + " " + Year + " " + Price + " ");
            return " type " + base.ToString();
        }


    }














    
    public class Printer
    {
        public void IAmPrinting(Publishing_House publishing_house)
        {
            Console.WriteLine(publishing_house.ToString());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Война и мир (в 2-ух томах)", 2014, 16);
            
            Magazine magazine1 = new Magazine("Сказочный патруль #5", 2018, 16 );
            
            TextBook textbook1 = new TextBook("Учебник-тетрадь по информатике. 3 класс", 2013, 15);
            
            TextBook textbook2 = new TextBook("Полный курс английского языка", 2014, 19);
          
            TextBook textbook3 = new TextBook("Учебник тибетского языка", 2016, 18);
            


            Library.Add(book1);
            Library.Add(magazine1);
            Library.Add(textbook1);
            Library.Add(textbook2);
            Library.Add(textbook3);
            Library.AddTB(textbook1);
            Library.AddTB(textbook2);
            Library.AddTB(textbook3);


            Console.WriteLine("--------------------------------------------------------------------");

            Library.ShowList();
            Console.WriteLine("--------------------------------------------------------------------");
            Controller.TBPriceSummary(Library.text_book);
            Console.WriteLine("--------------------------------------------------------------------");
            Controller.ShowBooksNewerThan(Library.print_edition);
            
           

            Console.WriteLine("------------------------------------------------------");


            Library.Library_S book;
            Console.WriteLine("Выберите сектор полки, в который вы хотели бы поместить книгу (A, B): ");
            book.sector = Console.ReadLine();

            Console.WriteLine("Выберите книгу(1-5), чтобы поместить её в выбранный сектор {0}", book.sector);
            switch (int.Parse(Console.ReadLine()))
            {
                case (int)Library.Library_S.Bookshelves.first:
                    Console.WriteLine("Первую книгу поместили в сектор {0}", book.sector);
                    break;
                case (int)Library.Library_S.Bookshelves.second:
                    Console.WriteLine("Первую книгу поместили в сектор {0}", book.sector);
                    break;
                case (int)Library.Library_S.Bookshelves.third:
                    Console.WriteLine("Первую книгу поместили в сектор {0}", book.sector);
                    break;
                case (int)Library.Library_S.Bookshelves.fourth:
                    Console.WriteLine("Первую книгу поместили в сектор {0}", book.sector);
                    break;
                case (int)Library.Library_S.Bookshelves.fifth:
                    Console.WriteLine("Первую книгу поместили в сектор {0}", book.sector);
                    break;
                default:
                    Console.WriteLine("Книги под таким номером не существует");
                    break;
            }

            Controller.ReadCollectionFromFile();

            //var JS = new JsonTester(27, "Yellow Submarine Ltd.");
            //var json = JsonConvert.SerializeObject(JS, Formatting.Indented);
            //Console.WriteLine(json);
            //var NewInfo = JsonConvert.DeserializeObject<JsonTester>(json);
            //Console.WriteLine(NewInfo.Str + NewInfo.Number);


        }


    }
}

