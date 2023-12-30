using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000031 RID: 49
	[Guid(2327791488U, 20189, 20267, 191, 99, 44, 56, 81, 21, 178, 1)]
	[ExclusiveTo(typeof(CanvasSolidColorBrush))]
	[Version(167772160U)]
	internal interface ICanvasSolidColorBrushFactory
	{
		// Token: 0x06000049 RID: 73
		CanvasSolidColorBrush Create([In] ICanvasResourceCreator resourceCreator, [In] Color color);
	}
}
