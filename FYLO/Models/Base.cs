using System;
using System.Collections.Generic;

namespace FYLO.Models
{
    public class Base
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public List<File> files { get; set; }
    }
}

