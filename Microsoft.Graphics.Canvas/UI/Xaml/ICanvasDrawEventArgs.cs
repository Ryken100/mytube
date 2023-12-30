using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000EF RID: 239
	[ExclusiveTo(typeof(CanvasDrawEventArgs))]
	[Guid(4219868831U, 9684, 17745, 189, 143, 33, 75, 234, 240, 172, 36)]
	[Version(167772160U)]
	internal interface ICanvasDrawEventArgs
	{
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600079F RID: 1951
		CanvasDrawingSession DrawingSession { get; }
	}
}
