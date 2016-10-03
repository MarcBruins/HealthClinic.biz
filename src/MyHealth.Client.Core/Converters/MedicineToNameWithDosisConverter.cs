using System;
using MvvmCross.Platform.Converters;
using MyHealth.Client.Core.Model;

namespace MyHealth.Client.Core
{
	public class MedicineToNameWithDosisConverter : MvxValueConverter<Medicine, string>
	{
		protected override string Convert (Medicine value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == null)
				return string.Empty;
            return $"{value.Name} {value.Dose}{value.DoseUnit.ToString().ToLowerInvariant()}";
		}
	}
}   

