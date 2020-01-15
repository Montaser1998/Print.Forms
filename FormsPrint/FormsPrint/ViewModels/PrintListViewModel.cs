﻿using FormsPrint.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FormsPrint.ViewModels
{
    public class PrintListViewModel
    {
		public ObservableCollection<PrintModel> Prints { get; set; } = new ObservableCollection<PrintModel>();
		public string Title { get; set; } = "Forms Print";

		public PrintListViewModel()
		{
			// Populate with some dummy data
			Prints.Add(new PrintModel() { ModelDescription = "Description 1", ModelName = "Name 1", ModelDescription1 = "Description 1", ModelDescription2 = "Description 1", ModelDescription3 = "Description 1", ModelDescription4 = "Description 1", ModelDescription5 = "Description 1", ModelDescription6 = "Description 1", ModelDescription7 = "Description 1", ModelDescription8 = "Description 1", ModelDescription9 = "Description 1", ModelDescription10 = "Description 1", ModelDescription11 = "Description 1", ModelDescription12 = "Description 1" });
			Prints.Add(new PrintModel() { ModelDescription = "Description 2", ModelName = "Name 2", ModelDescription1 = "Description 2", ModelDescription2 = "Description 2", ModelDescription3 = "Description 2", ModelDescription4 = "Description 2", ModelDescription5 = "Description 2", ModelDescription6 = "Description 2", ModelDescription7 = "Description 2", ModelDescription8 = "Description 2", ModelDescription9 = "Description 2", ModelDescription10 = "Description 2", ModelDescription11 = "Description 2", ModelDescription12 = "Description 2" });
			Prints.Add(new PrintModel() { ModelDescription = "Description 3", ModelName = "Name 3", ModelDescription1 = "Description 3", ModelDescription2 = "Description 3", ModelDescription3 = "Description 3", ModelDescription4 = "Description 3", ModelDescription5 = "Description 3", ModelDescription6 = "Description 3", ModelDescription7 = "Description 3", ModelDescription8 = "Description 3", ModelDescription9 = "Description 3", ModelDescription10 = "Description 3", ModelDescription11 = "Description 3", ModelDescription12 = "Description 3" });
		}
	}
}
