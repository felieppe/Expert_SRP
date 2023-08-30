using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PacientInfo pacientInfo = new PacientInfo("Steven Jhonson", 18, "986782342", "5555-555-555");
            Doctor doctor = new Doctor("Armand", "");
            MedicalAppointment medicalAppointment = new MedicalAppointment(DateTime.Now, "Wall Street", doctor);
            Pacient pacient = new Pacient(pacientInfo);
            AppointmentService aps = new AppointmentService(pacient, medicalAppointment);

            Console.WriteLine(aps.Schedule().GetResult() + "\n");

            PacientInfo pacientInfo2 = new PacientInfo("Ralf Manson", 25, "", "5555-555-555");
            Doctor doctor2 = new Doctor("", "");
            MedicalAppointment medicalAppointment2 = new MedicalAppointment(DateTime.Now, "Queen Street", doctor);
            Pacient pacient2 = new Pacient(pacientInfo2);
            AppointmentService aps2 = new AppointmentService(pacient2, medicalAppointment2);

            Console.WriteLine(aps2.Schedule().GetResult());
        }
    }
}
