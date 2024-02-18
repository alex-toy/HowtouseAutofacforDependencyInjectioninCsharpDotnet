using System.Reflection;

namespace Autofac
{
    public sealed class MyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<AwesomeUrlSaver>()
                .SingleInstance();
            builder
                .RegisterType<UrlNormalizer>()
                .SingleInstance();
            builder
                .RegisterType<HtmlContentDownloader>()
                .SingleInstance();
            builder
                .RegisterType<HtmlUrlExtractor>()
                .SingleInstance();
            builder
                .RegisterType<UrlListOutputFormatter>()
                .SingleInstance();
            builder
                .RegisterType<UrlContentFileWriter>()
                .SingleInstance();
        }
    }
}
