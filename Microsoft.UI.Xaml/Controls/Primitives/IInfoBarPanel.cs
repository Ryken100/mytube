using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D8 RID: 472
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(InfoBarPanel))]
	[Guid(1151365260U, 44092, 21432, 187, 170, 59, 56, 101, 62, 132, 61)]
	[WebHostHidden]
	internal interface IInfoBarPanel
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000966 RID: 2406
		// (set) Token: 0x06000967 RID: 2407
		Thickness HorizontalOrientationPadding
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000968 RID: 2408
		// (set) Token: 0x06000969 RID: 2409
		Thickness VerticalOrientationPadding
		{
			get; [param: In]
			set;
		}
	}
}
