using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FormsPrint
{
	public interface IPrintService
	{
		void Print(WebView viewToPrint);
		string Get();
	}
}
