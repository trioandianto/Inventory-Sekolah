using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Inventory.App
{
    class TeacherTable : Table
    {
        protected const string suffixID = "TCH";
        public TeacherTable(int iID, char iconString = '=') : base(iID, iconString) {
            this.iID = string.Concat(this.iID, suffixID);
        }
    }
}
