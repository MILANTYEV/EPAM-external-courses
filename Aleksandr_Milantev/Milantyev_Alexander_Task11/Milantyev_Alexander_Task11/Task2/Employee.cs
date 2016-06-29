using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Employee : User, IEquatable<Employee>
    {
        private DateTime _startWorkDate;
        private string _position;
        private double _salary;

        public DateTime StartWorkDate
        {
            get { return _startWorkDate; }
            set
            {
                if (value <= DateTime.Now)
                {
                    _startWorkDate = value;
                }
                else
                {
                    throw new Exception("Incorrect start work date");
                }
            }
        }

        public int WorkExperience
        {
            get
            {
                int experience = DateTime.Now.Year - _startWorkDate.Year;
                experience = DateTime.Now.Month > _startWorkDate.Month ? experience : experience - 1;
                return experience;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (value != "")
                {
                    _position = value;
                }
                else
                {
                    throw new Exception("Nonexistent position");
                }
            }
        }

        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negative salary's value");
                }
                _salary = value;
            }
        }

        public bool Equals(Employee other)
        {
            if (other == null)
            {
                return false;
            }
           
            bool isEqualName = this.FirstName == other.FirstName 
                && this.MiddleName == other.MiddleName
                && this.LastName == other.LastName;
            
            bool isEqualPosition = this.Position == other.Position;
            bool isEqualStartWorkDate = this.StartWorkDate == other.StartWorkDate;
            
            return isEqualName && isEqualPosition && isEqualStartWorkDate;
        }

        public override bool Equals(object other)
        {
            return Equals(other as Employee);
        }

        public bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Equals(secondEmployee);
        }

        public Employee(string firstName, string middleName, string lastName, DateTime birthDate,
            DateTime startWorkDate, string position) : base (firstName,middleName,lastName,birthDate)
        {
            if (startWorkDate > DateTime.Now || position == "")
            {
                throw new Exception("Invalid arguments");
            }
            _startWorkDate = startWorkDate;
            _position = position;
        }

        public Employee()
        {
        }
    }
}
