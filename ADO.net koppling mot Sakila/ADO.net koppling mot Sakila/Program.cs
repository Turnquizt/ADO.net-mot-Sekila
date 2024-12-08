using Microsoft.Data.SqlClient;
namespace ADO.net_koppling_mot_Sakila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.InputActorAndFetchFilms();
        }
    }
}
