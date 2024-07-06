namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Vehicle object
            Vehicle buick = new Vehicle("Buick", 4, 160);

            // Check if Vehicle implements
            // IDrivable
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }

            // We are now modeling the act of
            // picking up a remote, aiming it 
            // at the TV, clicking the power
            // button and then watching as
            // the TV turns on and off

            // Pick up the TV remote
            IElectronicDevice TV = TVRemote.GetDevice();

            // Create the power button
            PowerButton powButt = new PowerButton(TV);

            // Turn the TV on and off switch each 
            // press
            powButt.Execute();
            powButt.Undo();
            powButt.Execute();
            powButt.Undo();

        }
    }
}
