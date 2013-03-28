namespace Templating.CommandExe
{
    public interface ITemplateEngine
    {
        string Parse(string template, dynamic model);
    }
}
