namespace Hundhotellet
{
    internal class Address
    {
        public string gatuAdress;
        public string stad;
        public string postnummer;

        public Address(string gatuAdress, string stad, string postnummer)
        {
            this.gatuAdress = gatuAdress;
            this.stad = stad;
            this.postnummer = postnummer;
        }

        public override string ToString()
        {
            return gatuAdress + " " + postnummer + " " + stad;
        }
    }
}
