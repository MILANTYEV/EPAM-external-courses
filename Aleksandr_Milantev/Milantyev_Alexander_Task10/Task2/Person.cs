using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value == "")
                {
                    throw new Exception("Empty name");
                }
                _name = value;
            }
        }

        public Person(string name)
        {
            Name = name;
        }

        public void SayGoodbye(Person person)
        {
            Console.WriteLine("\n'Goodbye,{0}', say {1}", person.Name, this.Name);
        }

        public void Greet(Person person, DateTime comingTime)
        {
            DateTime afternoonStart = new DateTime(1,1,1,12,0,0);
            DateTime afternoonEnd = new DateTime(1,1,1,17,0,0);
            string greeting = "Hi!";
            if (comingTime.TimeOfDay < afternoonStart.TimeOfDay)
            {
                greeting = "Good morning";
            }
            if (comingTime.TimeOfDay > afternoonStart.TimeOfDay && comingTime.TimeOfDay < afternoonEnd.TimeOfDay)
            {
                greeting = "Good afternoon";
            }
            if (comingTime.TimeOfDay > afternoonEnd.TimeOfDay)
            {
                greeting = "Good evening";
            }
            Console.WriteLine("\n'{0}, {1}' said {2}.", greeting, person.Name, this.Name);
        }

        public event EventHandler Came;
        public event EventHandler Leave;

        public void OnCame(TimeArgs timeArgs)
        {
            if (Came != null)
            {
                Came(this, timeArgs);
            }
        }

        public void OnLeve()
        {
            if (Leave != null)
            {
                Leave(this, EventArgs.Empty);
            }
        }
    }
}
