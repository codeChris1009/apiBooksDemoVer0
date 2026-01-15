namespace apiBooksDemoVer0.Models.Common.Nation;

public abstract class TheNation
{
    protected abstract string AlphaCode { get; set; }

    protected abstract string NumericCode { get; set; }

    protected abstract string EnglishShortName { get; set; }

    protected abstract IList<string> Language { get; set; }
}