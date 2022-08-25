namespace FactoryPatternExercise
{
    internal class Motorcycle : IVehicle
    {
        public int NumberOfTires { get; set; }

        public void Drive()
        {
            Console.WriteLine($"What do we got here?\n" +
                              $"Evil Kenevil? Okay\n" +
                              $"One Motorcycle on the way Stunt-Man!");
        }
    }
}
