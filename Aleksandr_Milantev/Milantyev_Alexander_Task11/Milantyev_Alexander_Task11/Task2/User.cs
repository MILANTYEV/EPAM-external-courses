using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class User
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthDate;
        
        public string FirstName
        { 
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value == null ? "" : value;
            }
        }

        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value == null ? "" : value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value == null ? "" : value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value <= DateTime.Now ? value : DateTime.Now;
            }
        }

        public int Age { get; private set; }

        public User(string firstName, string middleName, string lastName, DateTime birthDate)
        {
             FirstName = firstName == null ? "" : firstName;
            _middleName = middleName == null ? "" : middleName;
            _lastName = lastName == null ? "" : lastName;
            _birthDate = birthDate <= DateTime.Now ? birthDate : DateTime.Now;
            Age = DateTime.Now.Year - _birthDate.Year;
            Age = DateTime.Now.Month < _birthDate.Month ? (Age - 1) : Age;
        }

        public User()
        {

        }
    }
}
