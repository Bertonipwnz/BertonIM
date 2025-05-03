namespace BertoniIM.UWP.Views.Pages
{
	using BertoniIM.UWP.ViewModels.Pages;
	using Windows.UI.Xaml.Controls;

	/// <summary>
	/// Страница чатов.
	/// </summary>
	public sealed partial class ChatsPage : Page
	{
		#region Private Fields

		/// <summary>
		/// Модель представления страницы.
		/// </summary>
		private ChatsPageViewModel _viewModel;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Инициализирует <see cref="ChatsPage"/>
		/// </summary>
		public ChatsPage()
		{
			_viewModel = new ChatsPageViewModel();
			DataContext = _viewModel;
			this.InitializeComponent();
		}

		#endregion Public Constructors
	}
}
