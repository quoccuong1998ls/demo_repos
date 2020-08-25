using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EpiserverSite1.Models.Pages;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "StartBlock", GUID = "b7e3db47-bb44-47ee-93a7-2de76160785a", Description = "")]
    public class StartBlock : BlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
        public virtual PageReference Link_1 { get; set; }
        public virtual PageReference Link_2 { get; set; }
        public virtual PageReference Link_3 { get; set; }
        public virtual ContentReference Image_1 
        {
            get
            {
                var contentRepository = ServiceLocator.Current.GetInstance<IContentLoader>();

                child page = (child)contentRepository.Get<PageData>(Link_1);

                ContentReference img = page.TeaserImage;

                return img;
            }
        }
        public virtual ContentReference Image_2 
        {
            get
            {
                var contentRepository = ServiceLocator.Current.GetInstance<IContentLoader>();

                child page = (child)contentRepository.Get<PageData>(Link_2);

                ContentReference img = page.TeaserImage;

                return img;
            }
        }
        public virtual ContentReference Image_3
        {
            get
            {
                var contentRepository = ServiceLocator.Current.GetInstance<IContentLoader>();

                child page = (child)contentRepository.Get<PageData>(Link_3);

                ContentReference img = page.TeaserImage;

                return img;
            }
        }
    }
}