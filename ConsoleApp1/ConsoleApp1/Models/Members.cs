using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Models
{
    public class Member
    {
        public void BorrowBook(Book book) {
            if (FinesOwed == true)
            {
                Console.WriteLine("Siz artiq kitab almisiniz,qaytarin sonra gelib yenisini goturersiz");
            }
            else if (book.CopiesAvailable == true)
            {
                Console.WriteLine("Kitab movcuddur.Goture bilersiniz");
                FinesOwed = false;
                book.CopiesAvailable = false;



            }
            else Console.WriteLine("Teessuff bu kitab elcatan deyil");
            }
        
        public void ReturnBook(Book book)
        {
            if(FinesOwed == true)
            {
                Console.WriteLine("Sizin qaytarmali oldugunuz kitab yoxdur");}
            else
            {
                FinesOwed = false;
                Console.WriteLine("Kitab ugurla geri qaytarildi.Artiq yeni kitab elde ede bilersiz");
                book.CopiesAvailable = true;


            }
        }
        public void DisplayDetails() {
            Console.WriteLine($"{NameofMember}");
            Console.WriteLine($"{FinesOwed}");

        }

        public string NameofMember { get; set; }
        public bool FinesOwed { get; set; }
    }
}
