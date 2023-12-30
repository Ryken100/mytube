using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000116 RID: 278
	[Guid(2572818140U, 14863, 22311, 159, 56, 82, 207, 200, 20, 54, 84)]
	[ExclusiveTo(typeof(RatingItemFontInfo))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IRatingItemFontInfo
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000487 RID: 1159
		// (set) Token: 0x06000488 RID: 1160
		string DisabledGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000489 RID: 1161
		// (set) Token: 0x0600048A RID: 1162
		string Glyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600048B RID: 1163
		// (set) Token: 0x0600048C RID: 1164
		string PointerOverGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600048D RID: 1165
		// (set) Token: 0x0600048E RID: 1166
		string PointerOverPlaceholderGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600048F RID: 1167
		// (set) Token: 0x06000490 RID: 1168
		string PlaceholderGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000491 RID: 1169
		// (set) Token: 0x06000492 RID: 1170
		string UnsetGlyph
		{
			get; [param: In]
			set;
		}
	}
}
