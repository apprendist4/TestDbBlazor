namespace Catalog.Infrastructure;

public static class SupportedCultureToStringConverter
{
    public static string Convert(SupportedCulture culture)
    {
        return culture switch
        {
            SupportedCulture.EnUs => "en-US",
            SupportedCulture.It => "it",
            _ => "it"
        };
    }
}