using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    class Program
    {
        static void Main(string[] args) {            


        }

        public static List<TeacherTable> getTeacherTableDummy() {
            List<TeacherTable> teacherTableDummies = new List<TeacherTable>();

            // 3 Teacher table
            TeacherTable newTeacherTable = new TeacherTable(1, "Meja Standar", new Point(1.5, 0.7));
            teacherTableDummies.Add(newTeacherTable);

            newTeacherTable = new TeacherTable(2, "Meja Standar", new Point(1.5, 0.7));
            teacherTableDummies.Add(newTeacherTable);
            
            return teacherTableDummies;
        }

        public static List<StudentTable> getStudentTableDummy() {
            List<StudentTable> studentTableDummies = new List<StudentTable>();

            // 15 Student Table
            StudentTable newStudentTable = new StudentTable(1,"Maulana",new Point(0.7,0.7));
            studentTableDummies.Add(newStudentTable);

            newStudentTable = new StudentTable(1, "Trio", new Point(0.7, 0.7));
            studentTableDummies.Add(newStudentTable);

            newStudentTable = new StudentTable(1, "Kiki", new Point(0.7, 0.7));
            studentTableDummies.Add(newStudentTable);

            newStudentTable = new StudentTable(1, "Satria", new Point(0.7, 0.7));
            studentTableDummies.Add(newStudentTable);

            newStudentTable = new StudentTable(1, "Ucu", new Point(0.7, 0.7));
            studentTableDummies.Add(newStudentTable);

            newStudentTable = new StudentTable(1, "Sofy", new Point(0.7, 0.7));
            studentTableDummies.Add(newStudentTable);

            newStudentTable = new StudentTable(1, "Tiara", new Point(0.7, 0.7));
            studentTableDummies.Add(newStudentTable);

            newStudentTable = new StudentTable(1, "Dhany", new Point(0.7, 0.7));
            studentTableDummies.Add(newStudentTable);


            return studentTableDummies;
        }

    }
}
