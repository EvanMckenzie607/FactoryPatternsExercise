namespace FactoryPatternExercise
{
    internal class UniCycle : IVehicle
    {
        public int NumberOfTires { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Looks like we got a clown here!\n" +
                              $"Go do some Clown things with this\n" +
                              $"New Unicycle!");
        }
    }
}
