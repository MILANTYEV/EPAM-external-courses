using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private const int MAX_AGE = 150;
        
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private int _id;
        
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Negative or null ID");
                }
                else
                {
                    _id = value;
                }
            }
        }

        public List<Prize> PrizesList { get; private set; }

        public string Prizes 
        {
            get
            {
                if (PrizesList.Count == 0)
                {
                    return "";
                }
                if (PrizesList.Count == 1)
                {
                    return PrizesList[0].Title;
                }
                else
                {
                    StringBuilder titles = new StringBuilder("");
                    foreach (var prize in PrizesList)
                    {
                        titles.Append(prize.Title);
                        if (PrizesList.IndexOf(prize) != PrizesList.Count - 1)
                        {
                            titles.Append(", ");
                        }
                    }
                    return titles.ToString(); ;
                }
            }
        }
        
        public string FirstName
        { 
            get
            {
                return _firstName;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("invalid name");
                }
                _firstName = value;
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
                if (value == null || value == "")
                {
                    throw new ArgumentException("Invalid name");
                }
                _lastName = value;
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
                if (value > DateTime.Now || (DateTime.Now.Year - value.Year) > MAX_AGE)
                {
                    throw new ArgumentException("Invalid birthdate");
                }
                _birthDate = value;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - _birthDate.Year;
                if (DateTime.Now.Month < _birthDate.Month || 
                    (DateTime.Now.Month == _birthDate.Month && DateTime.Now.Day < _birthDate.Day))
                {
                    age -= 1;
                }
                return age;
            }
        }
        
        public User(int id, string firstName, string lastName, DateTime birthDate)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            PrizesList = new List<Prize>();
        }

        public void AddPrize(Prize prize)
        {
            if (prize == null)
            {
                throw new ArgumentException("Null prize-reference");
            }
            PrizesList.Add(prize);
        }
    }
}
