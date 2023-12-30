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
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Static(typeof(ICornerRadiusFilterConverterStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Activatable(65536u, "Microsoft.UI.Xaml.XamlContract")]
	public sealed class CornerRadiusFilterConverter : DependencyObject, ICornerRadiusFilterConverter, IValueConverter
	{
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		public extern double Scale
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		public extern CornerRadiusFilterKind Filter
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			[param: In]
			set;
		}

		public static extern DependencyProperty FilterProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ScaleProperty
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
