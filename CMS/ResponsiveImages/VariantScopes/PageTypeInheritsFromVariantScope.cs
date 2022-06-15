using CMS.DocumentEngine;
using CMS.ResponsiveImages;
using System.Linq;

namespace BrowneJacobson.ResponsiveImages
{
    public class PageTypeInerhitsFromVariantScope : IVariantContextScope
    {
        protected string mMasterClassName;

        public PageTypeInerhitsFromVariantScope(string masterClassName)
        {
            mMasterClassName = masterClassName;
        }

        public bool CheckContext(IVariantContext context)
        {
            if (context is AttachmentVariantContext attachmentVariantContext)
            {
                return IsPageInhertFromMasterPageType(attachmentVariantContext.ClassName, mMasterClassName);
            }
            return false;
        }

        private static bool IsPageInhertFromMasterPageType(string actualClassName, string masterClassName)
        {
            var masterPageClassIDQuery = DocumentTypeHelper.GetDocumentTypeClasses().WhereEquals("ClassName", masterClassName).AsSingleColumn("ClassID");
            bool inheritsFromMasterPageType = DocumentTypeHelper.GetDocumentTypeClasses().WhereEquals("ClassName", actualClassName).WhereIn("ClassInheritsFromClassID", masterPageClassIDQuery).Any();
            return inheritsFromMasterPageType;
        }
    }
}
