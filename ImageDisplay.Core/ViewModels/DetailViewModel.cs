namespace ImageDisplay.Core.ViewModels
{
    #region USINGS 
    using ImageDisplay.Core.DataService;
    using ImageDisplay.Core.Model;
    using MvvmCross.Core.ViewModels;
    #endregion

    /// <summary>
    /// Detailed ImageItem ViewModel
    /// </summary>
    public class DetailViewModel : MvxViewModel
    {
        #region FIELDS
        /// <summary>
        /// Creating IDataService Field.
        /// </summary>
        private readonly IDataService dataService;
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets or sets image Name. 
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); RaisePropertyChanged(() => Name); }
        }

        /// <summary>
        /// Gets or sets image ImageItem. 
        /// </summary>
        private ImageItem imageItem;
        public ImageItem ImageItem
        {
            get { return imageItem; }
            set { SetProperty(ref imageItem, value); RaisePropertyChanged(() => ImageItem); }
        }

        /// <summary>
        /// Gets or sets image Progress for slider. 
        /// </summary>
        private double progress = 3;
        public double Progress
        {
            get { return progress; }
            set { SetProperty(ref progress, value); RaisePropertyChanged(() => Progress); }
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Public DetailViewModel octor.
        /// </summary>
        /// <param name="dataService">Interface IDataService.</param>
        public DetailViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
        #endregion

        #region HELPER
        /// <summary>
        /// Inner class 
        /// </summary>
        public class NavigateToClass
        {
            public int Id { get; set; }
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Init method initialize setting selected ImageItem to property
        /// </summary>
        /// <param name="nav"></param>
        public void Init(NavigateToClass nav)
        {
            ImageItem = dataService.Get(nav.Id);
        }
#endregion

    }
}
