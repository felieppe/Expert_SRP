using System;

namespace SRP
{
    public class Sector {
        private string LibrarySector { get ; set; }
        private Shelve Shelve { get; set ;}

        public Sector(string sector, Shelve shelve) {
            this.LibrarySector = sector;
            this.Shelve = shelve;

        }
    }
}