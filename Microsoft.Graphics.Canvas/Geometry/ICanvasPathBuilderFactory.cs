using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000072 RID: 114
	[Guid(2888560148U, 61393, 17219, 142, 83, 186, 98, 21, 61, 137, 102)]
	[ExclusiveTo(typeof(CanvasPathBuilder))]
	[Version(167772160U)]
	internal interface ICanvasPathBuilderFactory
	{
		// Token: 0x06000403 RID: 1027
		CanvasPathBuilder Create([In] ICanvasResourceCreator resourceCreator);
	}
}
