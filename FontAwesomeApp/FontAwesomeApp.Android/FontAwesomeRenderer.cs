using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FontAwesomeApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(FontAwesomeRenderer))]
namespace FontAwesomeApp.Droid
{
	public class FontAwesomeRenderer : ButtonRenderer
	{
		private Context ctx;

		public FontAwesomeRenderer(Context context) : base (context)
		{
			this.ctx = context;	
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);
			if (e.NewElement != null && e.NewElement.FontFamily == "Font Awesome 5 Free")
			{
				var font = Typeface.CreateFromAsset(this.ctx.ApplicationContext.Assets, "fa-regular-400.ttf");

			}
		}
	}
}