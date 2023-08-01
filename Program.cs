using System;

namespace Phase1Section5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {

            Teacher teacher = new Teacher();
            teacher.Name = "Mr.Ravi";
            teacher.Address = "Noida";
            teacher.DateOfJoining = DateTime.Today;

            Student student = new Student();
            student.Name = "harshit";
            student.Address = "greater noida";
            student.DateOfJoining = DateTime.Today;

            OfficeStaff staff = new OfficeStaff();
            staff.Name = "Mr.Navneet";
            staff.Address = "Anand Vihar";
            staff.DateOfJoining = DateTime.Today;


            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
        }
    }
}
