using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTask6
{
    internal class Band
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string TimeSlot { get; set; }

        public Band(string name, string genre, string timeslot)
        {
            Name = name;
            Genre = genre;
            TimeSlot = timeslot;
        }

        public override string ToString()
        {
            return Name + ", " + Genre + ", " + TimeSlot;
        }
    }
}
