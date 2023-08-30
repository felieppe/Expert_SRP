using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Doctor
    {
        private string Name {get; set;}
        private string Speciality {get; set;}

        public Doctor(string name, string speciality) {
            SetName(name);
            SetSpeciality(speciality);
        }

        public string GetName() {
            return this.Name;
        }
        public string GetSpeciality() {
            return this.Speciality;
        }

        public void SetName(string name) {
            if (!string.IsNullOrEmpty(name)) {
                this.Name = name;
            }
        }
        public void SetSpeciality(string speciality) {
            if (!string.IsNullOrEmpty(speciality)) {
                this.Speciality = speciality;
            }
        }
    }
}