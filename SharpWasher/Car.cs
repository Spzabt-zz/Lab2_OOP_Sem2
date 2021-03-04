namespace SharpWasher
{
    public class Car
    {
        public string CarName { get; }
        public int CarIndex { get; }

        public Car(string carName, int carIndex)
        {
            CarName = carName;
            CarIndex = carIndex;
        }
    }
}