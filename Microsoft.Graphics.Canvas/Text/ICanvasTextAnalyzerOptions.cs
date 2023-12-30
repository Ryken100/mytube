using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200009A RID: 154
	[Version(167772160U)]
	[Guid(837959786U, 35935, 19986, 139, 214, 207, 187, 199, 33, 77, 2)]
	public interface ICanvasTextAnalyzerOptions
	{
		// Token: 0x060004BB RID: 1211
		string GetLocaleName([In] int characterIndex, out int characterCount);

		// Token: 0x060004BC RID: 1212
		CanvasNumberSubstitution GetNumberSubstitution([In] int characterIndex, out int characterCount);

		// Token: 0x060004BD RID: 1213
		CanvasVerticalGlyphOrientation GetVerticalGlyphOrientation([In] int characterIndex, out int characterCount);

		// Token: 0x060004BE RID: 1214
		uint GetBidiLevel([In] int characterIndex, out int characterCount);
	}
}
