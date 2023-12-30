using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Interop;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C1 RID: 449
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(ICornerRadiusToThicknessConverterStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CornerRadiusToThicknessConverter : DependencyObject, ICornerRadiusToThicknessConverter, IValueConverter
	{
		// Token: 0x06000903 RID: 2307
		public extern CornerRadiusToThicknessConverter();

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000904 RID: 2308
		// (set) Token: 0x06000905 RID: 2309
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		public extern CornerRadiusToThicknessConverterKind ConversionKind
		{
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			[param: In]
			set;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000906 RID: 2310
		// (set) Token: 0x06000907 RID: 2311
		[MUXPropertyDefaultValue(value = "1.0f")]
		[MUXPropertyDefaultValue(value = "1.0f")]
		public extern double Multiplier
		{
			[MUXPropertyDefaultValue(value = "1.0f")]
			get;
			[MUXPropertyDefaultValue(value = "1.0f")]
			[param: In]
			set;
		}

		// Token: 0x06000908 RID: 2312
		public extern object Convert([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);

		// Token: 0x06000909 RID: 2313
		public extern object ConvertBack([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600090A RID: 2314
		public static extern DependencyProperty ConversionKindProperty { get; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600090B RID: 2315
		public static extern DependencyProperty MultiplierProperty { get; }
	}
}
