using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000052 RID: 82
	[Guid(2055859865U, 52778, 18426, 157, 210, 10, 104, 37, 246, 5, 63)]
	[Version(167772160U)]
	public interface ICanvasTextInlineObject
	{
		// Token: 0x06000258 RID: 600
		void Draw([In] ICanvasTextRenderer textRenderer, [In] Vector2 point, [In] bool isSideways, [In] bool isRightToLeft, [In] object brush);

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000259 RID: 601
		Size Size { get; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600025A RID: 602
		float Baseline { get; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600025B RID: 603
		bool SupportsSideways { get; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600025C RID: 604
		Rect DrawBounds { get; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600025D RID: 605
		CanvasLineBreakCondition BreakBefore { get; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600025E RID: 606
		CanvasLineBreakCondition BreakAfter { get; }
	}
}
