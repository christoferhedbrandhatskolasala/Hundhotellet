namespace Hundhotellet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            dogHotel.PrintInfo();
        }

        static void AddTestData(DogHotel dogHotel)
        {
            Address testAddress1 = new Address("Gatuvägen 42", "Sala", "54321");
            Address testAddress2 = new Address("Stigavenyn 123", "Borås", "12345");

            Owner testOwner1 = new Owner("Johan", "Andersson", testAddress1);
            Owner testOwner2 = new Owner("Anders", "Johansson", testAddress2);

            Dog testDog1 = new Dog("fido", "123456", testOwner1);
            Dog testDog2 = new Dog("lassie", "654321", testOwner2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);
        }
    }
}