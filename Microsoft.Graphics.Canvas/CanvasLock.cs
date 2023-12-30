using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000028 RID: 40
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CanvasLock : ICanvasLock, IClosable
	{
		// Token: 0x0600002F RID: 47
		public extern void Close();
	}
}
