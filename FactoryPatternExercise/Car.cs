namespace FactoryPatternExercise
{
    internal class Car : IVehicle
    {
        public int NumberOfTires { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Ayo!\n" +
                              $"Somebody order a Car?!\n" +
                              $"One Car coming right up!");
        }
    }
}
