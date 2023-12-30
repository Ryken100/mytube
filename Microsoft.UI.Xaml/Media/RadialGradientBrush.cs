using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200024B RID: 587
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[WebHostHidden]
	[ContentProperty(Name = "GradientStops")]
	[Composable(typeof(IRadialGradientBrushFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IRadialGradientBrushStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class RadialGradientBrush : XamlCompositionBrushBase, IRadialGradientBrush
	{
		// Token: 0x06000C8C RID: 3212
		public extern RadialGradientBrush();

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06000C8D RID: 3213
		// (set) Token: 0x06000C8E RID: 3214
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Point Center
		{
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06000C8F RID: 3215
		// (set) Token: 0x06000C90 RID: 3216
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.5")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.5")]
		public extern double RadiusX
		{
			[MUXPropertyDefaultValue(value = "0.5")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "0.5")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06000C91 RID: 3217
		// (set) Token: 0x06000C92 RID: 3218
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.5")]
		[MUXPropertyDefaultValue(value = "0.5")]
		public extern double RadiusY
		{
			[MUXPropertyDefaultValue(value = "0.5")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0.5")]
			[param: In]
			set;
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06000C93 RID: 3219
		// (set) Token: 0x06000C94 RID: 3220
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Point GradientOrigin
		{
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06000C95 RID: 3221
		// (set) Token: 0x06000C96 RID: 3222
		[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
		[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern BrushMappingMode MappingMode
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06000C97 RID: 3223
		// (set) Token: 0x06000C98 RID: 3224
		[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern CompositionColorSpace InterpolationSpace
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
			[param: In]
			set;
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06000C99 RID: 3225
		// (set) Token: 0x06000C9A RID: 3226
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
		[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
		public extern GradientSpreadMethod SpreadMethod
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06000C9B RID: 3227
		public extern IObservableVector<GradientStop> GradientStops { get; }

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06000C9C RID: 3228
		public static extern DependencyProperty CenterProperty { get; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06000C9D RID: 3229
		public static extern DependencyProperty RadiusXProperty { get; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06000C9E RID: 3230
		public static extern DependencyProperty RadiusYProperty { get; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06000C9F RID: 3231
		public static extern DependencyProperty GradientOriginProperty { get; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06000CA0 RID: 3232
		public static extern DependencyProperty InterpolationSpaceProperty { get; }

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06000CA1 RID: 3233
		public static extern DependencyProperty MappingModeProperty { get; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06000CA2 RID: 3234
		public static extern DependencyProperty SpreadMethodProperty { get; }
	}
}
