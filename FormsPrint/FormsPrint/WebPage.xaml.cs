using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPrint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebPage : ContentPage
    {
		ViewModels.PrintListViewModel ViewModel;
		public WebPage(WebViewSource webpage)
        {
            InitializeComponent();
			ViewModel = new ViewModels.PrintListViewModel();
			BindingContext = ViewModel;
			webView.Source = webpage;
        }
		void PrintList(object sender, System.EventArgs e)
		{
			// New up the Razor template
			var printTemplate = new PrintTemplates.ListPrintTemplate();

			// Set the model property (ViewModel is a custom property within containing view - FYI)
			printTemplate.Model = ViewModel.Prints.ToList();

			// Generate the HTML
			var htmlString = printTemplate.GenerateString();

			// Create a source for the webview
			var htmlSource = new HtmlWebViewSource();
			htmlSource.Html = htmlString;

			// Create and populate the Xamarin.Forms.WebView
			var printService = DependencyService.Get<IPrintService>();
			printService.Print(webView);
		}
	}
}