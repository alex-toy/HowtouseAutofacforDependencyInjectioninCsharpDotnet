namespace UrlDependencies
{
    public sealed class UrlContentFileWriter
    {
        public void WriteUrlContentToFile(string outputFilePath, string content)
        {
            var fullOutputFilePath = Path.GetFullPath(outputFilePath);
            Directory.CreateDirectory(Path.GetDirectoryName(fullOutputFilePath));
            File.WriteAllText(fullOutputFilePath, content);
        }
    }
}
