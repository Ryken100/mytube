using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000063 RID: 99
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public sealed class BreadcrumbBarItemClickedEventArgs : IBreadcrumbBarItemClickedEventArgs
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C8 RID: 200
		public extern int Index { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C9 RID: 201
		public extern object Item { get; }
	}
}
