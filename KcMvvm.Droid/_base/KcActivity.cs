using System;
using Cirrious.MvvmCross.Droid.Views;
using KcMvvm.Core;
using Android.Widget;

namespace KcMvvm.Droid
{
	public abstract class KcActivity<T> : MvxActivity<T>
		where T: KcViewModel
	{
		public KcActivity ()
		{
		}

		public void ShowToastMessage(string message, ToastLength duration)
		{
			RunOnUiThread (() => Toast.MakeText(this,message,duration).Show());
		}
	}
}

