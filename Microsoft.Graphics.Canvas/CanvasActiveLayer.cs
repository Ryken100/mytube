using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000075 RID: 117
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasActiveLayer : ICanvasActiveLayer, IClosable
	{
		// Token: 0x06000414 RID: 1044
		public extern void Close();
	}
}
