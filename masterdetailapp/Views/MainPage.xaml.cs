﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace masterdetailapp
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();

			masterPage.ListView.ItemSelected += OnItemSelected;

		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}

