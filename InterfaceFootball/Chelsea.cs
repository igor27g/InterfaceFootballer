using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFootball
{
    class Chelsea : Footballer, IChelsea
    {
        public Chelsea()
        {

        }

        public Chelsea(string lastName, int age, int goals, int assists)
        {
            this.lastName = lastName;
            this.age = age;
            this.goals = goals;
            this.assists = assists;
        }

        public void scoreGoals()
        {
            Console.WriteLine("Gooooooaaaaal");
        }

        public void haveAssists()
        {
            Console.WriteLine("Great pass");
        }



    }


}
