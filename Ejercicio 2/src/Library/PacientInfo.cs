namespace Library {
    public class PacientInfo {
        private string Name {get; set;}
        private int Age {get; set;}
        private string Id {get; set;}
        private string PhoneNumber {get; set;}
        public PacientInfo(string name, int age, string id, string phoneNumber) {
            SetName(name);
            SetAge(age);
            SetId(id);
            SetPhoneNumber(phoneNumber);
        }

        public string GetName() {
            return this.Name;
        }
        public int GetAge() {
            return this.Age;
        }
        public string GetId() {
            return this.Id;
        }
        public string GetPhoneNumber() {
            return this.PhoneNumber;
        }

        public void SetName(string name) {
            if (!string.IsNullOrEmpty(name)) {
                this.Name = name;
            }
        }
        public void SetAge(int age) {
            this.Age = age;
        }
        public void SetId(string id) {
            if (!string.IsNullOrEmpty(id)) {
                this.Id = id;
            }
        }
        public void SetPhoneNumber(string phone) {
            if (!string.IsNullOrEmpty(phone)) {
                this.PhoneNumber = phone;
            }           
        }
    }
}