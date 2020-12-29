using System;
using System.Collections.Generic;
using System.Text;

namespace YoYo_Entities
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool warn { get; set; }
        public bool stop { get; set; }
        public int levelNumber { get; set; }
        public int shuttleNumber { get; set; }
    }
}
