using Elon_adventure;

class Program
{
    static void Main(string[] args)
    {
        RemoteControlCar car1 = new RemoteControlCar("Red");
        RemoteControlCar car2 = new RemoteControlCar("Green");

        car1.ShowStatus();
        car2.ShowStatus();

        DriveUntilEmpty(car1);
        DriveUntilEmpty(car2);

        car1.ShowStatus();
        car2.ShowStatus();

        car1.Recharge();
        car2.Recharge();

        car1.ShowStatus();
        car2.ShowStatus();

        Console.ReadLine();
    }
    static void DriveUntilEmpty(RemoteControlCar car)
    {
        do
        {
            car.Drive();
        } while (car.GetBatteryCapacity() > 0);
        Console.WriteLine($"The battery of the {car.GetColor()} car is empty. Please recharge the car.");
    }
}
