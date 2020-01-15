using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Printing;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: Dependency(typeof(FormsPrint.UWP.Randerer.UWPPrintService))]
namespace FormsPrint.UWP.Randerer
{
    public class UWPPrintService : IPrintService
	{



		/// <summary>
		/// Cans the print.
		/// </summary>
		/// <returns><c>true</c>, if print was caned, <c>false</c> otherwise.</returns>
		public bool CanPrint()
		{
			return PrintManager.IsSupported();
		}

		public void Print(Xamarin.Forms.WebView webView)
		{
			Device.BeginInvokeOnMainThread(async () =>
			{
				var jobName = "Forms Print";
				WebViewPrintHelper printHelper = null;
				if (Platform.GetRenderer(webView) is Xamarin.Forms.Platform.UWP.WebViewRenderer renderer && renderer.Control is Windows.UI.Xaml.Controls.WebView nativeWebView)
					printHelper = new WebViewPrintHelper(nativeWebView, jobName);
				else if (webView.Source is HtmlWebViewSource htmlSource && !string.IsNullOrWhiteSpace(htmlSource.Html))
					printHelper = new WebViewPrintHelper(htmlSource.Html, htmlSource.BaseUrl, jobName);
				else if (webView.Source is UrlWebViewSource urlSource && !string.IsNullOrWhiteSpace(urlSource.Url))
					printHelper = new WebViewPrintHelper(urlSource.Url, jobName);
				if (printHelper != null)
				{
					printHelper.RegisterForPrinting();
					await printHelper.Init();
					bool showprint = await PrintManager.ShowPrintUIAsync();
				}
			});
		}
	}
}
