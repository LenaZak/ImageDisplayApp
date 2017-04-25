namespace ImageDisplay.Core.Model
{
    #region USINGS
    using SQLite;
    using System;
    #endregion

    /// <summary>
    /// ImageItem represents image propeties stored in DB.
    /// </summary>
    public class ImageItem
    {
        #region PROPERTIES
        /// <summary>
        /// Gets or sets the id of the image. 
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the image. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date of image upload. 
        /// </summary>
        public DateTime UploadDate { get; set; }

        /// <summary>
        /// Gets or sets the imageurl. 
        /// </summary>
        public string ImageUrl { get; set; }

        public int GetSizeInBytes()
        {
            throw new NotImplementedException();
        }
        #region HELPER
        /// <summary>
        ///Return Image Name and Creation Date String.
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0} {1}", Name, UploadDate.ToString());
        }
        #endregion
        #endregion
    }
}
