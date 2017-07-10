using System;
using Xamarin.Forms;

namespace EZClaim
{
	public partial class MainPage : MasterDetailPage
	{
        private ILoginManager _loginManager;

        public MainPage (ILoginManager ilm)
		{
			InitializeComponent ();

			masterPage.ListView.ItemSelected += OnItemSelected;
            _loginManager = ilm;

        }

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null) {
                if (item.Title.Equals("Sign out"))
                {
                    _loginManager.Logout();
                }
                else
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
                    {
                        BarBackgroundColor = Color.FromHex("#367aa3"),
                        BarTextColor = Color.White,
                    };
                    //masterPage.ListView.SelectedItem = null;
                    IsPresented = false;
                }
			}
		}
	}
}
