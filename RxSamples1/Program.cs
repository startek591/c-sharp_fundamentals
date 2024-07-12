namespace RxSamples
{
    class Program : IObserver<float>
    {
        static void Main(string[] args)
        {
            // OnNext* --> (OnError | OnCompleted)?
        }

        public void OnNext(float value)
        {
            Console.WriteLine($"Market gave us {value}");
        }

        public void OnError(Exception error)
        {

        }

        public void OnCompleted()
        {

        }
    }
}