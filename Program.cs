using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Jesey";
            s1.Id = "19399791";
            s1.Department = "CSE";
            s1.Cgpa = "float 2f";

            Student s2 = new Student("Rakhi", "18345612", "EEE");
            Student s3 = new Student("Karim", "19567872", "CSE");

            s1.showInfo();

            Book b1 = new Book("Echoes", "ernest", "2444", "fiction", 3);
            Book b2 = new Book("Start again", "seanan", "5235", "romantic", 5);
            Book b3 = new Book("Dark alarms", "ernest", "6264", "fantasy", 2);
            Book b4 = new Book("Perfectly fake", "vladimir", "2345", "Horror", 4);
            Book b5 = new Book("East of eden", "john", "4562", "novel", 3);
            Book b6 = new Book("Vile bodies", "evelyn", "2123", "novel", 2);


            s1.BorrowedBook = new Book[] { b1, b2 };
            s2.BorrowedBook = new Book[] { b3, b4, b5 };
            s3.BorrowedBook = new Book[] { b2, b6 };
            s1.BorrowedBookCount = borrowedBook.Length;

            s1.showBorrowedBookInfo();

            Library library = new Library("Bichitra", "Katalgonj", new Book[] { b1, b2, b3, b4, b5, b6 }, 6);

        }
    }
}
