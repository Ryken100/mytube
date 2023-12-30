using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000AB RID: 171
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasSpriteBatch))]
	[Guid(2233381005U, 40193, 19287, 158, 148, 36, 17, 49, 81, 183, 75)]
	internal interface ICanvasSpriteBatchStatics
	{
		// Token: 0x060004EE RID: 1262
		bool IsSupported([In] CanvasDevice device);
	}
}
