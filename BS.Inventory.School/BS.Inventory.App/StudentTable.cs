using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    class StudentTable : Table
    {
        protected const string suffixID = "STD";
        public StudentTable(int iID, string name, Point largeMeter, char iconString = '=') : base(iID, name, largeMeter, iconString) {
            this.iID = string.Concat(this.iID, suffixID);
        }


    }
}
