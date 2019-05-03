using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> employee = new List<string>();
            employee.Add("Roman");
            employee.Add("Aśka");
            employee.Add("Krzyś");
            //Console.WriteLine(employee[0]);
            employee.ForEach(a => Console.WriteLine(a));//- wyrazenie Lambda, przekazanie metody

            //Dictionary<int, Teacher> teachers = new Dictionary<int, Teacher>();
            //var teacher = new Teacher();
            //teacher.Name="Roman";
            //teachers.Add(1, new Teacher{ Name = "Aśka" });
            //teachers.Add(2, teacher);
            //teachers[1] = new Teacher { Name = "Krzyś" };
            //var a =teachers.Keys;
            //var b = teachers.Values;
            //foreach (var id in  teachers.Keys)
            //{
            //    Console.WriteLine(teachers[id].Name);
            //}
                

            //HashSet<int> hs = new HashSet<int>(); //- stosowany przy unikatowych danych. Zwraca unikatowe wartości, bez powtórzeń
            //hs.Add(2);
            //hs.Add(2);
            //hs.Add(3);
            //foreach (var item in hs)
            //{
            //    Console.WriteLine(item);
            //}

            //var stack = new Stack();
            //stack.Push("Roman");
            //stack.Push(1);
            //stack.Push(34.9);
            //while (stack.Count>0)
            //{
            //Console.WriteLine(stack.Pop());
            //}
            
            //Queue queue = new Queue();
            //queue.Enqueue("Roman");
            //queue.Enqueue(1);
            //queue.Enqueue(34.8);
            //while (queue.Count>0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            
            
            //Hashtable hTable = new Hashtable();
            //hTable.Add(1,"Roman");
            //hTable.Add("Jaś", 34);
            //object o = hTable[1];
           

            //ArrayList aList = new ArrayList(); // można dodać elementy róznych typów
            //aList.Add("Roman");
            //aList.Add(3);
            //aList.Add(34.5);
            //aList.Remove("Roman");
            //foreach (var item in aList)
            //{
            //    Console.WriteLine(item);
            //}


            // int [] tab = new int [3] { 1,20,5};
            // int x = tab.Length;
            //// Array.Sort(tab);
            // Array.Reverse(tab);
            // foreach (var item in tab)
            // {
            //     Console.WriteLine(item);
            // }

            //Employee teacher = new Teacher();
            //teacher.SetEmploymentDate(new DateTime(1990, 1, 1));
            //Console.WriteLine(teacher.EmploymentDate);

            //teacher.SetWorkingHours(9);
            //Console.WriteLine(teacher.GetWorkingHours());


            Console.Read();
        }
    }
}
