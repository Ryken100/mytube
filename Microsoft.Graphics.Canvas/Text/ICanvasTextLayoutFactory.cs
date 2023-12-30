using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200006D RID: 109
	[Version(167772160U)]
	[Guid(2619306361U, 44240, 18048, 147, 213, 149, 166, 36, 126, 143, 107)]
	[ExclusiveTo(typeof(CanvasTextLayout))]
	internal interface ICanvasTextLayoutFactory
	{
		// Token: 0x0600035D RID: 861
		CanvasTextLayout Create([In] ICanvasResourceCreator resourceCreator, [In] string textString, [In] CanvasTextFormat textFormat, [In] float requestedWidth, [In] float requestedHeight);
	}
}
