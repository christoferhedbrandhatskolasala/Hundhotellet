namespace Hundhotellet
{
    internal class Owner
    {
        public string firstName;
        public string lastName;
        public Address address;

        public Owner(string firstName, string lastName, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + address;
        }
    }
}
