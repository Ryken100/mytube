using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000106 RID: 262
	[Guid(2047810712U, 38086, 17953, 152, 119, 197, 26, 23, 130, 62, 223)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(ColorManagementProfile))]
	internal interface IColorManagementProfileFactory
	{
		// Token: 0x060008DD RID: 2269
		ColorManagementProfile Create([In] CanvasColorSpace colorSpace);
	}
}
