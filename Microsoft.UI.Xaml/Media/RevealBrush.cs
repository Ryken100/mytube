using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200024C RID: 588
	[WebHostHidden]
	[Static(typeof(IRevealBrushStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallback(enable = true)]
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Composable(typeof(IRevealBrushProtectedFactory), 1, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class RevealBrush : XamlCompositionBrushBase, IRevealBrush
	{
		// Token: 0x06000CA3 RID: 3235
		protected extern RevealBrush();

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06000CA4 RID: 3236
		// (set) Token: 0x06000CA5 RID: 3237
		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
		public extern Color Color
		{
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			get;
			[MUXPropertyDefaultValue(value = "RevealBrush::sc_defaultColor")]
			[param: In]
			set;
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06000CA6 RID: 3238
		// (set) Token: 0x06000CA7 RID: 3239
		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
		public extern ApplicationTheme TargetTheme
		{
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ApplicationTheme::Light")]
			[param: In]
			set;
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06000CA8 RID: 3240
		// (set) Token: 0x06000CA9 RID: 3241
		public extern bool AlwaysUseFallback
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06000CAA RID: 3242
		public static extern DependencyProperty ColorProperty { get; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06000CAB RID: 3243
		public static extern DependencyProperty TargetThemeProperty { get; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06000CAC RID: 3244
		public static extern DependencyProperty AlwaysUseFallbackProperty { get; }

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06000CAD RID: 3245
		[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
		[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
		public static extern DependencyProperty StateProperty
		{
			[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
			[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
			get;
		}

		// Token: 0x06000CAE RID: 3246
		public static extern void SetState([In] UIElement element, [In] RevealBrushState value);

		// Token: 0x06000CAF RID: 3247
		public static extern RevealBrushState GetState([In] UIElement element);
	}
}
