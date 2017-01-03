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
            int menuNumber;
            List<Classroom> classroomMaster = new List<Classroom>();
            List<StudentTable> studentTableMaster = new List<StudentTable>();
            List<Seat> seatMaster = new List<Seat>();
            Classroom tempClassroom = null;

            Console.WriteLine("/*************************************************************");
            Console.WriteLine("********* Welcome to the elementary inventory console ********");
            Console.WriteLine("*************************************************************/");
            Console.WriteLine();

            // Hardcode
            studentTableMaster.Add(getStudentTableDummy());

            Console.WriteLine("==============================================================");
            Console.WriteLine("Pilihan menu");
            Console.WriteLine("1. Entry kelas baru");
            Console.WriteLine("2. Daftar kelas");
            Console.WriteLine("3. Entry inventaris baru");
            Console.WriteLine("4. Daftar inventaris baru");
            Console.WriteLine("==============================================================");
            Console.Write("Input nomor menu: ");
            menuNumber = getIntInput();

            if(menuNumber == 1) {
                Console.Clear();
                tempClassroom = null;
                tempClassroom = EntryNewClass();
                if(tempClassroom != null) {
                    classroomMaster.Add(tempClassroom);
                }
                EditClass(tempClassroom.name, classroomMaster, studentTableMaster, seatMaster);
            }

        }

        public static Classroom EntryNewClass() {
            Classroom newClassroom = null;
            string name;
            double pointX;
            double pointY;
            double teacherSpace;
            double pointDummy;

            Console.WriteLine("Entry kelas baru");
            Console.WriteLine("==============================================================");
            Console.Write("Input nama kelas: ");
            name = getStringInput();

            Console.Write("Input panjang kelas (meter): ");
            pointY = getDoubleInput();

            Console.Write("Input lebar kelas (meter): ");
            pointX = getDoubleInput();

            if(pointY < pointX) {
                pointDummy = pointY;
                pointY = pointX;
                pointX = pointDummy;
            }

            Console.Write("Input daerah guru (meter): ");
            teacherSpace = getDoubleInput();


            newClassroom = new Classroom(name, new Point(pointX, pointY), teacherSpace);
            return newClassroom;

        }

        public static void ListClass() {

        }

        public static void EditClass() {

        }

        public static void EditClass(string name, List<Classroom> classroom, List<StudentTable> studentTable, List<Seat> seat) {
            Classroom currClassroom = classroom.Find(item => item.name == name);
            StudentTable currStudentTable;
            Seat currSeat;

            int maxColumn;
            int maxRow;
            int maxCapacity;

            int tableCount;
            int seatCount;            

            if (studentTable.Count != 0 || seat.Count != 0) {
                if (currClassroom != null) {
                    // Mencari meja yang akan digunakan
                    Console.WriteLine("Input nama meja dari daftar berikut:");
                    foreach(StudentTable item in studentTable) {
                        Console.WriteLine(item.name);
                    }
                    currStudentTable = studentTable.Find(item => item.name.Equals(getStringInput(), StringComparison.InvariantCultureIgnoreCase));
                    while (currStudentTable == null) {
                        Console.WriteLine("meja tidak ditemukan, input kembali sesuai daftar");
                        currStudentTable = studentTable.Find(item => item.name.Equals(getStringInput(), StringComparison.InvariantCultureIgnoreCase));
                    }

                    //Mencari kursi yang akan digunakan
                    Console.WriteLine("Input nama kursi dari daftar berikut:");
                    foreach (Seat item in seat) {
                        Console.WriteLine(item.name);
                    }
                    currSeat = seat.Find(item => item.name.Equals(getStringInput(), StringComparison.InvariantCultureIgnoreCase));
                    while (currSeat == null) {
                        Console.WriteLine("meja tidak ditemukan, input kembali sesuai daftar");
                        currSeat = seat.Find(item => item.name.Equals(getStringInput(), StringComparison.InvariantCultureIgnoreCase));
                    }

                    maxColumn = CalcMaxColumn(currClassroom, currStudentTable);
                    maxRow = CalcMaxRow(currClassroom, currStudentTable, currSeat);
                    maxCapacity = CalcMaximumCapacity(maxColumn, maxRow, currStudentTable.chairSlot);

                    Console.WriteLine("==============================================================");
                    Console.WriteLine(String.Format("Kelas {0}", currClassroom.name));
                    Console.WriteLine("============= Kapasitas Maksimal =============================");
                    Console.WriteLine(String.Format("murid \t = {0}", maxCapacity));
                    Console.WriteLine(String.Format("meja  \t = {0}", maxRow * maxColumn));
                    Console.WriteLine(String.Format("kursi \t = {0}", maxCapacity));
                    Console.WriteLine("============= Kapasitas Aktual ===============================");
                    Console.WriteLine(String.Format("murid \t = {0}", 0));
                    Console.WriteLine(String.Format("meja  \t = {0}", maxRow * maxColumn));
                    Console.WriteLine(String.Format("kursi \t = {0}", maxCapacity));
                    Console.WriteLine("==============================================================");
                    Console.Write("Input jumlah meja yang akan di assign: ");
                    tableCount = getIntInput();
                    Console.Write("Input jumlah kursi yang akan di assign: ");
                    seatCount = getIntInput();

                    drawClass(currClassroom, maxColumn, maxRow, currStudentTable.chairSlot);

                } else {
                    Console.WriteLine("Kelas tidak ditemukan");
                }
            }
        }

        public static void drawClass(Classroom classroom, int maxColumn, int maxRow, int tableSeatSlot) {
            int maxX = maxColumn * (tableSeatSlot + 2);
            int maxY = maxRow * 2;
            int teacherSpace = 3;

            for(int i = 1; i <= maxX + 2; i++) {
                if(i == maxX + 2) {
                    Console.WriteLine("-");                    
                } else {
                    Console.Write("-");
                }
            }

            for (int i = 1; i <= teacherSpace; i++) {
                if (i == teacherSpace) {
                    Console.WriteLine("-");
                } else if(i == 1){
                    Console.Write("-");
                }
            }

            for (int i = 1; i <= maxY; i++) {
                for (int j = 1; j <= maxX + 2; j++) {
                    int tableInstance = tableSeatSlot + 2;
                    if (1 == i % 2) {

                    } else {

                    }
                }

            }

        }

        public static int CalcMaximumCapacity(int maxColumn, int maxRow, int tableSeatSlot) {
            return maxColumn * maxRow * tableSeatSlot;

        }

        public static int CalcMaxColumn(Classroom classroom, StudentTable studentTable) {
            double maxLong = studentTable.largeMeter.X + 0.5;
            double classWidth = classroom.largeMeter.X;

            return (int)Math.Floor(classWidth / maxLong);

        }        

        public static int CalcMaxRow(Classroom classroom, StudentTable studentTable, Seat seat) {
            double maxWidth = studentTable.largeMeter.Y + seat.largeMeter.Y;
            double classLong = classroom.largeMeter.Y - classroom.teacherSpace;

            return (int)Math.Floor(classLong / maxWidth);
        }


        public static TeacherTable getTeacherTableDummy() {
            List<TeacherTable> teacherTableDummies = new List<TeacherTable>();

            // 3 Teacher table
            TeacherTable newTeacherTable = new TeacherTable(1, "Meja guru kayu", new Point(1.5, 0.7));
            newTeacherTable.itemCount = 3;
            teacherTableDummies.Add(newTeacherTable);

            //newTeacherTable = new TeacherTable(2, "Meja Standar", new Point(1.5, 0.7));
            //teacherTableDummies.Add(newTeacherTable);
            
            return newTeacherTable;
        }

        public static StudentTable getStudentTableDummy() {
            List<StudentTable> studentTableDummies = new List<StudentTable>();

            // 15 Student Table
            StudentTable newStudentTable = new StudentTable(1, "Meja murid kayu", new Point(1.5, 0.7));
            newStudentTable.itemCount = 10;
            newStudentTable.chairSlot = 2;

            return newStudentTable;
        }

        public static Seat getSeatDummy() {

            Seat newStudentTable = new Seat(1, "Kursi murid kayu", new Point(0.4, 0.5));
            newStudentTable.itemCount = 20;            

            return newStudentTable;
        }


        private static string getStringInput() {
            string stringInput = Console.ReadLine();
            while (string.IsNullOrEmpty(stringInput)) {
                Console.WriteLine("Ulangi input anda:");
                stringInput = Console.ReadLine();
            };


            return stringInput;
        }

        private static int getIntInput() {
            string intInput = Console.ReadLine();
            int convertedInput;
            while (string.IsNullOrEmpty(intInput)) {
                Console.WriteLine("Ulangi input anda");
                intInput = Console.ReadLine();
            };
            while (!Int32.TryParse(intInput, out convertedInput)) {
                Console.WriteLine("Input bukan angka. Ulangi input anda");
                intInput = Console.ReadLine();
            };

            //return Convert.ToInt32(intInput);
            return convertedInput;
        }

        private static double getDoubleInput() {
            string intInput = Console.ReadLine();
            double convertedInput;
            while (string.IsNullOrEmpty(intInput)) {
                Console.WriteLine("Ulangi input anda");
                intInput = Console.ReadLine();
            };
            while (!double.TryParse(intInput, out convertedInput)) {
                Console.WriteLine("Input bukan angka. Ulangi input anda");
                intInput = Console.ReadLine();
            };

            //return Convert.ToInt32(intInput);
            return convertedInput;
        }

        //private static int getDisciplineInput() {
        //    int disciplineInt = getIntInput();
        //    while (!Enum.IsDefined(typeof(DisciplineType), disciplineInt)) {
        //        disciplineInt = getIntInput();
        //        Console.WriteLine("Discipline is not defined. Please insert again");
        //    }
        //    return disciplineInt;
        //}

    }
}
