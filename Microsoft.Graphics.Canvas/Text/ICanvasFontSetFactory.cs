using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000094 RID: 148
	[ExclusiveTo(typeof(CanvasFontSet))]
	[Guid(1016896474U, 28921, 20473, 170, 178, 59, 66, 146, 50, 134, 238)]
	[Version(167772160U)]
	internal interface ICanvasFontSetFactory
	{
		// Token: 0x060004B4 RID: 1204
		CanvasFontSet Create([In] Uri uri);
	}
}
