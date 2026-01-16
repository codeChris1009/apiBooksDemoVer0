namespace apiBooksDemoVer0.Models.Common.Nation;

/// <summary>
///     Abstract representation of a Nation entity
/// </summary>
public abstract class TheNation
{
    protected abstract string AlphaCode { get; set; }

    protected abstract string NumericCode { get; set; }

    protected abstract string EnglishShortName { get; set; }

    protected abstract IList<string> Language { get; set; }
}