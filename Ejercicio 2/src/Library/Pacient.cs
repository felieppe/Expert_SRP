using System.Net.NetworkInformation;

namespace Library {
    public class Pacient {
        private PacientInfo PacientInfo { get; set; }
        public Pacient(PacientInfo pi) {
            SetPacientInfo(pi);
        }

        public PacientInfo GetPacientInfo() {
            return this.PacientInfo;
        }

        public void SetPacientInfo(PacientInfo pi) {
            if (pi != null) {
                this.PacientInfo = pi;
            }
        }
    }
}