namespace apiBooksDemoVer0.Models.Abstracts;

/// <summary>
///     Abstract representation of a Publication entity,
///     <br />包含出版物的基本資訊與相關實體
/// </summary>
public abstract class ThePublicationInfo
{
    /// <summary>
    ///     Publisher Prefix Code
    ///     <br />出版社前綴代碼, 從ISBN中提取
    /// </summary>
    protected abstract string PublisherPrefixISBN { get; }

    /// <summary>
    ///     Unique Identifier linking to the Publisher
    ///     <br />連結到出版商的唯一識別碼
    /// </summary>
    public abstract string PublisherIdCode { get; }

    /// <summary>
    ///     Name of the Publisher
    ///     <br />出版社名稱
    /// </summary>
    protected abstract string PublisherName { get; }

    /// <summary>
    ///     Edition Version of the Publication
    ///     <br />出版物的版本
    /// </summary>
    public abstract string EditionVersion { get; }

    /// <summary>
    ///     Release Date of the Publication
    ///     <br />出版物的發行日期
    /// </summary>
    public abstract DateTime PublishDate { get; }

    public abstract decimal Price { get; }

    public abstract TheCurrency Currency { get; }

    /// <summary>
    ///     Format Type of the Publication (e.g., Hardcover, Paperback, eBook)
    ///     <br />出版物的格式類型（例如，精裝本、平裝本、電子書）
    /// </summary>
    public abstract string FormatType { get; }

    /// <summary>
    ///     Cover Image URL of the Publication
    ///     <br />出版物的封面圖片網址
    /// </summary>
    protected abstract string CoverUrl { get; }

    public abstract BookDimensions Dimensions { get; }

    public abstract string Region { get; }
}