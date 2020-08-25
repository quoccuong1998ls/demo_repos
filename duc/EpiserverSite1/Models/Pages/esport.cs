using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.UI.Edit.ImageEditor;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "esport", GUID = "87b0ff3d-db49-46ee-b27f-90f314438833", Description = "", GroupName = Global.GroupNames.Specialized)]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class esport : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString MainBody { get; set; }

  
    }


}
