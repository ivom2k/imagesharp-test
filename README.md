**Basic image manipulations**

1. Flipping - Horizontal axis flipping is much more common than flipping the vertical axis.
2. Color space - Very simple color augmentations include isolating a single color channel such as R, G, or B. An image can be quickly converted into its representation in one color channel by isolating that matrix and adding 2 zero matrices from the other color channels. 
3. Cropping - Cropping images can be used as a practical processing step for image data with mixed height and width dimensions by cropping a central patch of each image.
4. Rotation - Rotation augmentations are done by rotating the image right or left on an axis between 1° and 359°. The safety of rotation augmentations is heavily determined by the rotation degree parameter. Slight rotations such as between 1 and 20 or −1 to−20 could be useful on digit recognition tasks
5. Translation - Shifting images left, right, up, or down can be a very useful transformation to avoid positional bias in the data.
6. Noise injection - Noise injection consists of injecting a matrix of random values usually drawn from a Gaussian distribution. Noise injection is tested by Moreno-Barea et al. on nine datasets from the UCI repository. Adding noise to images can help CNNs learn more robust features
7. Color space transformations

Source: A survey on Image Data Augmentation for Deep Learning