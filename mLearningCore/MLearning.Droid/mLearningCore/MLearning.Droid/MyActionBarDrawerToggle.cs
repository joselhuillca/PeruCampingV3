﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using SupportActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;
using Android.Support.V7.App;
using Android.Support.V4.Widget;


namespace MLearning.Droid
{
	public class MyActionBarDrawerToggle : SupportActionBarDrawerToggle
	{
		private MvxActionBarActivity mHostActivity;
		private int mOpenedResource;
		private int mClosedResource;

		public MyActionBarDrawerToggle (MvxActionBarActivity host, DrawerLayout drawerLayout, int openedResource, int closedResource) 
			: base(host, drawerLayout, openedResource, closedResource)
		{
			mHostActivity = host;
			mOpenedResource = openedResource;
			mClosedResource = closedResource;
		}

		public override void OnDrawerOpened (Android.Views.View drawerView)
		{	
			int drawerType = (int)drawerView.Tag;

			if (drawerType == 0)
			{
				base.OnDrawerOpened (drawerView);
				mHostActivity.SupportActionBar.SetTitle(mOpenedResource);
			}
		}

		public override void OnDrawerClosed (Android.Views.View drawerView)
		{
			int drawerType = (int)drawerView.Tag;

			if (drawerType == 0)
			{
				base.OnDrawerClosed (drawerView);
				mHostActivity.SupportActionBar.SetTitle(mClosedResource);
			}				
		}

		public override void OnDrawerSlide (Android.Views.View drawerView, float slideOffset)
		{
			int drawerType = (int)drawerView.Tag;

			if (drawerType == 0)
			{
				base.OnDrawerSlide (drawerView, slideOffset);
			}
		}
	}
}

