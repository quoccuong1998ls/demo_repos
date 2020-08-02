using System;
using System.ComponentModel.DataAnnotations;
using Epi_MediumPage.Business.Rendering;
using Epi_MediumPage.Models.Blocks;
using Epi_MediumPage.Models.ViewModels;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Epi_MediumPage.Models.Pages
{
    [ContentType(DisplayName = "MediumPage", GUID = "734bfb6b-db8b-4f99-b630-5d21c59b506c", Description = "",
        GroupName = Global.GroupNames.Specialized)]

    public class MediumPage : SitePageData
    {

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 310)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

        

    }
}