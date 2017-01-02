using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    class TeacherTable : Table
    {
        protected const string suffixID = "TCH";
        public TeacherTable(int iID, string name, Point largeMeter, char iconString = '=') : base(iID, name, largeMeter, iconString) {
            this.iID = string.Concat(this.iID, suffixID);
        }
    }
}
