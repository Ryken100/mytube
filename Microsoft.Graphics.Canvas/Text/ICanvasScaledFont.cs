using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200009B RID: 155
	[ExclusiveTo(typeof(CanvasScaledFont))]
	[Guid(3150248146U, 60203, 17905, 172, 42, 207, 193, 245, 152, 186, 227)]
	[Version(167772160U)]
	internal interface ICanvasScaledFont
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060004BF RID: 1215
		CanvasFontFace FontFace { get; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060004C0 RID: 1216
		float ScaleFactor { get; }
	}
}
