using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_task.Models
{
    internal class Room
    {
        private static int _id;
        public string Name;
        public double Price;
        public int PersonCapacity;
        public bool IsAviable = true;
        internal int? _Id;

        public int Id { get; }


        public Room(string name , double price, int personcapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
        }


        public override string ToString()
        {
            return Showinfo();
        }
        public string Showinfo()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price} - PersonCapacity: {PersonCapacity}";
        }
    }
}
