using RazorEngine;

namespace Templating.CommandExe.Rz
{
    public class RazorTemplateEngine : ITemplateEngine
    {
        public string Parse(string template, dynamic model)
        {
            return Razor.Parse(template, model);
        }
    }
}
