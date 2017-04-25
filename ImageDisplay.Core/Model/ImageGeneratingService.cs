namespace ImageDisplay.Core.Model
{
    #region USINGS
    using System;
    using System.Collections.Generic;
    #endregion

    /// <summary>
    /// DataService class is responsible for generating image items.
    /// </summary>
    class ImageGeneratingService : IImageGeneratingService
    {
        #region FIELDS
        /// <summary>
        /// Random number.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// List of random images name.
        /// </summary>
        private readonly List<string> randomListOfNames = new List<string>() {
            "Bike",
            "Woman",
            "Camera",
            "Book",
            "Laptop",
            "Flower",
            "Tea",
            "Phone"};
        #endregion

        #region METHODS
        /// <summary>
        /// Generating random number. 
        /// </summary>
        /// <param name="count">Range of numbers.</param>
        /// <returns name="int list">Random int value.</returns>
        protected int RandomNumberFromRange(int count)
        {
            return random.Next(count);
        }
        #endregion

        #region INTERFACE IMPLEMENTATION
        /// <summary>
        /// Implemntation of CreateNewImage interface method
        /// </summary>
        /// <returns name="ImageItem">Return filled Image object.</returns>
        public ImageItem CreateNewImage(string imageName = "", string imageURL = "")
        {
            return new ImageItem()
            {
                Name = imageName  + randomListOfNames[RandomNumberFromRange(randomListOfNames.Count)],
                ImageUrl = imageURL,
                UploadDate = DateTime.Now
            };
        }

        #endregion
    }
}
