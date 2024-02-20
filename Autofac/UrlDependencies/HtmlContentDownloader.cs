namespace UrlDependencies
{
    public sealed class HtmlContentDownloader
    {
        public async Task<string> DownloadHtmlContentAsync(string url)
        {
            using HttpClient client = new();
            var htmlContent = await client.GetStringAsync(url);
            return htmlContent;
        }
    }
}
