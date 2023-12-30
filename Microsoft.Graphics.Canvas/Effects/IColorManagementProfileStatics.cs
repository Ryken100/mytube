using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000108 RID: 264
	[Guid(2498688528U, 957, 20098, 148, 121, 98, 166, 22, 190, 117, 241)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(ColorManagementProfile))]
	internal interface IColorManagementProfileStatics
	{
		// Token: 0x060008E9 RID: 2281
		ColorManagementProfile CreateCustom([In] byte[] iccProfile);

		// Token: 0x060008EA RID: 2282
		ColorManagementProfile CreateSimple([In] ColorManagementSimpleProfile simpleProfile);

		// Token: 0x060008EB RID: 2283
		ColorManagementProfile CreateExtended([In] ExtendedColorSpace colorSpace);

		// Token: 0x060008EC RID: 2284
		bool IsSupported([In] ColorManagementProfileType type, [In] CanvasDevice device);
	}
}
