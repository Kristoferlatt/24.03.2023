namespace Polimorfism2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mootorsõidukid");

            Machine machine = new Machine();
            Machine car = new Car();
            Machine boat = new Boat();

            machine.MachineSound();
            car.MachineSound();
            boat.MachineSound();

            Console.WriteLine();
        }
    }

    class Machine
    {
        public void MachineSound()
        {
            Console.WriteLine("Machine makes sound");
        }
    }

    class Car : Machine
    {
        public void MachineSound()
        {
            Console.WriteLine("Car sounds: PRÕMM PRÕMM");
        }
    }
    class Boat : Machine
    {
        public void MachineSound()
        {
            Console.WriteLine("Boat sounds: VÕMM VÕMM ");
        }
    }

}