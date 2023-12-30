using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C2 RID: 194
	[ExclusiveTo(typeof(CanvasSvgPointsAttribute))]
	[Version(167772160U)]
	[Guid(1697089192U, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 111)]
	internal interface ICanvasSvgPointsAttribute : IClosable, ICanvasSvgAttribute
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060005C9 RID: 1481
		Vector2[] Points { get; }

		// Token: 0x060005CA RID: 1482
		Vector2[] GetPoints([In] int startIndex, [In] int elementCount);

		// Token: 0x060005CB RID: 1483
		void RemovePointsAtEnd([In] int pointCount);

		// Token: 0x060005CC RID: 1484
		void SetPoints([In] int startIndex, [In] Vector2[] points);
	}
}
