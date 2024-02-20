using Autofac;
using UrlDependencies;

Console.WriteLine("Autofac");

ContainerBuilder containerBuilder = new();

using IContainer container  = containerBuilder.Build();
using ILifetimeScope scope = container.BeginLifetimeScope();


AwesomeUrlSaver urlSaver = scope.Resolve<AwesomeUrlSaver>();

await urlSaver.SaveUrlsAsync("https://www.devleader.ca", "urls.txt");