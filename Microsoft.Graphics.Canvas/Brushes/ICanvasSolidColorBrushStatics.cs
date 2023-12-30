using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000033 RID: 51
	[Version(167772160U)]
	[Guid(1654354500U, 23454, 20216, 142, 9, 38, 71, 20, 32, 30, 232)]
	[ExclusiveTo(typeof(CanvasSolidColorBrush))]
	internal interface ICanvasSolidColorBrushStatics
	{
		// Token: 0x06000056 RID: 86
		CanvasSolidColorBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 colorHdr);
	}
}
