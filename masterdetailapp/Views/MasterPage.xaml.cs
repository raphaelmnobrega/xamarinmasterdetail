using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace masterdetailapp
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Detail Page 1",
				//IconSource = "contacts.png",
				TargetType = typeof(DetailPageOne)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Detail Page 2",
				//IconSource = "todo.png",
				TargetType = typeof(DetailPageTwo)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Detail Page 3",
				//IconSource = "reminders.png",
				TargetType = typeof(DetailPageThree)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}

