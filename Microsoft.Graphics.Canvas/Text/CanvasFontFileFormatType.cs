using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000081 RID: 129
	[Version(167772160U)]
	public enum CanvasFontFileFormatType
	{
		// Token: 0x04000185 RID: 389
		Cff,
		// Token: 0x04000186 RID: 390
		TrueType,
		// Token: 0x04000187 RID: 391
		TrueTypeCollection,
		// Token: 0x04000188 RID: 392
		Type1,
		// Token: 0x04000189 RID: 393
		Vector,
		// Token: 0x0400018A RID: 394
		Bitmap,
		// Token: 0x0400018B RID: 395
		Unknown,
		// Token: 0x0400018C RID: 396
		RawCff
	}
}
