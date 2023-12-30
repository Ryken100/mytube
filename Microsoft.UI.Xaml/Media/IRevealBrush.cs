using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x02000248 RID: 584
	[Guid(2635979654U, 44538, 23470, 191, 154, 62, 221, 3, 30, 97, 194)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(RevealBrush))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IRevealBrush
	{
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06000C7F RID: 3199
		// (set) Token: 0x06000C80 RID: 3200
		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		Color Color
		{
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			get;
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			[param: In]
			set;
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06000C81 RID: 3201
		// (set) Token: 0x06000C82 RID: 3202
		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		ApplicationTheme TargetTheme
		{
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			[param: In]
			set;
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06000C83 RID: 3203
		// (set) Token: 0x06000C84 RID: 3204
		bool AlwaysUseFallback
		{
			get; [param: In]
			set;
		}
	}
}
