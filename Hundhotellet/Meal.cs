namespace Hundhotellet
{
    internal class Meal
    {
        public int hourOfDay;
        public string foodType;
        public string amount;

        public Meal(int hourOfDay, string foodType, string amount)
        {
            this.hourOfDay = hourOfDay;
            this.foodType = foodType;
            this.amount = amount;
        }

        public override string ToString()
        {
            return "kl " + hourOfDay + ": " + foodType + " " + amount;
        }
    }
}
