using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000035 RID: 53
	[Guid(3289172825U, 7047, 17300, 166, 166, 236, 210, 120, 232, 119, 214)]
	[ExclusiveTo(typeof(CanvasImageBrush))]
	[Version(167772160U)]
	internal interface ICanvasImageBrushFactory
	{
		// Token: 0x0600005B RID: 91
		CanvasImageBrush Create([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x0600005C RID: 92
		CanvasImageBrush CreateWithImage([In] ICanvasResourceCreator resourceCreator, [In] ICanvasImage image);
	}
}
