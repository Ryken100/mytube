using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x020000A0 RID: 160
	[Version(167772160U)]
	public struct CanvasScriptProperties
	{
		// Token: 0x040001DA RID: 474
		public string IsoScriptCode;

		// Token: 0x040001DB RID: 475
		public int IsoScriptNumber;

		// Token: 0x040001DC RID: 476
		public int ClusterLookahead;

		// Token: 0x040001DD RID: 477
		public string JustificationCharacter;

		// Token: 0x040001DE RID: 478
		public bool RestrictCaretToClusters;

		// Token: 0x040001DF RID: 479
		public bool UsesWordDividers;

		// Token: 0x040001E0 RID: 480
		public bool IsDiscreteWriting;

		// Token: 0x040001E1 RID: 481
		public bool IsBlockWriting;

		// Token: 0x040001E2 RID: 482
		public bool IsDistributedWithinCluster;

		// Token: 0x040001E3 RID: 483
		public bool IsConnectedWriting;

		// Token: 0x040001E4 RID: 484
		public bool IsCursiveWriting;
	}
}
