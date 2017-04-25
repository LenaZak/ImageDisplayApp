namespace ImageDisplay.Core.Model
{
    #region USINGS
    #endregion

    /// <summary>
    /// Publishing ImageItem.
    /// </summary>
    public interface IImageGeneratingService
    {
        #region METHODS
        /// <summary>
        /// Creating new Images
        /// </summary>
        /// <param name="imageName">TO DO in future: provide image name.</param>
        /// <param name="imageURL">Prvide image URL for download.</param>
        /// <returns name="ImageItem list">Return Image object.</returns>
        ImageItem CreateNewImage(string imageName = "", string imageURL = "");
        #endregion

    }
}
