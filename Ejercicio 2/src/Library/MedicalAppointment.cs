using System;

namespace Library {
    public class MedicalAppointment {
        private DateTime Date {get; set;}
        private string AppointmentPlace {get; set;}
        private Doctor Doctor {get; set;}
        public MedicalAppointment (DateTime date, string place, Doctor doc) {
            this.Date = date;
            this.AppointmentPlace = place;
            this.Doctor = doc;
        }

        public DateTime GetDateTime() {
            return this.Date;
        }
        public string GetAppointmentPlace() {
            return this.AppointmentPlace;
        }
        public Doctor GetDoctor() {
            return this.Doctor;
        }

        public void SetDateTime(DateTime dateTime) {
            if (dateTime != DateTime.MinValue) {
                this.Date = dateTime;
            }
        }
        public void SetAppointmentPlace(string appoinmentPlace) {
            if (!string.IsNullOrEmpty(appoinmentPlace)) {
                this.AppointmentPlace = appoinmentPlace;
            }
        }
        public void SetDoctor(Doctor doc) {
            if (doc != null) {
                this.Doctor = doc;
            }
        }
    }
}