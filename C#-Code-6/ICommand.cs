namespace ConsoleApp6
{
    interface ICommand
    {
        // We can model what happens when
        // a button is pressed for example
        // a power button. By breaking
        // everything down we can add
        // and infinite amount of flexbility
        void Execute();
        void Undo();
    }
}