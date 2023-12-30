using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Activatable(65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(ICornerRadiusToThicknessConverterStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	public sealed class CornerRadiusToThicknessConverter : DependencyObject, ICornerRadiusToThicknessConverter, IValueConverter
	{
		[MUXPropertyDefaultValue(value = "1.0f")]
		[MUXPropertyDefaultValue(value = "1.0f")]
		public extern double Multiplier
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0f")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0f")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		public extern CornerRadiusToThicknessConverterKind ConversionKind
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			[param: In]
			set;
		}

		public static extern DependencyProperty ConversionKindProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MultiplierProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern object Convert([In] object value, [In] Type targetType, [In] object parameter, [In] string language);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern object ConvertBack([In] object value, [In] Type targetType, [In] object parameter, [In] string language);
	}
}
