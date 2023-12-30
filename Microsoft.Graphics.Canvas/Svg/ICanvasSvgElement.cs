using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000B5 RID: 181
	[Guid(125160321U, 50517, 17855, 151, 149, 15, 245, 145, 81, 195, 190)]
	[Version(167772160U)]
	public interface ICanvasSvgElement : IClosable
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000519 RID: 1305
		CanvasSvgDocument ContainingDocument { get; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600051A RID: 1306
		CanvasSvgNamedElement Parent { get; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600051B RID: 1307
		CanvasDevice Device { get; }
	}
}
