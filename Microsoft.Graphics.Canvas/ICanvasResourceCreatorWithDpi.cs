using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000024 RID: 36
	[Guid(443921682U, 59898, 18918, 168, 118, 56, 202, 225, 148, 1, 62)]
	[Version(167772160U)]
	public interface ICanvasResourceCreatorWithDpi : ICanvasResourceCreator
	{
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000019 RID: 25
		float Dpi { get; }

		// Token: 0x0600001A RID: 26
		float ConvertPixelsToDips([In] int pixels);

		// Token: 0x0600001B RID: 27
		int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);
	}
}
