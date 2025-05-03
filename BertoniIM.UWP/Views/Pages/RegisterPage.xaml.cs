namespace BertoniIM.UWP.Views.Pages
{
	using BertoniIM.UWP.ViewModels.Pages;
	using Windows.UI.Xaml.Controls;
	
	/// <summary>
	/// Страница регистрации.
	/// </summary>
	public sealed partial class RegisterPage : Page
	{
		#region Private Fields

		/// <summary>
		/// Модель представления страницы.
		/// </summary>
		private RegisterPageViewModel _viewModel;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Инициализирует <see cref="RegisterPage"/>
		/// </summary>
		public RegisterPage()
		{
			_viewModel = new RegisterPageViewModel();
			DataContext = _viewModel;
			this.InitializeComponent();
		}

		#endregion Public Constructors
	}
}
