namespace UrlDependencies
{
    public class SomeComposedClass
    {
        private readonly AwesomeUrlSaver _urlSaver;

        public SomeComposedClass(AwesomeUrlSaver urlSaver)
        {
            _urlSaver = urlSaver;
        }

        public void DoStuff()
        {
            Console.WriteLine("SomeComposedClass DoStuff");
        }
    }
}
