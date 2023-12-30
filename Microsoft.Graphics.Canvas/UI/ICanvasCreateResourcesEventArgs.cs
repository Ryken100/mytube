using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	// Token: 0x020000EC RID: 236
	[Version(167772160U)]
	[Guid(3989119240U, 63162, 18953, 159, 163, 16, 201, 122, 36, 228, 154)]
	[ExclusiveTo(typeof(CanvasCreateResourcesEventArgs))]
	internal interface ICanvasCreateResourcesEventArgs
	{
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000799 RID: 1945
		CanvasCreateResourcesReason Reason { get; }

		// Token: 0x0600079A RID: 1946
		void TrackAsyncAction([In] IAsyncAction action);

		// Token: 0x0600079B RID: 1947
		IAsyncAction GetTrackedAction();
	}
}
