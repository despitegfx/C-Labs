using System;



namespace Mymain
{
    class MainMy{

        public static void Main(string[] args){

            Console.WriteLine("Enter number of students: ");

            int takeInput = int.Parse(Console.ReadLine());

            Student[] student = new Student[takeInput];

            //string[] Student = {"Emmanuel Bonsu", "Maths", "Advance", "70%", "Turntabl", "A+"}; 

            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student("Emmanuel Bonsu0","Maths", "Advance", "70%", "Turntabl", "A+");
            }

            foreach (var studentItem in student)
            {
                Console.WriteLine(studentItem.getname());
            }

        }

    }
    
}