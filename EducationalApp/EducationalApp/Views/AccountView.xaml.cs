using EducationalApp.ViewModels;

namespace EducationalApp.Views;

public partial class AccountView : ContentPage
{
	public AccountView(AccountViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (this.BindingContext is AccountViewModel viewModel)
        {
            viewModel.OnAppearingAsync();
        }
    }
}