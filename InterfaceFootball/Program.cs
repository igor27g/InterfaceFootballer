using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFootball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Footballer> footballers = new List<Footballer>();

            Chelsea chelseaFootballer1 = new Chelsea("Morata", 26, 10, 5);
            Chelsea chelseaFootballer2 = new Chelsea("Giroud", 30, 10, 5);

            footballers.Add(chelseaFootballer1);
            footballers.Add(chelseaFootballer2);

            foreach(Footballer f in footballers)
            {
                if (f is IChelsea)
                {
                    IChelsea chelseaFootballer = f as Chelsea;
                    Console.WriteLine("{0}:", f.lastName);

                    chelseaFootballer.scoreGoals();
                }

            }


            Console.ReadKey();


        }
    }
}
