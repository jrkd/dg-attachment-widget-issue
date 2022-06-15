using CMS.DocumentEngine;
using CMS.ResponsiveImages;
using System.Linq;

namespace BrowneJacobson.ResponsiveImages
{
    public class CMSOnlyVariantScope : IVariantContextScope
    {
        private string mClassName;
        public CMSOnlyVariantScope(string className = "")
        {
            mClassName = className; 
        }

        public bool CheckContext(IVariantContext context)
        {
            if (context is AttachmentVariantContext attachmentVariantContext)
            {
                bool isInPageBuilderTab = CMS.Helpers.RequestContext.URL.LocalPath.Contains("CMSModules/Content/CMSDesk/MVC/Edit.aspx");
                if (string.IsNullOrEmpty(mClassName))
                {
                    return !isInPageBuilderTab;
                }
                else
                {
                    return !isInPageBuilderTab && attachmentVariantContext.ClassName == mClassName;
                }
            }
            return true;
        }
    }
}
