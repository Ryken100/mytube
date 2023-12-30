using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000107 RID: 263
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Static(typeof(IColorManagementProfileStatics), 167772160U)]
	[Activatable(typeof(IColorManagementProfileFactory), 167772160U)]
	public sealed class ColorManagementProfile : IColorManagementProfile, IClosable
	{
		// Token: 0x060008DE RID: 2270
		public extern ColorManagementProfile([In] CanvasColorSpace colorSpace);

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060008DF RID: 2271
		public extern CanvasColorSpace ColorSpace { get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060008E0 RID: 2272
		public extern byte[] IccProfile { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060008E1 RID: 2273
		public extern ColorManagementProfileType Type { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060008E2 RID: 2274
		public extern IReference<ColorManagementSimpleProfile> SimpleProfile { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060008E3 RID: 2275
		public extern ExtendedColorSpace ExtendedColorSpace { get; }

		// Token: 0x060008E4 RID: 2276
		public extern void Close();

		// Token: 0x060008E5 RID: 2277
		public static extern ColorManagementProfile CreateCustom([In] byte[] iccProfile);

		// Token: 0x060008E6 RID: 2278
		public static extern ColorManagementProfile CreateSimple([In] ColorManagementSimpleProfile simpleProfile);

		// Token: 0x060008E7 RID: 2279
		public static extern ColorManagementProfile CreateExtended([In] ExtendedColorSpace colorSpace);

		// Token: 0x060008E8 RID: 2280
		public static extern bool IsSupported([In] ColorManagementProfileType type, [In] CanvasDevice device);
	}
}
