using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000AE RID: 174
	[Guid(103612886U, 25007, 21557, 140, 75, 197, 17, 6, 88, 59, 91)]
	[ExclusiveTo(typeof(InfoBarClosingEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IInfoBarClosingEventArgs
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600023F RID: 575
		InfoBarCloseReason Reason { get; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000240 RID: 576
		// (set) Token: 0x06000241 RID: 577
		bool Cancel
		{
			get; [param: In]
			set;
		}
	}
}
