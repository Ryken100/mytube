using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200007F RID: 127
	[Guid(3527453733U, 19747, 18788, 157, 154, 219, 47, 200, 175, 24, 93)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasTextRenderingParameters))]
	internal interface ICanvasTextRenderingParametersFactory
	{
		// Token: 0x06000426 RID: 1062
		CanvasTextRenderingParameters Create([In] CanvasTextRenderingMode textRenderingMode, [In] CanvasTextGridFit gridFit);
	}
}
