using Autofac;
using UrlAutofac;
using UrlDependencies;

Console.WriteLine("Autofac");

AwesomeUrlSaver urlSaver = GetUrlSaver();
await urlSaver.SaveUrlsAsync("https://www.devleader.ca", "urls.txt");

SomeComposedClass SomeSpotInYourCode()
{
    AwesomeUrlSaver urlSaver = GetUrlSaver();
    SomeComposedClass someComposedClass = new(urlSaver);
    return someComposedClass;
}

void SomeOtherSpotInYourCode()
{
    AwesomeUrlSaver urlSaver = GetUrlSaver();

    SomeComposedClass2 someComposedClass2 = new(urlSaver);
    someComposedClass2.DoStuff();
}

static AwesomeUrlSaver GetUrlSaver()
{
    ContainerBuilder containerBuilder = new();
    containerBuilder.RegisterModule<MyModule>();
    IContainer container = containerBuilder.Build();
    ILifetimeScope scope = container.BeginLifetimeScope();
    AwesomeUrlSaver urlSaver = scope.Resolve<AwesomeUrlSaver>();
    return urlSaver;
}