using UrlDependencies;

Console.WriteLine("Dependencies is a mess!");

AwesomeUrlSaver urlSaver = new(
    new UrlNormalizer(),
    new HtmlContentDownloader(),
    new HtmlUrlExtractor(),
    new UrlListOutputFormatter(),
    new UrlContentFileWriter());

await urlSaver.SaveUrlsAsync("https://www.devleader.ca", "urls.txt");

SomeComposedClass SomeSpotInYourCode()
{
    AwesomeUrlSaver urlSaver = new(
        new UrlNormalizer(),
        new HtmlContentDownloader(),
        new HtmlUrlExtractor(),
        new UrlListOutputFormatter(),
        new UrlContentFileWriter());

    SomeComposedClass someComposedClass = new(urlSaver);
    return someComposedClass;
}

void SomeOtherSpotInYourCode()
{
    AwesomeUrlSaver urlSaver = new(
        new UrlNormalizer(),
        new HtmlContentDownloader(),
        new HtmlUrlExtractor(),
        new UrlListOutputFormatter(),
        new UrlContentFileWriter());

    SomeComposedClass2 someComposedClass2 = new(urlSaver);
    someComposedClass2.DoStuff();
}