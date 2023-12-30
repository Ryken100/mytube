using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000D5 RID: 213
	[Guid(2718019358U, 52810, 16413, 167, 25, 43, 240, 4, 213, 194, 106)]
	[ExclusiveTo(typeof(CanvasPrintDocument))]
	[Version(167772160U)]
	internal interface ICanvasPrintDocumentFactory
	{
		// Token: 0x0600070C RID: 1804
		CanvasPrintDocument CreateWithDevice([In] CanvasDevice device);
	}
}
