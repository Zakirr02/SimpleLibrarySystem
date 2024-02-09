using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Abstraction
{
    interface Member
    {
      void BorrowBook(Book book);
       void ReturnBook(Book book);
      void DisplayDetails();
    }
    class IMember
    {
    }
}
