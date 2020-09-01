using System;
using System.Collections.Generic;

namespace LearningCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a new Student Class object
            var students = new List<Student>();
            //to access the Name property, specify the object variable name
            //use the dot operator after specifying the object variable name
            //to access the Name property


            //boolean that means in this while loop, all code will
            //continue to happen in it until reaching a false condition
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Student Name...");
                newStudent.Name = (Console.ReadLine());

                Console.Write("Student Grade...");
                newStudent.Grade = (int.Parse(Console.ReadLine()));

                Console.Write("Student Birthday...");
                newStudent.Birthday = (Console.ReadLine());

                Console.Write("Student Address...");
                newStudent.Address = (Console.ReadLine());

                //data type for phone# (and grade) in Class property is int
                Console.Write("Student Phone...");
                //phone number is set and kept private through 'private' access
                //specifier and public void method 'SetPhone'

                //newStudent.SetPhone(int.Parse(Console.ReadLine()));
                //using Phone setter
                newStudent.Phone = (int.Parse(Console.ReadLine()));


                //add a newStudent to the List <Student> collection
                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count is: {0}", Student.Count);

                Console.Write("Add another student? y/n");

                if (Console.ReadLine() != "y")
                {
                    //break out of while loop because we flip the
                    //boolean and adding arg to false once "y" typed
                    adding = false;
                }

                foreach (var student in students)
                {
                    //Name is obj arg 0 as string(student.Name), and Grade is obj arg 1 as int(student.Grade)
                    //parameters arr[i] lists the data from the loop
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                    //workin with namespaces tomorrow;util classes
                }
            }
        }

    }
    class Student
    {
        //Count will be independent of instantiated Student
        //Count will not rely on each specific Student
        public static int Count;

        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        //encapsulation
        //accessability of specifier
        //common practice to use first letter of variable name 
        //lower case to indicate 'private'
        private int phone;

        public void SetPhone(int number)
        {
            phone = number;
        }
        //C# property
        //instead of passing paramter through method
        //setter can be used to declare value of phone
        public int Phone
        {
            //use a standard '=' to assign the phone number
            //like we would for a variable
            set { phone = value; Console.WriteLine(phone); }
        }

    }
}

