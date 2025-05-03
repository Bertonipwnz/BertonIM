// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BertoniIM.UWP.Views.Pages
{
	using BertoniIM.UWP.ViewModels.Pages;
	using Windows.UI.Xaml.Controls;

	/// <summary>
	/// Страница оболочка.
	/// </summary>
	public sealed partial class ShellPage : Page
	{
		#region Private Fields

		/// <summary>
		/// Модель представления страницы.
		/// </summary>
		private ShellPageViewModel _viewModel;

		#endregion Private Fields

		#region Public Constructors

		/// <summary>
		/// Инициализирует <see cref="ShellPage"/>
		/// </summary>
		public ShellPage()
		{
			_viewModel = new ShellPageViewModel();
			DataContext = _viewModel;
			this.InitializeComponent();
		}

		#endregion Public Constructors
	}
}
