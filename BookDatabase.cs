using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_06
{
    internal class BookDatabase 
    {
        public LinkedList<Book> Books {  get; set; }

        public BookDatabase() { }

        public BookDatabase(LinkedList<Book> books)
        {
            Books = books;
        }


        public void AddBook(Book book)
        {
            if (book != null)
            {
                Books.AddLast(book);

            }
            else
            {
                throw new Exception("You cant add empty book");
            }
        }

        public void RemoveBook()
        {
            string Title;
            Console.Write("Enter titile: ");
            Title = Console.ReadLine();
            if (isBook(Title))
            {
                Books.Remove(getBook(Title));
            }
            else
            {
                throw new Exception("Book is not in database");
            }
            
            
        }

        private Book getBook(string title)
        {
            foreach (Book book in Books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }

        private bool isBook(string Title)
        {
            foreach(Book book in Books)
            {
                if(book.Title == Title)
                {
                    return true;
                }
            }
            return false;
        }

        public void ChangeBook()
        {
            Console.WriteLine("Enter book title which  would you change");
            string title = Console.ReadLine();

            if (isBook(title))
            {
                Book book = getBook(title);
                book.Change();
            }
            else
            {
                throw new Exception("Book absent");
            }
        }

        

        private bool isParamInBook(Book book,string param)
        {
            if (book.Title == param || book.Author == param || book.Genre == param)
            {
                return true;
            }
            return false;
        }

        public void ShowBookByParam()
        {
            string sWord;
            Console.Write("Enter searched word: ");
            sWord = Console.ReadLine();

            foreach(Book bk in Books)
            {
                if(isParamInBook(bk,sWord))
                {
                    Console.WriteLine(bk);
                }
            }
        }


        public void AddBookInFirst(Book bk)
        {
            if(bk!= null)
            {
                Books.AddFirst(bk);

            }
            else
            {
                throw new Exception("Book is empty");
            }
        }

        public void AddBookInLast(Book bk)
        {
            if( bk!= null)
            {
                Books.AddLast(bk);
            }
            else
            {
                throw new Exception("Book is empty");
            }

        }

        private LinkedListNode<Book> getNode(string param)
        {
            LinkedListNode<Book> fstBook = Books.First;

            for(int i = 0; i < Books.Count; i++)
            {
                if (fstBook.Value.Title == param )
                {
                    return fstBook;
                }

                fstBook = fstBook.Next;
            }

            return null;
        }

        public void AddBookInPlace(Book bk)
        {
            string sWord;
            Console.WriteLine("Enter a name after which to insert: ");
            sWord = Console.ReadLine();

            if (isBook(sWord))
            {
                Books.AddAfter(getNode(sWord), bk);
            }
            else
            {
                Console.WriteLine($"Cant find book {sWord},so we placed Book : {bk.Title} on last position");
                AddBookInLast(bk);
            }
        }

        public void RemoveFromFirst()
        {
            if (Books.First != null)
            {
                Books.RemoveFirst();
            }
            else
            {
                throw new Exception("Database empty");
            }
        }


        public void RemoveFromLast()
        {
            if(Books.Last != null)
            {
                Books.RemoveLast();
            }
            else
            {
                throw new Exception("Database empty");
            }
        }

        public void RemoveFromPosition()
        {
            string searchedTitle;
            Console.Write("Enter searhed title: ");
            searchedTitle = Console.ReadLine();
            if(isBook(searchedTitle))
            {
                Books.Remove(getNode(searchedTitle));
            }
            else
            {
                throw new Exception("Database empty");
            }
        }


        public void ShowDatabase()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book);
                Console.WriteLine("-----------");
            }
        }


    }
}
