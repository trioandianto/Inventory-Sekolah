using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    class Classroom {
        public string name { get; set; }
        public decimal teacherSpace { get; set; }
        public int studentCapacity { get; set; }
        //public string seatAndChairType { get; set; }
        public TeacherTable teacherTable;
        public StudentTable[] studentTables;
        public int maximumCapacity; 


        private Point _largeMeter;
        public Point largeMeter {
            get
            {
                return this._largeMeter;
            }
            set
            {   
                value.X = Math.Round(value.X, 1);
                value.Y = Math.Round(value.Y, 1);
                this._largeMeter = value;
            } }

    }
}
