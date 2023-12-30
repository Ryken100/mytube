using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	// Token: 0x020000EB RID: 235
	[ExclusiveTo(typeof(CanvasCreateResourcesEventArgs))]
	[Guid(975292262U, 1921, 17289, 187, 195, 134, 177, 245, 2, 42, 241)]
	[Version(167772160U)]
	internal interface ICanvasCreateResourcesEventArgsFactory
	{
		// Token: 0x06000798 RID: 1944
		CanvasCreateResourcesEventArgs Create([In] CanvasCreateResourcesReason createResourcesReason);
	}
}
