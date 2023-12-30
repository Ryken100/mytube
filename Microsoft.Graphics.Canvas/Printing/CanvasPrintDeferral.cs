using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000DC RID: 220
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class CanvasPrintDeferral : ICanvasPrintDeferral
	{
		// Token: 0x06000736 RID: 1846
		public extern void Complete();
	}
}
