namespace BertoniIM.UWP.Views.Pages
{
	using BertoniIM.UWP.ViewModels.Pages;
	using Windows.UI.Xaml.Controls;

	/// <summary>
	/// Страница логина.
	/// </summary>
	public sealed partial class LoginPage : Page
	{
		#region Private Fields

		/// <summary>
		/// Модель представления страницы.
		/// </summary>
		private LoginPageViewModel _viewModel;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Инициализирует <see cref="LoginPage"/>
		/// </summary>
		public LoginPage()
		{
			_viewModel = new LoginPageViewModel();
			DataContext = _viewModel;
			this.InitializeComponent();
		}

		#endregion Public Constructors
	}
}
