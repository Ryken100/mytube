using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Media
{
	// Token: 0x0200024A RID: 586
	[Guid(184477236U, 13555, 20725, 165, 9, 33, 206, 242, 102, 118, 126)]
	[ExclusiveTo(typeof(RevealBrush))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IRevealBrushStatics
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06000C86 RID: 3206
		DependencyProperty ColorProperty { get; }

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06000C87 RID: 3207
		DependencyProperty TargetThemeProperty { get; }

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06000C88 RID: 3208
		DependencyProperty AlwaysUseFallbackProperty { get; }

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06000C89 RID: 3209
		[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
		[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
		DependencyProperty StateProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnStatePropertyChanged")]
			[MUXPropertyDefaultValue(value = "winrt::RevealBrushState::Normal")]
			get;
		}

		// Token: 0x06000C8A RID: 3210
		void SetState([In] UIElement element, [In] RevealBrushState value);

		// Token: 0x06000C8B RID: 3211
		RevealBrushState GetState([In] UIElement element);
	}
}
