using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "TeaserBlock", GUID = "67d5f7e8-fcfe-452c-bef6-f51e16aaaa9b", Description = "")]
    public class TeaserBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [Display(
            Name = "Description",
            Description = "Enter a Description for the block",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [Required]
        public virtual XhtmlString Description { get; set; }

        
        

        [Display(
            Name = "Url",
            Description = "Enter a Url for the button",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [Required]
        public virtual Url Url { get; set; }

       
        public virtual String Link { get; set; }

       
        public virtual ContentReference TeaserImage { get; set; }
    
}

}