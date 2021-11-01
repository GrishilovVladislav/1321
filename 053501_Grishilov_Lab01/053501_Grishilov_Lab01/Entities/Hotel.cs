using System;
using System.Collections.Generic;
using System.Text;

using _053501_Grishilov_Lab01.Collections;

namespace _053501_Grishilov_Lab01.Entities
{
    class Hotel
    {
        int MaxEconom = 20;
        int MaxStandart = 20;
        int MaxLux = 10;

        int FreeEconom = 20;
        int FreeStandart = 20;
        int FreeLux = 10;

        MyCustomCollection<Client> ClientList = new MyCustomCollection<Client>();
        MyCustomCollection<Room> RoomList = new MyCustomCollection<Room>();

        public void CostInfo()
        {
            Console.WriteLine("================================================================== ");
            Console.WriteLine("Стоимость номеров: \n");
            Console.WriteLine("-Эконом(1-20) 100 рублей за ночь ");
            Console.WriteLine("-Стандарт(21-40) 200 рублей за ночь ");
            Console.WriteLine("-Люкс(41-50) 400 рублей за ночь ");
            Console.WriteLine("================================================================== \n");
        }

        public void RoomsInfo()
        {
            Console.WriteLine("================================================================== ");
            Console.WriteLine("Количество свободных номеров: \n");
            Console.WriteLine("-Эконом: "+ FreeEconom );
            Console.WriteLine("-Стандарт: " + FreeStandart);
            Console.WriteLine("-Люкс: " + FreeLux );
            Console.WriteLine("================================================================== ");
        }

        public Hotel()
        {
            for(int i = 0; i < 50; i++)
            {
                RoomList.Add(new Room(i));
            }
        }

        public void ShowInfoAboutRoom(int num)
        {
            Console.WriteLine("================================================================== ");
            Console.WriteLine("Номер комнаты: " + RoomList[num].roomNumber + 1);
            Console.WriteLine(RoomList[num].isFree);
            Console.WriteLine(RoomList[num].type);
            Console.WriteLine("================================================================== ");

        }
        public void ShowInfoAboutAllRooms()
        {
            for (int i = 0; i < 50; i++)
            {
                ShowInfoAboutRoom(i);
            }
        }
        public void AddClient()
        {
            
        }


    }
}
