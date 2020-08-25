using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "TopBlock", GUID = "3d35ed59-9ef8-4a1a-9f1f-ef49c089f6c1", Description = "")]
    public class TopBlock : BlockData
    {
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string Text { get; set; }

        [Display(
           Name = "Image",
           Description = "Chose a image for the block",
           GroupName = SystemTabNames.Content,
           Order = 3)]
        [Required]
        public virtual Url Image { get; set; }

        [Display(
            Name = "Url",
            Description = "Enter a Url for the button",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [Required]
        public virtual Url Url { get; set; }
    }
}