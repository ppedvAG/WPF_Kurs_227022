﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class Person : IDataErrorInfo
    {
        private string name;
        public string Name
        { 
            get => name;
            set
            {
                if (value.All(x => Char.IsLetter(x)))
                    name = value;
                else
                    throw new Exception("Es dürfen nur Buchstaben im Namen sein");
            }
        }


        public int Alter { get; set; }


        public string Error => null;
        public string this[string columnName]
        {
            get
            {
                switch(columnName)
                {
                    case (nameof(Alter)):
                        if (Alter < 0) return "Du kannst nicht jünger sein als 0 Jahre";
                        if (Alter > 150) return "Du sollst nicht lügen";

                        break;
                }

                return String.Empty;
            }

        }
    }
}