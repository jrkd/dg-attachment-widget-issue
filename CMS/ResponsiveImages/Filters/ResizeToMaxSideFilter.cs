using CMS.Core;
using CMS.Helpers;
using CMS.ResponsiveImages;
using System.Collections.Generic;
using System.Drawing;

namespace BrowneJacobson.ResponsiveImages
{
    /// <summary>
    /// Filter for resizing image to be the smallest size possible while being larger than or equal to specified size.
    /// </summary>
    public class ResizeToMaxSideFilter : IImageFilter
    {
        private int Width
        {
            get;
            set;
        }

        private int Height
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor, creates a new instance of <see cref="ResizeImageFilter" />.
        /// </summary>
        /// <param name="width">Resize width in pixels. Use <see cref="ImageHelper.AUTOSIZE"/> to compute the width automatically with aspect ratio.</param>
        /// <param name="height">Resize height in pixels. Use <see cref="ImageHelper.AUTOSIZE"/> to compute the height automatically with aspect ratio.</param>
        public ResizeToMaxSideFilter(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Applies the filter on the image data.
        /// </summary>
        /// <param name="container">Input image container.</param>
        /// <returns>
        /// New instance of <see cref="ImageContainer"/> with the applied filter or <c>null</c> when the filter was not applied.
        /// </returns>
        public ImageContainer ApplyFilter(ImageContainer container)
        {
            using (var stream = container.OpenReadStream())
            {
                var metadata = container.Metadata;
                var imageHelper = new ImageHelper(BinaryData.GetByteArrayFromStream(stream), metadata.Width, metadata.Height);

                // Resize image
                var resizedImage = GetResizedImage(imageHelper);

                var resizedImageData = imageHelper.ImageToBytes(resizedImage);
                var resizedMetadata = new ImageMetadata(resizedImage.Width, resizedImage.Height, metadata.MimeType, metadata.Extension);

                return new ImageContainer(resizedImageData, resizedMetadata);
            }
        }

        private Image GetResizedImage(ImageHelper imageHelper)
        {
            Dictionary<string, int> dimensions = GetTargetDimensions(imageHelper);
            return imageHelper.GetResizedImage(dimensions["width"], dimensions["height"]);
        }

        /// <summary>
        /// Get the width and height of the output image
        /// </summary>
        /// <param name="imageHelper"></param>
        /// <returns></returns>
        private Dictionary<string, int> GetTargetDimensions(ImageHelper imageHelper)
        {
            int rawWidth = imageHelper.ImageWidth;
            int rawHeight = imageHelper.ImageHeight;

            double scaledWidthMultiplier = Width / (double)rawWidth;
            double scaledHeightMultiplier = Height / (double)rawHeight;

            int widthUsingHeight = (int)(rawWidth * scaledHeightMultiplier);
            int heightUsingWidth = (int)(rawHeight * scaledWidthMultiplier);

            int outputWidth = Width;
            int outputHeight = heightUsingWidth;

            if (heightUsingWidth < Height)
            {
                outputWidth = widthUsingHeight;
                outputHeight = Height;
            }

            return new Dictionary<string, int>() {
                { "width", outputWidth },
                { "height", outputHeight }
            };
        }
    }
}
