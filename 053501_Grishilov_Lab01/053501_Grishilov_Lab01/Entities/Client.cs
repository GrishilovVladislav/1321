using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Grishilov_Lab01.Entities
{
    class Client
    {
        string name;
        int daysOfStanding;
        public Client(string n, int d)
        {
            name = n;
            daysOfStanding = d;
        }
        public Client(string n)
        {
            name = n;
            daysOfStanding = 1;
        }
    }
}
