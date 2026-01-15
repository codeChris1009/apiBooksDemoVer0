using apiBooksDemoVer0.Models.Common.Nation;

namespace apiBooksDemoVer0.Models.Abstracts;

public abstract class ThePublisher
{
    /// <summary>
    ///     Unique Identifier for the Publisher
    /// </summary>
    protected abstract string IdCodePublisher { get; }

    protected abstract string Name { get; }

    /// <summary>
    ///     Publisher Prefix Code
    ///     <br />出版社前綴代碼, 從ISBN中提取
    /// </summary>
    protected abstract string PrefixISBN { get; }

    protected abstract TheNation Nation { get; }

    protected abstract string OfficialWebsite { get; }

    protected abstract string Description { get; }

    protected abstract int EstablishedYear { get; }

    protected abstract string LogoUrl { get; }

    protected abstract string BannerUrl { get; }

    protected abstract IList<TheSocialMedia> SocialMediaLinks { get; }
}