using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000241 RID: 577
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(298441309U, 47400, 21419, 186, 110, 143, 74, 204, 70, 155, 15)]
	[ExclusiveTo(typeof(RadialGradientBrush))]
	internal interface IRadialGradientBrush
	{
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06000C66 RID: 3174
		// (set) Token: 0x06000C67 RID: 3175
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		[MUXPropertyChangedCallback(enable = true)]
		Point Center
		{
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06000C68 RID: 3176
		// (set) Token: 0x06000C69 RID: 3177
		[MUXPropertyDefaultValue(value = "0.5")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.5")]
		[MUXPropertyChangedCallback(enable = true)]
		double RadiusX
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0.5")]
			get;
			[MUXPropertyDefaultValue(value = "0.5")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06000C6A RID: 3178
		// (set) Token: 0x06000C6B RID: 3179
		[MUXPropertyDefaultValue(value = "0.5")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.5")]
		[MUXPropertyChangedCallback(enable = true)]
		double RadiusY
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0.5")]
			get;
			[MUXPropertyDefaultValue(value = "0.5")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06000C6C RID: 3180
		// (set) Token: 0x06000C6D RID: 3181
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
		Point GradientOrigin
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Point(0.5,0.5)")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06000C6E RID: 3182
		// (set) Token: 0x06000C6F RID: 3183
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
		BrushMappingMode MappingMode
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::BrushMappingMode::RelativeToBoundingBox")]
			[param: In]
			set;
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06000C70 RID: 3184
		// (set) Token: 0x06000C71 RID: 3185
		[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
		[MUXPropertyChangedCallback(enable = true)]
		CompositionColorSpace InterpolationSpace
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Windows::UI::Composition::CompositionColorSpace::Auto")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06000C72 RID: 3186
		// (set) Token: 0x06000C73 RID: 3187
		[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
		[MUXPropertyChangedCallback(enable = true)]
		GradientSpreadMethod SpreadMethod
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::GradientSpreadMethod::Pad")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06000C74 RID: 3188
		IObservableVector<GradientStop> GradientStops { get; }
	}
}
