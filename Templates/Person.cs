using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templates
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        public DateTime Geburtsdatum { get; set; }

        public override string ToString()
        {
            return $"Person: {Vorname}";
        }
    }

    public class Chef : Person
    {
        public int Gehalt { get; set; }
    }
}
