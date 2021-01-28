namespace IdentityValidate.Entities
{
    internal class Citizen
    {
        private string _name;
        private string _surname;
        public long IdentityNumber { get; set; }

        public string Name
        {
            get => _name.ToUpper();
            set => _name = value;
        }

        public string Surname
        {
            get => _surname.ToUpper();
            set => _surname = value;
        }

        public int BirthYear { get; set; }
    }
}