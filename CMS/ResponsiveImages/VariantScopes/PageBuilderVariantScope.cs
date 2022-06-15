using CMS.DocumentEngine;
using CMS.ResponsiveImages;
using System.Linq;

namespace BrowneJacobson.ResponsiveImages
{
    public class PageBuilderVariantScope : IVariantContextScope
    {
        public PageBuilderVariantScope()
        {
        }

        public bool CheckContext(IVariantContext context)
        {
            if (context is AttachmentVariantContext)
            {
                bool isInPageBuilderTab = CMS.Helpers.RequestContext.URL.LocalPath.Contains("CMSModules/Content/CMSDesk/MVC/Edit.aspx");
                return isInPageBuilderTab;
            }
            return false;
        }
    }
}
