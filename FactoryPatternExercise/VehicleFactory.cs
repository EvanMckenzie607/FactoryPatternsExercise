namespace FactoryPatternExercise
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int NumberOfWheels)
        {
            switch (NumberOfWheels)
            {
                case 1:
                    return new UniCycle();
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    return new UniCycle();
            }
        }
    }
}
