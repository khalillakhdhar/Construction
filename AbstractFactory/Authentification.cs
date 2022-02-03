using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.AbstractFactory
{
    abstract class Authentification
    {
        public abstract void authentification();

        public void Gererprofile(string espace)
        {
            Console.WriteLine("bienvenu à l'espace " + espace);

        }


    }

    class ClientAuth : Authentification
    {
        public override void authentification()
        {
            Console.WriteLine("redirection à l'espace client");
        }
    }
    class AdminAuth : Authentification
    {
        public override void authentification()
        {
            Console.WriteLine("redirection à l'espace admin");
        }


    }
    public class User
    {
        public void main()
        {
            Console.WriteLine("authentification admin");
            AdminAuth ad = new AdminAuth();
            ad.authentification();
            ad.Gererprofile("admin");
            Console.WriteLine("authentification client");
            ClientAuth cl = new ClientAuth();
            cl.authentification();
            cl.Gererprofile("client ");
        }

    }


}
