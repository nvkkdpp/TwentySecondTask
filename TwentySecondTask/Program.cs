using System;

namespace TwentySecondTask
{
    public class Student
    {
        public string _firstName;
        public string _lastName;

        public void InitStudent(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public static void OutputBanner()
        {
            Console.WriteLine();
            // Вот где проблема -
            // Console.WriteLine (? какой объект испопьзуется ?) ;
        }
        public void OutputBannerAndName()
        {
            OutputBanner();

            OutputName(this);
        }
        public static void OutputName(Student student)
        {
            Console.WriteLine("Имя студента - {0}", student.ToNameString());
        }
        public string ToNameString()
        {
            return this._firstName + "" + this._lastName;
        }
    }
    public class Program
    {
        //теперь я буду вести конспекты
        //нужно запонмить про статические и динамические объекты
        static void Main(string[] args)
        {
            Student student = new Student();
            student.InitStudent("Madeleine", "Cather");
            Student.OutputBanner();
            Student.OutputName(student);
            Console.WriteLine();
            //для нестатических полей\методов\свойств нужно указывать ссылку на объект
            student.OutputBannerAndName();
            Console.WriteLine("Нажмите <enter> для того чтобы пойти нахуй . . . ");
            Console.Read();
        }
    }
}
