using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    class ListOfOrder
    {
        public List<Order> orders = new List<Order>()
        {
            new Order{
            ordernum = 1,
            type = 0,
            dateOrder = new DateTime(2019,01,26),
            address = "aaaaaaaa",
            coord = "50 36.14",
            names = new List<string>
            {
                "Ivanov", "Petrov","Smerdyakov"
            }
            },

             new Order{
            ordernum = 2,
            type = 03,
            dateOrder = new DateTime(2018,12,26),
            address = "aaaaaaaa",
            coord = "49.9 36",
            names = new List<string>
            {
                "Ivanov", "Petrov"
            }
            },

             new Order{
            ordernum = 3,
            type = 2,
            dateOrder = new DateTime(2018,11,25),
            address = "aaaaaaaa",
            coord = "49.5 36.5",
            names = new List<string>
            {
                "Ivanov", "Smerdyakov"
            }
            }
        };
    }
}
