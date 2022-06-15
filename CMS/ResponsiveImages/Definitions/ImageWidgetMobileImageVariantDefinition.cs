using System.Collections;
using System.Collections.Generic;
using BrowneJacobson.ResponsiveImages;
using CMS.DocumentEngine;
using CMS.Helpers;
using CMS.ResponsiveImages;

[assembly: RegisterImageVariantDefinition(typeof(ImageWidgetMobileImageVariantDefinition))]
namespace BrowneJacobson.ResponsiveImages
{
    /// <summary>
    /// Hero image desktop variant definition.
    /// </summary>
    public class ImageWidgetMobileImageVariantDefinition : ImageVariantDefinition
    {
        public override string Identifier => "ImageWidgetMobileImageVariant";

        /// <summary>
        /// Returns context scopes to restrict variant application.
        /// </summary>
        public override IEnumerable<IVariantContextScope> ContextScopes
        {
            get
            {
                return new[] {
                    new PageBuilderVariantScope()
                };
            }
        }

        /// <summary>
        /// Collection of filters used for variant generation.
        /// </summary>
        public override IEnumerable<IImageFilter> Filters
        {
            get
            {
                return new IImageFilter[]
                {
                    new ResizeToMaxSideFilter(ImageHelper.AUTOSIZE, 760),
                    new CropImageFilter(760, 450, ImageHelper.ImageTrimAreaEnum.MiddleCenter)
                };
            }
        }
    }
}
