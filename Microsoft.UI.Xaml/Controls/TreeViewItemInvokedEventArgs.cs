using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000224 RID: 548
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public sealed class TreeViewItemInvokedEventArgs : ITreeViewItemInvokedEventArgs
	{
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06000BCD RID: 3021
		public extern object InvokedItem { get; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06000BCF RID: 3023
		// (set) Token: 0x06000BCE RID: 3022
		public extern bool Handled
		{
			get; [param: In]
			set;
		}
	}
}
