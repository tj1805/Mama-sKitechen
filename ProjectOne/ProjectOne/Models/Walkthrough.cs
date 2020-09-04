using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Models
{
    public class Walkthrough
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
        public  decimal ItemPrice { get; set; }
        public string Description { get; set; }
    }
}
