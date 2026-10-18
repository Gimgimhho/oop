using System;
namespace HW2 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("---Person programer---")
            Person[] persons = new Person[3];
            for (int i = 0; 1 < persons.Lenght; i++ )
            {
                Console.WriteLine("Input Person");
                Console.WriteLine("Input Name: ")
                string name = Console.ReadLine();
                Console.WriteLine("Input Address: ")
                string address = Console.ReadLine();
            // nhập lại nếu không hợp lệ 
                while (true)
                {
                    Console.Write("Please input salary: ")
                    string sSalary = Consnsole.ReadLine();
                    try
                    {
                        persons[i] = inputPersonInfo(name, address, sSalary);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            try
            {
                persons = sortBySalary(persons);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            foreach (Person person in persons)
            {
                displayPersonInfo(person);
            }
            Console.ReadKey();
        }   
        public static Person inputPersonInfo(string name, string address, string sSalary)
        {
            if (string.IsNullOrWhiteSpace(sSalary))
            {
                throw new Exception("You must input Salary.");
            }
            if (!double.TryParse(sSalary, out double salary))
            {
                throw new Exception("You must input digidt.");
            }
            if (salary <= 0)
            {
                throw new Exception("Salary is greater than zero");
            }
            return new Person(name, address, salary);
        }
        public static void displayPersonInfo(Person person)
        {
            Console.WriteLine("Infformation of Person ");
            Console.WriteLine($"Name: {person.Name}");
            Console.WhileLine($"Address:{person.Address}");
            Console.WhileLine($"Salary:{person.Salary}");
            Console.WriteLine();
        }
        public static Person[] sortBySalary(Person[] person)
        {
            if (person == null || person.Lenght == 0)
            {
                throw new Expention("Can't Sort Person");
            }
            // sắp xếp theo lương (thuật toán bubble sort)
            
        int n = person.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (person[j].Salary > person[j + 1].Salary)
                    {
                        // Hoán đổi vị trí
                        Person temp = person[j];
                        person[j] = person[j + 1];
                        person[j + 1] = temp;
                    }
                }
            }
            return person;
        }
    }
}
