using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000118 RID: 280
	[ExclusiveTo(typeof(RatingItemFontInfo))]
	[WebHostHidden]
	[Guid(2086824194U, 41279, 21616, 165, 34, 189, 84, 20, 223, 142, 211)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IRatingItemFontInfoStatics
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000494 RID: 1172
		DependencyProperty DisabledGlyphProperty { get; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000495 RID: 1173
		DependencyProperty GlyphProperty { get; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000496 RID: 1174
		DependencyProperty PlaceholderGlyphProperty { get; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000497 RID: 1175
		DependencyProperty PointerOverGlyphProperty { get; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000498 RID: 1176
		DependencyProperty PointerOverPlaceholderGlyphProperty { get; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000499 RID: 1177
		DependencyProperty UnsetGlyphProperty { get; }
	}
}
