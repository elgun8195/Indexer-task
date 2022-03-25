using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_task.Models
{
    internal class Hotel
    {
        public string Name;
        private Room[] Rooms;



        public Hotel(string name)
        {
            Name = name;
        }
        public void AddRoom(Room[] room)
        {
            Array.Resize(ref Rooms, room.Length+1);
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                foreach (var item in Rooms)
                {
                    if (item._Id==roomId)
                    {
                        item.IsAviable = true;
                    }
                    else
                    {

                    }

                }
            }
        }


    }
}
