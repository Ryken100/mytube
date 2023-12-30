using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x020000A4 RID: 164
	[Version(167772160U)]
	public struct CanvasJustificationOpportunity
	{
		// Token: 0x040001FB RID: 507
		public float ExpansionMinimum;

		// Token: 0x040001FC RID: 508
		public float ExpansionMaximum;

		// Token: 0x040001FD RID: 509
		public float CompressionMaximum;

		// Token: 0x040001FE RID: 510
		public byte ExpansionPriority;

		// Token: 0x040001FF RID: 511
		public byte CompressionPriority;

		// Token: 0x04000200 RID: 512
		public bool AllowResidualExpansion;

		// Token: 0x04000201 RID: 513
		public bool AllowResidualCompression;

		// Token: 0x04000202 RID: 514
		public bool ApplyToLeadingEdge;

		// Token: 0x04000203 RID: 515
		public bool ApplyToTrailingEdge;
	}
}
