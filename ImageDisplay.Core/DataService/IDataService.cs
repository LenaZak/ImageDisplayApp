namespace ImageDisplay.Core.DataService
{
    #region USINGS
    using ImageDisplay.Core.Model;
    using System.Collections.Generic;
    #endregion

    /// <summary>
    /// Service interface publishing CRUD methods
    /// </summary>
    public interface IDataService
    {
        #region METHODS
        /// <summary>
        /// ImageItem represents image propeties stored in DB.
        /// </summary>
        /// <param name="message">Filter string.</param>
        /// <returns name="ImageItem list">Return list sorted by given prop.</returns>
        List<ImageItem> ImageSorting();

        /// <summary>
        /// ImageItem DB row insert.
        /// </summary>
        /// <param name="message">ImageItem object to insert.</param>
        void Insert(ImageItem imageItem);

        /// <summary>
        /// ImageItem DB row update.
        /// </summary>
        /// <param name="message">ImageItem object to update.</param>
        void Update(ImageItem imageItem);

        /// <summary>
        /// ImageItem DB row delete.
        /// </summary>
        /// <param name="message">ImageItem object to delete.</param>
        void Delete(ImageItem imageItem);

        /// <summary>
        /// Get ImageItem
        /// </summary>
        /// <param name="id">ImageItem object to get.</param>
        ImageItem Get(int id);
        #endregion
    }
}
