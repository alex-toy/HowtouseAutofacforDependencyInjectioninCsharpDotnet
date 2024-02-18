Console.WriteLine("Dependencied is a mess!");

AwesomeUrlSaver urlSaver = new(
    new UrlNormalizer(),
    new HtmlContentDownloader(),
    new HtmlUrlExtractor(),
    new UrlListOuputFormatter(),
    new UrlContentFileWriter());