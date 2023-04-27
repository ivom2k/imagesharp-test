using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace Modification
{
    public static class Modification
    {
        public static void ModifyImage(string originalImagePath, params Action<IImageProcessingContext>[] operations)
        {
            var outputFolder = Path.GetDirectoryName(originalImagePath);
            var outputFileName = Path.GetFileNameWithoutExtension(originalImagePath);
            var outputPath = Path.Combine(outputFolder, outputFileName);

            using Image image = Image.Load(originalImagePath);

            foreach (var mutation in operations)
            {
                image.Mutate(mutation);
                image.Save(outputPath + "_" + DateTime.UtcNow.Ticks.ToString() + ".jpg");
            }
        }
    }
}