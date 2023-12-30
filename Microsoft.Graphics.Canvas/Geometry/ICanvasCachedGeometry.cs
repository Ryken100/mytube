using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200008D RID: 141
	[ExclusiveTo(typeof(CanvasCachedGeometry))]
	[Guid(3127685396U, 57761, 17549, 171, 124, 141, 43, 146, 103, 65, 25)]
	[Version(167772160U)]
	internal interface ICanvasCachedGeometry : IClosable
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000494 RID: 1172
		CanvasDevice Device { get; }
	}
}
