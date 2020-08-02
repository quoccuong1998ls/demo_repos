using EPiServer.Core;

namespace Epi_MediumPage.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
