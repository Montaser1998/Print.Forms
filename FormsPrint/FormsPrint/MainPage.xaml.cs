using FormsPrint.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsPrint
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
		PrintListViewModel ViewModel;
		public MainPage()
        {
            InitializeComponent();
			ViewModel = new PrintListViewModel();
			BindingContext = ViewModel;
		}

		void Web(object sender, System.EventArgs e)
		{
			var printTemplate = new PrintTemplates.ListPrintTemplate();

			// Set the model property (ViewModel is a custom property within containing view - FYI)
			printTemplate.Model = ViewModel.Prints.ToList();

			// Generate the HTML
			var htmlString = printTemplate.GenerateString();

			// Create a source for the webview
			var htmlSource = new HtmlWebViewSource();
			htmlSource.Html = htmlString;

			// Create and populate the Xamarin.Forms.WebView
			Navigation.PushAsync(new WebPage(htmlSource));

		}

	}
}
