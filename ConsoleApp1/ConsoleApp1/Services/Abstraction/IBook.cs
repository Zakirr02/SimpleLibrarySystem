using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Abstraction
{
   
        interface Book
        {
            void BorrowBook(Member member);
             void ReturnBook(Member member);
            void DisplayDetails();
        }
    
}
