namespace apiBooksDemoVer0.Models.Enum;

public enum BookFormatType
{
    Unknown = 0,

    /// <summary>
    ///     Hardcover Book Format
    ///     <br />精裝書格式
    /// </summary>
    Hardcover = 1,

    /// <summary>
    ///     Paperback Book Format
    ///     <br />平裝書格式
    /// </summary>
    Paperback = 2,

    // Below are digital electronic products
    // 以下為數位電子化產品
    EBook = 3,
    AudioBook = 4
}