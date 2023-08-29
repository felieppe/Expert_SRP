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

        public string GetLibrarySector() {
            return LibrarySector;
        }
        public Shelve GetShelve() {
            return Shelve;
        }

        public void SetLibrarySector(string sector) {
            if (!string.IsNullOrEmpty(sector)) {
                this.LibrarySector = sector;
            }
        }
        public void SetShelve(Shelve shelve) {
            if (shelve != null) {
                this.Shelve = shelve;
            }
        }
    }
}