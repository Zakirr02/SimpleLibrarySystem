using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Library library = new Library();
            
            Book book1 = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Fiction",
                PublicationYear = 1925,
                CopiesAvailable = true
            };

            Book book2 = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                PublicationYear = 1960,
                CopiesAvailable = true
            };

            Member member1 = new Member
            {
                NameofMember = "John Doe",
                FinesOwed = false
            };

            Member member2 = new Member
            {
                NameofMember = "Jane Smith",
                FinesOwed = false
            };

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddMember(member1);
            library.AddMember(member2);

            // Borrowing books
            member1.BorrowBook(book1);
            member2.BorrowBook(book2);
            member1.BorrowBook(book2); // Trying to borrow an already borrowed book

            // Returning books
            member1.ReturnBook(book1);
            member2.ReturnBook(book2);
            member2.BorrowBook(book2);

            // Displaying library inventory and members
            library.DisplayInventory();
            
        }
    }
}
