namespace ImageDisplay.Core.ViewModels
{
    #region USINGS 
    using ImageDisplay.Core.DataService;
    using ImageDisplay.Core.Model;
    using MvvmCross.Core.ViewModels;
    using System.Collections.Generic;
    using System.Windows.Input;
    #endregion

    /// <summary>
    /// ImageItem ViewModel
    /// </summary>
    public class ImageMainViewModel 
        : MvxViewModel
    {
        #region FIELDS
        /// <summary>
        /// Creating IDataService Field.
        /// </summary>
        private readonly IDataService dataService;

        /// <summary>
        ///  Creating IImageGeneratingService Field.
        /// </summary>
        private readonly IImageGeneratingService iImageGeneratingService;
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets or sets Image list.
        /// </summary>
        private List<ImageItem> imageItems;
        public List<ImageItem> ImageItems
        {
            get { return imageItems; }
            set { SetProperty(ref imageItems, value); RaisePropertyChanged(() => ImageItems); }
        }

        /// <summary>
        /// Gets or sets image UrlAdress. 
        /// </summary>
        private string urlAdress = "https://lorempixel.com/329/200";
        public string UrlAdress
        {
            get { return urlAdress; }
            set { SetProperty(ref urlAdress, value); RaisePropertyChanged(() => UrlAdress); }
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Public ImageViewModel octor.
        /// </summary>
        /// <param name="dataService">Interface IDataService.</param>
        /// <param name="iImageGeneratingServicet">Interface IImageGeneratingService.</returns>
        public ImageMainViewModel(IDataService dataService, IImageGeneratingService iImageGeneratingService)
        {
            this.dataService = dataService;
            this.iImageGeneratingService = iImageGeneratingService;
            ApplySorting();
        }
        #endregion

        #region COMMANDS
        /// <summary>
        /// Responsible for adding images items.
        /// </summary>
        private MvxCommand openUrlCommand;
        public ICommand OpenUrlCommand
        {
            get
            {
                openUrlCommand = openUrlCommand ?? new MvxCommand(DoOpenUrlDialog);
                return openUrlCommand;
            }
        }

        /// <summary>
        /// Command for opening DetailViewModel which passes selected item from collection.
        /// </summary>
        public ICommand ShowDetailCommand
        {
            get
            {
                return new MvxCommand<ImageItem>(item => ShowViewModel<DetailViewModel>(new DetailViewModel.NavigateToClass() { Id = item.Id }));
            }
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Responsible for sorting images items.
        /// </summary>
        private void ApplySorting()
        {
            ImageItems = dataService.ImageSorting();
        }
        /// <summary>
        /// Responsible for adding images items.
        /// </summary>
        private void DoOpenUrlDialog()
                    {
                        var imageItem = iImageGeneratingService.CreateNewImage("This is: ", UrlAdress);
                        dataService.Insert(imageItem);
                        ApplySorting();

                    }
          #endregion
    }
}
