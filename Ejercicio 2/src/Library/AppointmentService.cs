using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private MedicalAppointment MedicalAppointment { get; set;}
        private Pacient Pacient { get; set;}
        public AppointmentService(Pacient pacient, MedicalAppointment mapp) {
            SetMedicalAppointment(mapp);
            SetPacient(pacient);
        }

        public void SetMedicalAppointment(MedicalAppointment mapp) {
            if (mapp != null) {
                this.MedicalAppointment = mapp;
            }
        }
        public void SetPacient(Pacient p) {
            if (p != null) {
                this.Pacient = p;
            }
        }

        public AppointmentResult Schedule() {
            return this.CheckAppointment();
        }
        public MedicalAppointment GetMedicalAppointment() {
            return MedicalAppointment;
        }
        public Pacient GetPacient() {
            return Pacient;
        }

        private AppointmentResult CheckAppointment() {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            PacientInfo pi = this.Pacient.GetPacientInfo();
            string name = pi.GetName();
            string id = pi.GetId();
            string phoneNumber = pi.GetPhoneNumber();

            MedicalAppointment ma = this.MedicalAppointment;
            string appoinmentPlace = ma.GetAppointmentPlace();
            string doctorName = ma.GetDoctor().GetName();

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return new AppointmentResult(isValid, stringBuilder.ToString());
        }
    }
}
