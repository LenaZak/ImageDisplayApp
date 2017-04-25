namespace ImageDisplay.Core.DataService
{
    #region USINGS
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ImageDisplay.Core.Model;
    using SQLite;
    using MvvmCross.Plugins.Sqlite;
    #endregion

    /// <summary>
    /// DataService class is responsible for executing DB operations
    /// </summary>
    class DataService : IDataService
    {
        #region CONSTRUCTOR
        /// <summary>
        /// DataService Constructor
        /// </summary>
        /// <param name="dataFactory">Holds methods for db operations</param>
        /// <returns name="DataService list">Return service.</returns>
        public DataService(IMvxSqliteConnectionFactory dataFactory)
        {
            connection = dataFactory.GetConnection("imageDisplay.sql");
            connection.CreateTable<ImageItem>();
        }
        #endregion

        #region FIELDS
        /// <summary>
        /// DB Connection field.
        /// </summary>
        private readonly SQLiteConnection connection;
        #endregion
       
        #region IMPLEMENTED METHODS

        public void Delete(ImageItem imageItem)
        {
            connection.Delete(imageItem);
        }

        public void Insert(ImageItem imageItem)
        {
            connection.Insert(imageItem);
        }

        public void Update(ImageItem imageItem)
        {
            connection.Update(imageItem);
        }

        public List<ImageItem> ImageSorting()
        {
            return connection.Table<ImageItem>()
                .OrderByDescending(x => x.UploadDate).ToList();
        }

        public ImageItem Get(int id)
        {
            return connection.Get<ImageItem>(x => x.Id == id);
        }

        #endregion
    }
}
