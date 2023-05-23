using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Person : INotifyPropertyChanged
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        public List<DateTime> WichtigeTage { get; set; } = new List<DateTime>()
        {
            DateTime.Now,
            new DateTime(2002, 3, 1),
            new DateTime(2023, 1, 23),
            new DateTime(1997, 12, 7),
        };

        public DateTime LetzterTag { get { Thread.Sleep(1000); return WichtigeTage.Last(); } }

        public Person()
        {
            Alter = 31;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void UpdateGUI()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LetzterTag)));
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname} ({Alter})";
        }
    }
}
