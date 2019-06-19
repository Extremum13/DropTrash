using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    public class User
    {
        public string Username { get; set; }

        public string FIO { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        List<Order> orders;
    }
}
