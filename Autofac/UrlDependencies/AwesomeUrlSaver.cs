namespace UrlDependencies
{
    public sealed class AwesomeUrlSaver
    {
        private readonly UrlNormalizer _urlNormalizer;
        private readonly HtmlContentDownloader _htmlContentDownloader;
        private readonly HtmlUrlExtractor _htmlUrlExtractor;
        private readonly UrlListOutputFormatter _urlListOutputFormatter;
        private readonly UrlContentFileWriter _urlContentFileWriter;

        public AwesomeUrlSaver(
            UrlNormalizer urlNormalizer,
            HtmlContentDownloader htmlContentDownloader,
            HtmlUrlExtractor htmlUrlExtractor,
            UrlListOutputFormatter urlListOutputFormatter,
            UrlContentFileWriter urlContentFileWriter)
        {
            _urlNormalizer = urlNormalizer;
            _htmlContentDownloader = htmlContentDownloader;
            _htmlUrlExtractor = htmlUrlExtractor;
            _urlListOutputFormatter = urlListOutputFormatter;
            _urlContentFileWriter = urlContentFileWriter;
        }

        public async Task SaveUrlsAsync(string websiteUrl, string outputFilePath)
        {
            ArgumentException.ThrowIfNullOrEmpty(websiteUrl);
            ArgumentException.ThrowIfNullOrEmpty(outputFilePath);

            var normalizedUrl = _urlNormalizer.NormalizeUrl(websiteUrl);

            var htmlContent = await _htmlContentDownloader.DownloadHtmlContentAsync(normalizedUrl);

            var urls = _htmlUrlExtractor.BuildUrlListFromHtml(htmlContent);

            var outputBuilder = _urlListOutputFormatter.FormatUrlListOutput(normalizedUrl, urls);

            _urlContentFileWriter.WriteUrlContentToFile(outputFilePath, outputBuilder.ToString());
        }
    }
}
