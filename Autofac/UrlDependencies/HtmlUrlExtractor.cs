using System.Text.RegularExpressions;

namespace UrlDependencies
{
    public sealed class HtmlUrlExtractor
    {
        public List<string> BuildUrlListFromHtml(string htmlContent)
        {
            Regex hrefRegex = new(
                @"href\s*=\s*'([0-9a-z:/\.\-]+)'", // FIXME: is this regex sufficient?!
                RegexOptions.IgnoreCase);

            List<string> urls = new();
            foreach (Match match in hrefRegex.Matches(htmlContent))
            {
                urls.Add(match.Groups[1].Value);
            }

            return urls;
        }
    }
}
