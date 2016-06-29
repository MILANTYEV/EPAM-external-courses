using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        delegate void Message(Person person, DateTime comingTime);
        static Message delGreet;

        delegate void Leave(Person person);
        static Leave leave;

        static void PersonCame(object sendler, EventArgs e)
        {
            var person = sendler as Person;
            var timeArgs = e as TimeArgs;
            if (person != null)
            {
                Console.WriteLine("\n{0} has come", person.Name);
                if (delGreet != null)
                    delGreet(person, timeArgs.Time);

                delGreet+= person.Greet;
                leave += person.SayGoodbye;
            }
        }

        static void PersonLeft(object sendler, EventArgs e)
        {
            var person = sendler as Person;
            if (person != null)
            {
                leave -= person.SayGoodbye;
                Console.WriteLine("\n{0} left", person.Name);
                if (leave != null)
                    leave(person);
            }
        }

        static void Main(string[] args)
        {
            
            Person arni = new Person("Arnold");
            Person silvester = new Person("Silvester Stallone");
            Person chuck = new Person("Chuck");

            arni.Came += new EventHandler(PersonCame);
            silvester.Came += new EventHandler(PersonCame);
            chuck.Came += new EventHandler(PersonCame);

            arni.Leave += new EventHandler(PersonLeft);
            silvester.Leave += new EventHandler(PersonLeft);
            chuck.Leave += new EventHandler(PersonLeft);

            TimeArgs arniTime = new TimeArgs(new DateTime(1, 1, 1, 8, 10, 10));
            TimeArgs silvesterTime = new TimeArgs(new DateTime(1, 1, 1, 14, 10, 10));
            TimeArgs chuckTime = new TimeArgs(new DateTime(1, 1, 1, 20, 1, 10));
            
            arni.OnCame(arniTime);
            silvester.OnCame(silvesterTime);
            chuck.OnCame(chuckTime);

            arni.OnLeve();
            silvester.OnLeve();
            chuck.OnLeve();

            Console.ReadKey();
        }
    }
}
