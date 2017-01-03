using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    class Classroom {
        public Classroom(string name, Point largeMeter, double teacherSpace) {
            this.name = name;
            this.largeMeter = largeMeter;
            this.teacherSpace = teacherSpace;
            this.studentTableList = new List<StudentTable>();
            this.seatList = new List<Seat>();
        } 
          
        public string name { get; set; }
        public double teacherSpace { get; set; }
        public int studentCapacity { get; set; }
        public int chairCapacity { get; protected set; }
        //public string seatAndChairType { get; set; }
        public TeacherTable teacherTable;
        public List<StudentTable> studentTableList;
        public List<Seat> seatList;
        public StudentTable studentTable { get; set; }
        public Seat seat { get; set; }


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


        protected void setMaximumCapaity() {
            this.chairCapacity = 0;
        }



    }
}