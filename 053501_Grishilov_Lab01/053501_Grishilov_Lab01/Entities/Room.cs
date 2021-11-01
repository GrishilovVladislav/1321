using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Grishilov_Lab01.Entities
{
    class Room
    {
        public enum RoomType
        {
            Econom,
            Standart,
            Lux
        };
        public RoomType type;
        public bool isFree;
        public int roomNumber;
        Client client;
        public Room(int num)
        {
            
            isFree = true;
            if (num > 0 && num <21)
            {
                type = RoomType.Econom;
                roomNumber = num;
            }
            if (num > 20 && num < 41)
            {
                type = RoomType.Standart;
                roomNumber = num;
            }
            if (num > 40 && num < 51)
            {
                type = RoomType.Lux;
                roomNumber = num;
            }
            else
            {
                //exeption
            }
            client = new Client("None", 0);

        }
    }
}
