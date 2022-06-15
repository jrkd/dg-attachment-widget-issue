using System;
using System.Collections.Generic;

using CMS.SiteProvider;
using CMS.DocumentEngine;

using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Linq;

namespace DancingGoat.Widgets
{
    /// <summary>
    /// Example Bugged widget properties.
    /// </summary>
    public class ExampleBuggedWidgetProperties : IWidgetProperties
    {

        /// <summary>
        /// Guid of an image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(AttachmentSelector.IDENTIFIER, Order = 0, Label = "Attached image selector")]
        public IEnumerable<AttachmentSelectorItem> ImageItems { get; set; } = Enumerable.Empty<AttachmentSelectorItem>();
    }
}