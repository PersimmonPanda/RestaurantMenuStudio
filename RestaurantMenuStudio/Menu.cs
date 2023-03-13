using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantMenuStudio;

namespace RestaurantMenuStudio
{

    public class Menu
    {
        public List<MenuItems> Items { get; set; }
        DateTime ADate { get; set; }

        public Menu(DateTime aDate, List<MenuItems> items)
        {
            Items = items;
            ADate = aDate;
        }
    }
}
