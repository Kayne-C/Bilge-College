using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.IO;

namespace Bilge_College.Hubs
{

    public class ImageResizer
    {
        public void ResizeImage(string filePath, int width, int height, int width1, int height1)
        {
            using (Image<Rgba32> image = Image.Load<Rgba32>(filePath))
            {
                image.Mutate(x => x.Resize(width, height));
                image.Save(filePath);
                image.Mutate(x => x.Resize(width1, height1));
                var fileName = Path.GetFileNameWithoutExtension(filePath);
                var extension = Path.GetExtension(filePath);
                var newFilePath = Path.Combine(Path.GetDirectoryName(filePath), fileName + "_" + width1 + "x" + height1 + extension);
                image.Save(newFilePath);
            }
        }
    }
}
