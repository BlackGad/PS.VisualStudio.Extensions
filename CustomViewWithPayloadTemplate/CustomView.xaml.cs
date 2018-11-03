namespace $rootnamespace$
{
    [DependencyRegisterAsSelf]
    [DependencyRegisterAsInterface(typeof(IView<$safeitemname$Model>))]
    public partial class $safeitemname$ : IView<$safeitemname$Model>
    {
        #region Constructors

        public $safeitemname$()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        [DependencyResolve]
        public $safeitemname$Model ViewModel
        {
            get { return DataContext as $safeitemname$Model; }
            set { DataContext = value; }
        }

        #endregion
    }
}