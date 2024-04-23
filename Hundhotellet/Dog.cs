namespace Hundhotellet
{
    internal class Dog
    {
        public string name;
        public string chipNumber;
        public Owner owner;

        public Dog(string name, string chipNumber, Owner owner)
        {
            this.name = name;
            this.chipNumber = chipNumber;
            this.owner = owner;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
