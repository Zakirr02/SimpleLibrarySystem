using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Library
    {
        public List<Book> Book { get; set; }= new List<Book>();
        public List<Member> Member { get; set; } = new List<Member>();
        
        public void AddBook(Book book) {
            Console.WriteLine($"{book.Title} Book added");
            Book.Add(book);
        }

        public void AddMember(Member member) {
            Member.Add(member);
            Console.WriteLine($"{member.NameofMember} member added");
        }
        public void DisplayInventory() {
            for (int i = 0; i < Member.Count; i++) {
                Console.WriteLine($"{Member[i].NameofMember} - {Book[i].Title}");
            }
        }
       


 

    }
}
