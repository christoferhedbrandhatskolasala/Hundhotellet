namespace Hundhotellet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);

            Console.WriteLine("Info");
            dogHotel.PrintInfo();

            Console.WriteLine("\n\rFeedingSchedule");
            dogHotel.PrintFeedingSchedule();

            Console.WriteLine("\n\rPickups");
            dogHotel.PrintPickups();
        }

        static void AddTestData(DogHotel dogHotel)
        {
            Address testAddress1 = new Address("Gatuvägen 42", "Sala", "54321");
            Address testAddress2 = new Address("Stigavenyn 123", "Borås", "12345");

            Owner testOwner1 = new Owner("Johan", "Andersson", testAddress1);
            Owner testOwner2 = new Owner("Anders", "Johansson", testAddress2);

            DateTime inThePast = DateTime.Now - TimeSpan.FromDays(3);
            Visit testVisit1 = new Visit(new DateTime(2024, 8, 3, 8, 0, 0), new DateTime(2024, 8, 14, 16, 30, 0));
            Visit testVisit2 = new Visit(inThePast - TimeSpan.FromDays(10), inThePast);

            Dog testDog1 = new Dog("Fido", "123456", testOwner1, testVisit1);
            Dog testDog2 = new Dog("Lassie", "654321", testOwner2, testVisit2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);

            Meal testMeal1 = new Meal(7, "kött", "2kg");
            Meal testMeal2 = new Meal(14, "pasta", "500g");
            Meal testMeal3 = new Meal(8, "fisk", "2st");
            Meal testMeal4 = new Meal(13, "smoothie", "350ml");

            testDog1.AddMeal(testMeal1);
            testDog1.AddMeal(testMeal2);
            testDog2.AddMeal(testMeal3);
            testDog2.AddMeal(testMeal4);
        }
    }
}