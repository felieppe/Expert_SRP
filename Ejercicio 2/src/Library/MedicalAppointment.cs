using System;

namespace Library {
    public class MedicalAppointment {
        private string Id {get; set;}
        private DateTime Date {get; set;}
        private string AppointmentPlace {get; set;}
        private Doctor Doctor {get; set;}
        public MedicalAppointment (string id, DateTime date, string place, Doctor doc) {
            SetId(id);
            SetDateTime(date);
            SetAppointmentPlace(place);
            SetDoctor(doc);
        }

        public string GetId() {
            return this.Id;
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

        public void SetId(string id) {
            if (!string.IsNullOrEmpty(id)) {
                this.Id = id;
            }
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