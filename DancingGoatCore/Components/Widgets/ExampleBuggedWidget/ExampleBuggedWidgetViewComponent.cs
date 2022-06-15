using System;
using System.Linq;
using CMS.DocumentEngine;
using CMS.MediaLibrary;
using CMS.SiteProvider;

using DancingGoat.Widgets;

using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

[assembly: RegisterWidget(ExampleBuggedWidgetViewComponent.IDENTIFIER, typeof(ExampleBuggedWidgetViewComponent), "ExampleBugged", typeof(ExampleBuggedWidgetProperties), Description = "ExampleBugged")]

namespace DancingGoat.Widgets
{
    /// <summary>
    /// ExampleBugged widget service.
    /// </summary>
    public class ExampleBuggedWidgetViewComponent : ViewComponent
    {
        /// <summary>
        /// Widget identifier.
        /// </summary>
        public const string IDENTIFIER = "DancingGoat.HomePage.ExampleBuggedWidget";

        private readonly IPageAttachmentUrlRetriever mPageAttachmentUrlRetriever;
        private readonly IAttachmentInfoProvider mAttachmentInfoProvider;
        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleBuggedWidgetViewComponent"/> class.
        /// </summary>
        /// <param name="mediaFileProvider">The media file provider.</param>
        /// <param name="fileUrlRetriever">The media file URL retriever.</param>
        public ExampleBuggedWidgetViewComponent(IPageAttachmentUrlRetriever pageAttachmentUrlRetriever, IAttachmentInfoProvider attachmentInfoProvider)
        {
            mPageAttachmentUrlRetriever = pageAttachmentUrlRetriever;
            mAttachmentInfoProvider = attachmentInfoProvider;
        }


        public ViewViewComponentResult Invoke(ExampleBuggedWidgetProperties properties)
        {
            var imageGuid = properties.ImageItems.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return View("~/Components/Widgets/ExampleBuggedWidget/_ExampleBuggedWidget.cshtml", new ExampleBuggedWidgetModel());
            }

            var image = mAttachmentInfoProvider.Get(imageGuid, SiteContext.CurrentSiteID);

            //The below makes the varient url work, but throws exception on saving the document.
            //image.GenerateVariant( new AttachmentVariantContext(), "ImageWidgetDesktopImageVariant");

            IPageAttachmentUrl url = mPageAttachmentUrlRetriever.Retrieve(image);

            ExampleBuggedWidgetModel model = new ExampleBuggedWidgetModel
            {
                ImageURL = url.RelativePath,
                ImageVarientURL = url.WithVariant("ImageWidgetDesktopImageVariant").RelativePath
            };
            return View("~/Components/Widgets/ExampleBuggedWidget/_ExampleBuggedWidget.cshtml", model);
        }
    }
}