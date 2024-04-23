namespace Hundhotellet
{
    internal class Dog
    {
        public string name;
        public string chipNumber;
        public Owner owner;
        public List<Meal> mealList = new List<Meal>();

        public Dog(string name, string chipNumber, Owner owner)
        {
            this.name = name;
            this.chipNumber = chipNumber;
            this.owner = owner;
        }

        public void AddMeal(Meal meal)
        {
            mealList.Add(meal);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
