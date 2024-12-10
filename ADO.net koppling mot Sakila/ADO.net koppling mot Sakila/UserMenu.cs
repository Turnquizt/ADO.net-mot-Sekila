using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_koppling_mot_Sakila
{
    internal class UserMenu
    {
        SakilaDbContext SDbCtxt = new SakilaDbContext();
        public void InputActorAndFetchFilms() 
        {
            Console.WriteLine("Please enter the firstname of the actor you want to look up.");
            var actorFirstName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter the lastname of the actor you want to look up.");
            var actorLastName = Console.ReadLine();
            Console.Clear();
            SDbCtxt.FetchFilmsByActorName(actorFirstName, actorLastName);
        }
    }
}
