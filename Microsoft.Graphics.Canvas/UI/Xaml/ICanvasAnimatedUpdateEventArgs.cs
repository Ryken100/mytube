using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E3 RID: 227
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasAnimatedUpdateEventArgs))]
	[Guid(2842372906U, 3182, 19112, 146, 91, 113, 55, 38, 59, 78, 68)]
	internal interface ICanvasAnimatedUpdateEventArgs
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000744 RID: 1860
		CanvasTimingInformation Timing { get; }
	}
}
