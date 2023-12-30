using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200011B RID: 283
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3102142555U, 2805, 23208, 142, 133, 253, 2, 45, 76, 105, 8)]
	[ExclusiveTo(typeof(RatingItemImageInfo))]
	[WebHostHidden]
	internal interface IRatingItemImageInfoStatics
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060004A7 RID: 1191
		DependencyProperty DisabledImageProperty { get; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060004A8 RID: 1192
		DependencyProperty ImageProperty { get; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060004A9 RID: 1193
		DependencyProperty PlaceholderImageProperty { get; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060004AA RID: 1194
		DependencyProperty PointerOverImageProperty { get; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060004AB RID: 1195
		DependencyProperty PointerOverPlaceholderImageProperty { get; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060004AC RID: 1196
		DependencyProperty UnsetImageProperty { get; }
	}
}
