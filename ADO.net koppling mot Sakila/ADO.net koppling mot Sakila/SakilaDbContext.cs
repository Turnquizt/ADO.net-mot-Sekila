using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_koppling_mot_Sakila
{
    internal class SakilaDbContext
    {
        public void FetchFilmsByActorName(string aFirstName, string aLastName) 
        {
            var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sakila;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            var command1 = new SqlCommand("Select actor.actor_id, film.film_id, film.title " +
                                          "From dbo.film_actor " +
                                          "Inner join dbo.film on film_actor.film_id = film.film_id " +
                                          "Inner Join dbo.actor on film_actor.actor_id = actor.actor_id " +
                                          $"Where actor.first_name = '{aFirstName}' and actor.last_name = '{aLastName}'", connection);
            connection.Open();
            var rec = command1.ExecuteReader();

            if (rec.HasRows) 
            {
                while (rec.Read()) 
                {
                    Console.WriteLine($"{aFirstName} + {aLastName} has acted in movies:");
                    Console.WriteLine(rec[2]);
                }
            }

            connection.Close();
        }
    }
}
