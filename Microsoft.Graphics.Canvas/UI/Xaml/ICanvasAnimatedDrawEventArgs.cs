using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E6 RID: 230
	[Version(167772160U)]
	[Guid(3154247501U, 65388, 19789, 169, 233, 142, 235, 33, 57, 242, 63)]
	[ExclusiveTo(typeof(CanvasAnimatedDrawEventArgs))]
	internal interface ICanvasAnimatedDrawEventArgs
	{
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000749 RID: 1865
		CanvasDrawingSession DrawingSession { get; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600074A RID: 1866
		CanvasTimingInformation Timing { get; }
	}
}
