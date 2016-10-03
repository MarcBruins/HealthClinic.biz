using System;
using MvvmCross.Platform.Converters;
using Xamarin.Forms;

namespace MyHealth.Client.Core
{
	public class NotConverter : MvxValueConverter<bool, bool>, IValueConverter
	{
		protected override bool Convert (bool value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return !value;
		}
	}
}

