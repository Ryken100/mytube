using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000119 RID: 281
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(1627547876U, 44910, 23580, 141, 15, 187, 70, 192, 109, 103, 130)]
	[ExclusiveTo(typeof(RatingItemImageInfo))]
	internal interface IRatingItemImageInfo
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600049A RID: 1178
		// (set) Token: 0x0600049B RID: 1179
		ImageSource DisabledImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600049C RID: 1180
		// (set) Token: 0x0600049D RID: 1181
		ImageSource Image
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600049E RID: 1182
		// (set) Token: 0x0600049F RID: 1183
		ImageSource PlaceholderImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060004A0 RID: 1184
		// (set) Token: 0x060004A1 RID: 1185
		ImageSource PointerOverImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060004A2 RID: 1186
		// (set) Token: 0x060004A3 RID: 1187
		ImageSource PointerOverPlaceholderImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060004A4 RID: 1188
		// (set) Token: 0x060004A5 RID: 1189
		ImageSource UnsetImage
		{
			get; [param: In]
			set;
		}
	}
}
