using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000165 RID: 357
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeViewItemInvokedEventArgs))]
	[Guid(436569404U, 45313, 21548, 154, 30, 119, 90, 4, 76, 70, 82)]
	[WebHostHidden]
	internal interface ITreeViewItemInvokedEventArgs
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600061E RID: 1566
		object InvokedItem { get; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000620 RID: 1568
		// (set) Token: 0x0600061F RID: 1567
		bool Handled
		{
			get; [param: In]
			set;
		}
	}
}
