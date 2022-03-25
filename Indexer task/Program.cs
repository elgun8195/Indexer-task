using System;
using Indexer_task.Models;
namespace Indexer_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room otaq = new Room("Otaq1",35,4);
            Room otaq1 = new Room("Otaq2", 35, 4);
            Hotel hotel = new Hotel("Hotel_room1");
            otaq.Showinfo();
            otaq1.Showinfo();

        }
    }
}
