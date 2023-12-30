using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A1 RID: 161
	[Guid(314863978U, 12737, 20746, 149, 38, 1, 171, 62, 43, 7, 56)]
	[WebHostHidden]
	[ExclusiveTo(typeof(FontIconSource))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IFontIconSourceStatics
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600020A RID: 522
		DependencyProperty GlyphProperty { get; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600020B RID: 523
		DependencyProperty FontSizeProperty { get; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600020C RID: 524
		DependencyProperty FontFamilyProperty { get; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600020D RID: 525
		DependencyProperty FontWeightProperty { get; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600020E RID: 526
		DependencyProperty FontStyleProperty { get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600020F RID: 527
		DependencyProperty IsTextScaleFactorEnabledProperty { get; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000210 RID: 528
		DependencyProperty MirroredWhenRightToLeftProperty { get; }
	}
}
