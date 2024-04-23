namespace Hundhotellet
{
    internal class Dog
    {
        public string name;
        public string chipNumber;

        public Dog(string name, string chipNumber)
        {
            this.name = name;
            this.chipNumber = chipNumber;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
