﻿using System;
using Tasky.Shared;
using Android.Widget;
using Android.App;
using System.Collections.Generic;

namespace MLearning.Droid
{
	public class FavoritosItemListAdapter : BaseAdapter<FavoritosItem> 
	{
		Activity context = null;
		IList<FavoritosItem> tasks = new List<FavoritosItem>();

		public FavoritosItemListAdapter (Activity context, IList<FavoritosItem> tasks) : base ()
		{
			this.context = context;
			this.tasks = tasks;
		}

		public override FavoritosItem this[int position]
		{
			get { return tasks[position]; }
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override int Count
		{
			get { return tasks.Count; }
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			// Get our object for position
			var item = tasks[position];			

			//Try to reuse convertView if it's not  null, otherwise inflate it from our item layout
			// gives us some performance gains by not always inflating a new view
			// will sound familiar to MonoTouch developers with UITableViewCell.DequeueReusableCell()

			//			var view = (convertView ?? 
			//					context.LayoutInflater.Inflate(
			//					Resource.Layout.TaskListItem, 
			//					parent, 
			//					false)) as LinearLayout;
			//			// Find references to each subview in the list item's view
			//			var txtName = view.FindViewById<TextView>(Resource.Id.NameText);
			//			var txtDescription = view.FindViewById<TextView>(Resource.Id.NotesText);
			//			//Assign item's values to the various subviews
			//			txtName.SetText (item.Name, TextView.BufferType.Normal);
			//			txtDescription.SetText (item.Notes, TextView.BufferType.Normal);

			// TODO: use this code to populate the row, and remove the above view
			var view = (convertView ??
				context.LayoutInflater.Inflate(
					Android.Resource.Layout.SimpleListItemChecked,
					parent,
					false)) as CheckedTextView;
			view.SetText (item.Titulo==""?"<new task>":item.Titulo, TextView.BufferType.Normal);
			view.Checked = true;//REVISAR


			//Finally return the view
			return view;
		}
	}
}

