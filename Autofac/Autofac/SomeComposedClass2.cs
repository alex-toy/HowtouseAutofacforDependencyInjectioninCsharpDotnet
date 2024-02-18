namespace Autofac
{
    public class SomeComposedClass2
    {
        private readonly AwesomeUrlSaver _urlSaver;

        public SomeComposedClass2(AwesomeUrlSaver urlSaver)
        {
            _urlSaver = urlSaver;
        }

        public void DoStuff()
        {
            Console.WriteLine("SomeComposedClass2 DoStuff");
        }
    }
}
