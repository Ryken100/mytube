using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Interop;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001BF RID: 447
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Static(typeof(ICornerRadiusFilterConverterStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	public sealed class CornerRadiusFilterConverter : DependencyObject, ICornerRadiusFilterConverter, IValueConverter
	{
		// Token: 0x060008FA RID: 2298
		public extern CornerRadiusFilterConverter();

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060008FB RID: 2299
		// (set) Token: 0x060008FC RID: 2300
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		public extern CornerRadiusFilterKind Filter
		{
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			[param: In]
			set;
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060008FD RID: 2301
		// (set) Token: 0x060008FE RID: 2302
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		public extern double Scale
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		// Token: 0x060008FF RID: 2303
		public extern object Convert([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);

		// Token: 0x06000900 RID: 2304
		public extern object ConvertBack([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000901 RID: 2305
		public static extern DependencyProperty FilterProperty { get; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000902 RID: 2306
		public static extern DependencyProperty ScaleProperty { get; }
	}
}
