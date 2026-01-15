namespace apiBooksDemoVer0.Models.Common.ValueObjects;

public abstract class TheCurrency
{
    protected abstract string CodeISO { get; }
    protected abstract string NumISO { get; }

    /// <summary>
    ///     The number of digits after the decimal separator.
    ///     <br />小數點後的位數
    /// </summary>
    protected abstract short DPlace { get; }
}