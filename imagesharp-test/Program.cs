using SixLabors.ImageSharp.Processing;

class Program
{
    static void Main()
    {
        var originalImage = "original.jpg";
        var picturesFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        var originalImagePath = Directory.EnumerateFiles(picturesFolderPath).FirstOrDefault(p => p.Contains(originalImage));
        
        var modifications = new Action<IImageProcessingContext>[]
        {
        i => i.Flip(FlipMode.Horizontal),
        i => i.Rotate(RotateMode.Rotate90),
        i => i.Rotate(RotateMode.Rotate180)
        };

        Modification.Modification.ModifyImage(originalImagePath, modifications);
    }
}