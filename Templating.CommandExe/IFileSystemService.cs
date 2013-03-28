namespace Templating.CommandExe
{
    public interface IFileSystemService
    {
        string ReadAllText(string fileName);
        bool FileExists(string fileName);
        string GetCurrentDirectory();
    }
}
