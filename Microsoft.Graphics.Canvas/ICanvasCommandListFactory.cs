using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000D2 RID: 210
	[ExclusiveTo(typeof(CanvasCommandList))]
	[Version(167772160U)]
	[Guid(3017035368U, 55601, 19291, 185, 87, 8, 136, 152, 10, 125, 80)]
	internal interface ICanvasCommandListFactory
	{
		// Token: 0x06000703 RID: 1795
		CanvasCommandList Create([In] ICanvasResourceCreator resourceCreator);
	}
}
