using System;
using System.Collections.Generic;
using System.Linq;

namespace Lap1
{
    class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public float AverageScore
        {
            get
            {
                return averageScore;
            }
            set
            {
                averageScore = value;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
        public Student()
        {

        }
        public Student(string ID, string name, float score, string faculty)
        {
            StudentID = ID;
            FullName = name;
            AverageScore = score;
            Faculty = faculty;
        }
        public void Input()
        {
            Console.Write("Your ID Student: ");
            StudentID = Console.ReadLine();
            Console.Write(" Your Student Name: ");
            FullName = Console.ReadLine();
            Console.Write("Your ave Score: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Input faculty: ");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("ID Student:{0} Student Name:{1} fanculty:{2} Ave Score:{3}", this.StudentID, this.FullName, this.Faculty, this.AverageScore);

        }
        static void Main(string[] args)
        {
            // Console.OutputEncoding = System.Text.Encoding.ASCII;
            // Console.InputEncoding = System.Text.Encoding.ASCII;
            // Console.Write(" input all student N = ");
            // int N = Convert.ToInt32(Console.ReadLine());
            // Student[] arrStudent = new Student[N];
            // Console.WriteLine("\n ==== Input your student list ====");
            // for (int i=0; i < N; i++)
            //  {
            // Console.WriteLine("\n - input student {0}", i + 1);
            // arrStudent[i] = new Student();
            //arrStudent[i].Input();

            //  }
            //Console.WriteLine("\n ==== output your student list ====");
            //foreach (Student sv in arrStudent )
            // {
            // sv.Show();
            //  }
            // Console.ReadKey();

            // }
            // }
            // }
            List<Student> students = new List<Student>();
            List<Student> LStudent = new List<Student>();
            LStudent.Add(new Student("SV01", "Nguyen van toan", 5, "QTKD"));
            LStudent.Add(new Student("SV02", "Nguyen van di", 3, "CNTT"));
            LStudent.Add(new Student("SV03", "Tran van buu", 8, "KT"));
            LStudent.Add(new Student("SV04", "Huynh van banh", 7, "QTKD"));
            LStudent.Add(new Student("SV05", "Bui thi nga", 10, "CNTT"));
            LStudent.Add(new Student("SV06", "Dao van kien", 7, "CNTT"));
            LStudent.Add(new Student("SV07", "Bach van thang", 5, "QTKD"));
            LStudent.Add(new Student("SV08", "Tran thi thuy", 2, "KT"));
            Console.WriteLine("\n======1.1======");
            var CNTTStudents = LStudent.FindAll(x => x.Faculty == "CNTT");
            OutputList(CNTTStudents);
            Console.WriteLine("\n======1.2======");
            var HighScoreStudent = LStudent.FindAll(x => x.AverageScore >= 5);
            OutputList(HighScoreStudent);
            Console.WriteLine("\n======1.3======");
            List<Student> StudentSort = LStudent.OrderBy(x => x.AverageScore).ToList();
            OutputList(StudentSort);
            Console.WriteLine("\n======1.4======");
            var HighScoreCNTT = LStudent.FindAll(x => x.AverageScore >= 5);
            HighScoreCNTT = HighScoreCNTT.FindAll(x => x.Faculty == "CNTT");
            OutputList(HighScoreCNTT);
            Console.WriteLine("\n======1.5======");
            var Max = LStudent.FindAll(x => x.AverageScore == LStudent.Max(y => y.AverageScore));
            var HighestCNTT = Max.FindAll(x => x.Faculty == "CNTT");
            OutputList(HighScoreCNTT);


        }

        private static void OutputList(List<Student>LStudent)
        {
            foreach (Student item in LStudent)
                item.Show();
        }
    }
}