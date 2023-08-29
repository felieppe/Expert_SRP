using System;

namespace SRP
{
    public class Sector {
        public string LibrarySector { get ; set; }
        public Shelve Shelve { get; set ;}

        public Sector(string sector, Shelve shelve) {
            this.LibrarySector = sector;
            this.Shelve = shelve;

        }
    }
}