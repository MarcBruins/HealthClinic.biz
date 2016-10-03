using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace MyHealth.Client.Core
{
	public class DateTimeToHourMinutesIndicatorConverter : MvxValueConverter<DateTime, string>
	{
		protected override string Convert (DateTime value, Type targetType, object parameter, CultureInfo culture)
		{
            var fi = new DateTimeFormatInfo
            {
                AMDesignator = "am",
                PMDesignator = "pm"
            };

            var date = value.ToString ("h:mm tt", fi);

			return date;
		}
	}
}

