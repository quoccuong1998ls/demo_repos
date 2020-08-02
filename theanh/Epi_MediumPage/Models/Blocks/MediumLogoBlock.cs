using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;


namespace Epi_MediumPage.Models.Blocks
{
    [ContentType(DisplayName = "DefaultBlock1", GUID = "38e4dcc0-789a-43f5-bd39-b91f612446e7", Description = "", AvailableInEditMode = false)]
    public class MediumLogoBlock : SiteBlockData
    {

        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Image)]
        public virtual Url Url
        {
            get
            {
                var url = this.GetPropertyValue(b => b.Url);

                return url == null || url.IsEmpty()
                            ? new Url("/Static/gfx/medium_logo_2.png")
                            : url;
            }
            set
            {
                this.SetPropertyValue(b => b.Url, value);
            }
        }

        [CultureSpecific]
        public virtual string Title { get; set; }
    }
}