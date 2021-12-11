using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;

namespace adacaun.dev.Web.Components.UI;

public class UIComponentBase : ComponentBase
{
    protected string FormatCss(string css)
        => Regex.Replace(css, @"\s+", " ").Trim();
}