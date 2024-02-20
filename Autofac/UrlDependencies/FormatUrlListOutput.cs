using System.Text;

namespace UrlDependencies
{
    public sealed class FormatUrlListOutput
    {
        public StringBuilder FormatUrlListOutput_(string normalizedUrl, List<string> urls)
        {
            StringBuilder outputBuilder = new();
            outputBuilder.AppendLine($"All of the URLs from '{normalizedUrl}':");

            foreach (string url in urls)
            {
                outputBuilder.AppendLine(url);
            }

            return outputBuilder;
        }
    }
}
