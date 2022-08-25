using FactoryPatternExercise;


Console.WriteLine("Hey yous there!\n" +
                  "You need some wheels eh?\n" +
                  "Im your guy, would ya believe that?\n" +
                  "So tell me,\n" +
                  "How many you need?");

int response = int.Parse(Console.ReadLine());
IVehicle vehicle = VehicleFactory.GetVehicle(response);

vehicle.Drive();
