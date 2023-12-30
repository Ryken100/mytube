using System;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000103 RID: 259
	[Version(167772160U)]
	public struct ColorManagementSimpleProfile
	{
		// Token: 0x04000261 RID: 609
		public Vector2 RedPrimary;

		// Token: 0x04000262 RID: 610
		public Vector2 GreenPrimary;

		// Token: 0x04000263 RID: 611
		public Vector2 BluePrimary;

		// Token: 0x04000264 RID: 612
		public Vector2 WhitePointXZ;

		// Token: 0x04000265 RID: 613
		public ColorManagementGamma Gamma;
	}
}
