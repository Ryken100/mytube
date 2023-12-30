using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000095 RID: 149
	[ExclusiveTo(typeof(CanvasFontSet))]
	[Guid(1598191054U, 48378, 18629, 158, 103, 251, 233, 134, 109, 73, 36)]
	[Version(167772160U)]
	internal interface ICanvasFontSetStatics
	{
		// Token: 0x060004B5 RID: 1205
		CanvasFontSet GetSystemFontSet();
	}
}
