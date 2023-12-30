using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000105 RID: 261
	[Guid(1361290603U, 45465, 18347, 174, 190, 211, 8, 4, 68, 35, 254)]
	[ExclusiveTo(typeof(ColorManagementProfile))]
	[Version(167772160U)]
	internal interface IColorManagementProfile : IClosable
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060008D8 RID: 2264
		CanvasColorSpace ColorSpace { get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060008D9 RID: 2265
		byte[] IccProfile { get; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060008DA RID: 2266
		ColorManagementProfileType Type { get; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060008DB RID: 2267
		IReference<ColorManagementSimpleProfile> SimpleProfile { get; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060008DC RID: 2268
		ExtendedColorSpace ExtendedColorSpace { get; }
	}
}
