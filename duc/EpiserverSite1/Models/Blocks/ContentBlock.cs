using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "ContentBlock", GUID = "12887db9-c5fc-4387-af85-3674ae9b45df", Description = "")]
    public class ContentBlock : BlockData
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

        public virtual PageReference Link { get; set; }


        
    }
}