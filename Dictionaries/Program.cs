using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }


        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }



    internal class Dictionary
    {
        public static void Main(string[] args)
        {
            // Declaring and initializing a dictionary
            /*Dictionary<int, string> Dic = new Dictionary<int, string>();

            Dic.Add(1, "dkfd");
            Dic.Add(2, "dkfd");
            Dic.Add(3, "dkfd");

            string name = Dic[1];

            //updating a dictionary value
            Dic[1] = "Behjamin";

            Console.WriteLine(Dic[1]);


            if(!Dic.ContainsKey(4))
            {
                Dic.Add(4, "daddy");
            }

            bool condition = Dic.TryAdd(4, "dd");
            Console.WriteLine(condition);

            foreach (KeyValuePair<int, string> dic in Dic)
            {
                Console.WriteLine($"Key {dic.Key}: Value {dic.Value} ");
            }*/

            Dictionary<int, Employee> employee = new Dictionary<int, Employee>();

            employee.Add(1, new Employee(name: "Benjmain", age: 34, salary: 2300));
            employee.Add(2, new Employee(name: "Benjmain", age: 34, salary: 2300));
            employee.Add(3, new Employee(name: "Benjmain", age: 34, salary: 2300));
            employee.Add(4, new Employee(name: "Benjmain", age: 34, salary: 2300));
            employee.Add(5, new Employee(name: "Benjmain", age: 34, salary: 2300));

            foreach(KeyValuePair<int, Employee> emp in employee )
            {
                Console.WriteLine($"Key {emp.Key}, Name: {emp.Value.Name}");
            }

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "ddff",
                ["KM"] = "Dfdf",
            };

            if(codes.TryGetValue("KM", out string states)){
                Console.WriteLine(states);
            }
            
            foreach(KeyValuePair<string, string> kvp in codes)
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value.Length}");
            }

            Console.ReadKey();
        }
    }
}
