using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Web_App.Models;

namespace YoYo_Web_App.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Player> players { get; set; }
    }
}
