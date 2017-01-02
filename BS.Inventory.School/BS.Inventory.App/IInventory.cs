using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    interface IInventory
    {
        string iID { get; set; }
        int warrant { get; set; }
        DateTime buyDate { get; set; }
        Point largeMeter { get; set; }

    }
}
