using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(FormsPrint.iOS.Randerer.iOSPrintService))]
namespace FormsPrint.iOS.Randerer
{
	public class iOSPrintService : IPrintService
	{
		public iOSPrintService()
		{
		}

		public void Print(WebView viewToPrint)
		{
			var appleViewToPrint = Platform.CreateRenderer(viewToPrint).NativeView;

			var printInfo = UIPrintInfo.PrintInfo;

			printInfo.OutputType = UIPrintInfoOutputType.General;
			printInfo.JobName = "Forms Print";
			printInfo.Orientation = UIPrintInfoOrientation.Portrait;
			printInfo.Duplex = UIPrintInfoDuplex.None;

			var printController = UIPrintInteractionController.SharedPrintController;

			printController.PrintInfo = printInfo;
			printController.ShowsPageRange = true;
			printController.PrintFormatter = appleViewToPrint.ViewPrintFormatter;

			printController.Present(true, (printInteractionController, completed, error) => { });
		}
	}
}