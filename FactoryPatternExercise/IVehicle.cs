namespace FactoryPatternExercise
{
    internal interface IVehicle
    {
        public int NumberOfTires { get; set; }
        public void Drive();
    }
}
