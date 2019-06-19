using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{
    public class Order
    {
        public int ordernum { get; set; }
        public int type { get; set; }
        public DateTime dateOrder { get; set; }
        public string address  { get; set; }
        public string coord  { get; set; }
        public List<string> names { get; set; }
    }
}
