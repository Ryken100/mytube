using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000148 RID: 328
	[Guid(2540185618U, 6779, 21501, 139, 78, 194, 247, 13, 42, 210, 80)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TabViewTabDragStartingEventArgs))]
	internal interface ITabViewTabDragStartingEventArgs
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000572 RID: 1394
		// (set) Token: 0x06000573 RID: 1395
		bool Cancel
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000574 RID: 1396
		DataPackage Data { get; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000575 RID: 1397
		object Item { get; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000576 RID: 1398
		TabViewItem Tab { get; }
	}
}
