using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200014C RID: 332
	[WebHostHidden]
	[Guid(385168658U, 15445, 22070, 168, 86, 34, 157, 151, 104, 214, 78)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TeachingTipClosingEventArgs))]
	internal interface ITeachingTipClosingEventArgs
	{
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060005AB RID: 1451
		TeachingTipCloseReason Reason { get; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060005AC RID: 1452
		// (set) Token: 0x060005AD RID: 1453
		bool Cancel
		{
			get; [param: In]
			set;
		}

		// Token: 0x060005AE RID: 1454
		Deferral GetDeferral();
	}
}
