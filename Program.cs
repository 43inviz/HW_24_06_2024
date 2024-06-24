using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(1,1,1000);
            Date date2 = new Date(2,2,2000);
            Date date3 = new Date(3,3,3000);


            Date date4 = new Date(4,4,4000);

            Book book = new Book("111", "111", "111",date1);
            Book book2 = new Book("222", "222", "222", date2);
            Book book3 = new Book("333", "333", "333", date3);

            Book book4 = new Book("444", "444", "444", date4);

            LinkedList<Book> list = new LinkedList<Book>();
            list.AddFirst(book3);
            list.AddFirst(book2);
            list.AddFirst(book);

            BookDatabase database = new BookDatabase(list);

            //database.AddBook(book4); додавання книги

            //database.AddBookInFirst(book4); додавання вперед

            //database.AddBookInLast(book4); додавання в кiнець

            //database.AddBookInPlace(book4); додавання на позицiю 

            //database.RemoveFromFirst(); удаление в начала

            //database.RemoveFromLast(); удаление с конца

            //database.RemoveFromPosition(); удаление с позиции

            



            database.ShowDatabase();

            

            Console.ReadLine();
        }
    }
}
