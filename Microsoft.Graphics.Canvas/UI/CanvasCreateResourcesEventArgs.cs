using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	// Token: 0x020000E9 RID: 233
	[Activatable(typeof(ICanvasCreateResourcesEventArgsFactory), 167772160U)]
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class CanvasCreateResourcesEventArgs : ICanvasCreateResourcesEventArgs
	{
		// Token: 0x06000794 RID: 1940
		public extern CanvasCreateResourcesEventArgs([In] CanvasCreateResourcesReason createResourcesReason);

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000795 RID: 1941
		public extern CanvasCreateResourcesReason Reason { get; }

		// Token: 0x06000796 RID: 1942
		public extern void TrackAsyncAction([In] IAsyncAction action);

		// Token: 0x06000797 RID: 1943
		public extern IAsyncAction GetTrackedAction();
	}
}
