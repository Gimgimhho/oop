using System;
namespace HW2
{
    public class Person
    {
        private string name;
        private string address;
        private double salary;
        public Person(){}
        public Person(string name, string address, double salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }
        public string Name 
        {
            get => name;
            set => name = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public double Salary
        {
            get => salary;
            set => salary = value; 
        }
    }
}
