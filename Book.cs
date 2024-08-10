using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TheLibrary
{
    public class Book
    {
        public int Id;
        public string Name;

        public Book(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }
    }
}