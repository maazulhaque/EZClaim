using System.Collections.Generic;
using Xamarin.Forms;

namespace EZClaim
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

			var masterPageItems = new List<MasterPageItem> ();

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Notify Agent",
                IconSource = "call.png",
                TargetType = typeof(CallAgentPage)
            });
            masterPageItems.Add (new MasterPageItem {
				Title = "Auto Information",
				IconSource = "car.png",
				TargetType = typeof(AutoListPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Home Information",
				IconSource = "home.png",
				TargetType = typeof(HomeListPage)
			});

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Advice Center",
                IconSource = "info.png",
                TargetType = typeof(AdvicePage)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Account Settings",
                IconSource = "settings.png",
                TargetType = typeof(SettingsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Sign out",
                IconSource = "logout.png",
                TargetType = typeof(string),
    });

            listView.ItemsSource = masterPageItems;
		}
	}
}
