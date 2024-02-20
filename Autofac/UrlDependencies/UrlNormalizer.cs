namespace UrlDependencies
{
    public sealed class UrlNormalizer
    {
        public string NormalizeUrl(string websiteUrl)
        {
            string normalizedUrl;
            if (websiteUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
            {
                normalizedUrl = $"https://{websiteUrl[7..]}";
            }
            else if (!websiteUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                normalizedUrl = $"https://{websiteUrl}";
            }
            else
            {
                normalizedUrl = websiteUrl;
            }

            if (!Uri.TryCreate(normalizedUrl, UriKind.Absolute, out var uri))
            {
                throw new ArgumentException(
                    $"Could not make '{websiteUrl}' into a valid https URI.");
            }

            return normalizedUrl;
        }
    }
}
