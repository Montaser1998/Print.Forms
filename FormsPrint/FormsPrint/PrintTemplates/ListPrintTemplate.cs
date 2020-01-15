#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormsPrint.PrintTemplates
{
using System;

#line 1 "ListPrintTemplate.cshtml"
using System.Collections.Generic;

#line default
#line hidden
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "16.4.0.308")]
public partial class ListPrintTemplate : ListPrintTemplateBase
{

#line hidden

#line 2 "ListPrintTemplate.cshtml"
public List<FormsPrint.Models.PrintModel> Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html");

WriteLiteral(" lang=\"en\"");

WriteLiteral(">\r\n<head>\r\n\t<!-- iOS - needs to reside in the \"Resources\" directory and have buil" +
"d action of \"BundleResource\" -->\r\n\t<!-- Droid - needs to reside in \"Assets\" dire" +
"ctory and have build action of \"AndroidAsset\" -->\r\n\t<meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n\t<meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\"");

WriteLiteral(">\r\n\r\n\t<!-- Bootstrap CSS -->\r\n\t");

WriteLiteral("\r\n\t<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"primer.css\"");

WriteLiteral(">\r\n\t<style>\r\n\t\t.content {\r\n\t\t\tmax-width: 100%;\r\n\t\t\tmargin: auto;\r\n\t\t}\r\n\t\ttable, t" +
"h, td {\r\n\t\t  border: 1px solid black;\r\n\t\t  border-collapse: collapse;\r\n\t\t}\r\n\t</s" +
"tyle>\r\n</head>\r\n<body>\r\n\t<div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"blankslate blankslate-spacious\"");

WriteLiteral(">\r\n\t\t\t<h3>Xamarin Forms EZ-Print!</h3>\r\n\t\t\t<p>Even works using the CSS frameworks" +
" like Primer!</p>\r\n\t\t</div>\r\n\t\t<div");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n\t\t\t<table");

WriteLiteral(" class=\"table table-sm\"");

WriteLiteral(">\r\n\t\t\t\t<thead>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelName</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription1</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription2</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription3</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription4</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription5</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription6</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription7</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription8</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription10</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription11</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription12</th>\r\n\t\t\t\t\t\t<th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">ModelDescription13</th>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</thead>\r\n\t\t\t\t<tbody>\r\n");


#line 52 "ListPrintTemplate.cshtml"
					

#line default
#line hidden

#line 52 "ListPrintTemplate.cshtml"
                     foreach (var item in Model)
					{


#line default
#line hidden
WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 56 "ListPrintTemplate.cshtml"
                           Write(item.ModelName);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 59 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 62 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription1);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 65 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription2);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 68 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription3);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 71 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription4);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 74 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription5);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 77 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription6);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 80 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription7);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 83 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription8);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 86 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription9);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 89 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription10);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 92 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription11);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");


#line 95 "ListPrintTemplate.cshtml"
                           Write(item.ModelDescription12);


#line default
#line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n");


#line 98 "ListPrintTemplate.cshtml"
					}


#line default
#line hidden
WriteLiteral("\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n</body>\r\n</html>\r\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class ListPrintTemplateBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591