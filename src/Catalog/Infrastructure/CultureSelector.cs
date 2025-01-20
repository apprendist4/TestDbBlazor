using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace Catalog.Infrastructure;

public static class CultureSelector
{
    public static void Select(SupportedCulture culture)
    {
        var cultureInfo = new CultureInfo(SupportedCultureToStringConverter.Convert(culture));
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    }
}