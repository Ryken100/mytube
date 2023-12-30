using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200015E RID: 350
	[WebHostHidden]
	[Guid(460083196U, 52530, 24070, 183, 130, 223, 159, 7, 117, 70, 199)]
	[ExclusiveTo(typeof(TreeViewDragItemsStartingEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITreeViewDragItemsStartingEventArgs
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000605 RID: 1541
		// (set) Token: 0x06000606 RID: 1542
		bool Cancel
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000607 RID: 1543
		DataPackage Data { get; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000608 RID: 1544
		IVector<object> Items { get; }
	}
}
