using System.Runtime.CompilerServices;

namespace Library {
    public class AppointmentResult {
        private bool Validity {get; set;}
        private string Result {get; set;}
        public AppointmentResult (bool valid, string result) {
            SetValidity(valid);
            SetResult(result);
        }

        public bool GetValidity() {
            return this.Validity;
        }
        public string GetResult() {
            return this.Result;
        }

        public void SetValidity(bool valid) {
            this.Validity = valid;
        }
        public void SetResult(string result) {
            if (!string.IsNullOrEmpty(result)) {
                this.Result = result;
            }
        }
    }
}