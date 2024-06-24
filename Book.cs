using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_06
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        
        public Date Date { get; set; }

        public Book() { }

        public Book(string title, string author, string genre, Date date)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Date = date;
        }


        public void ChangeTitle()
        {
            Console.WriteLine($"Current Title: {Title}");
            Console.Write("Enter new Title: ");
            Title = Console.ReadLine();

            
        }

        public void ChangeAuthor()
        {
            Console.WriteLine($"CurrentAuthor: {Author}");
            Console.Write("Enter new author: ");
            Author = Console.ReadLine();
        }

        public void ChangeGenre()
        {
            Console.WriteLine($"Current genre: {Genre}");
            Console.Write("Enter new genre: ");
            Genre = Console.ReadLine();
        }

        public void ChangeDate()
        {
            int d, m, y;
            string day, month, year;
            Console.WriteLine($"Current date: {Date.ToString()}");
            Console.Write("Enter new date: ");
            day = Console.ReadLine();
            month = Console.ReadLine();
            year = Console.ReadLine();

            int.TryParse(day, out d);
            int.TryParse(month, out m);
            int.TryParse(year, out y);

            Date newDate = new Date(d,m,y);
            Date = newDate;

        }


        public void Change()
        {
            string choice;
            int ch;
            
            Console.WriteLine("[1] - Change title\n[2] - Change author\n[3] - Change genre\n[4] - Change date");
            choice = Console.ReadLine();
            int.TryParse(choice, out ch);

            switch(choice)
            {
                case "1":
                    {
                        this.ChangeTitle();
                        break;

                    }
                case "2":
                    {
                        this.ChangeAuthor(); 
                        break;
                    }
                case "3":
                    {
                        this.ChangeGenre();
                        break;
                    }
                case "4":
                    {
                        this.ChangeDate(); 
                        break;
                    }
                default :
                    {
                        throw new Exception("Incorrect choice");
                        break;
                    }
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nGenre: {Genre}\nDate: {Date.ToString()}";
        }
    }
}
