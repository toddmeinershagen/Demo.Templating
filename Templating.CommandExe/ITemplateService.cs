using System.Globalization;

namespace Templating.CommandExe
{
    public interface ITemplatesService
    {
        string Parse(string templateName, dynamic model, CultureInfo cultureInfo = null);
    }
}
