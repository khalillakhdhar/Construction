using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.builder
{
    class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }

        public User(int id, string nom, int age)
        {
            Id = id;
            Nom = nom;
            Age = age;
        }
    }
}
