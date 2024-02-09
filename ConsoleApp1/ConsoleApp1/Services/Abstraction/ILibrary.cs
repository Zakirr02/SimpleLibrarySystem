using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Abstraction
{
    
        interface Library {
            void AddBook(Book book);
            void AddMember(Member member);
            void DisplayBooks();
            void DisplayMembers();

        }
    
}
