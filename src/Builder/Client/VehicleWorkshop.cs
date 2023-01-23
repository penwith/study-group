using Vehicles;

namespace Client
{
    public static class VehicleWorkshop
    {
        public static void Run()
        {
            VehicleBuilder builder;

            Workshop workshop = new Workshop();

            builder = new ScooterBuilder();
            workshop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            workshop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            workshop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
