using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PacientInfo pacientInfo = new PacientInfo("Steven Jhonson", "986782342", "5555-555-555");
            MedicalAppointment medicalAppointment = new MedicalAppointment(DateTime.Now, "Wall Street", "Armand");
            Pacient pacient = new Pacient(pacientInfo);
            AppointmentService aps = new AppointmentService(pacient, medicalAppointment);

            Console.WriteLine(aps.Schedule().GetResult() + "\n");

            PacientInfo pacientInfo2 = new PacientInfo("Ralf Manson", "", "5555-555-555");
            MedicalAppointment medicalAppointment2 = new MedicalAppointment(DateTime.Now, "Queen Street", "");
            Pacient pacient2 = new Pacient(pacientInfo2);
            AppointmentService aps2 = new AppointmentService(pacient2, medicalAppointment2);

            Console.WriteLine(aps2.Schedule().GetResult());
        }
    }
}
