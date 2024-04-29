namespace Hundhotellet
{
    internal class Visit
    {
        public DateTime dropoffTime;
        public DateTime pickupTime;

        public Visit(DateTime dropoffTime, DateTime pickupTime)
        {
            this.dropoffTime = dropoffTime;
            this.pickupTime = pickupTime;
        }

        public override string ToString()
        {
            return "Lämna: " + dropoffTime + " Hämta: " + pickupTime;
        }
    }
}
