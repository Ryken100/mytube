using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200011E RID: 286
	[ExclusiveTo(typeof(ColorManagementEffect))]
	[Version(167772160U)]
	[Guid(835170200U, 62164, 22012, 177, 41, 167, 7, 54, 230, 218, 5)]
	internal interface IColorManagementEffectStatics
	{
		// Token: 0x060009D2 RID: 2514
		bool IsBestQualitySupported([In] CanvasDevice device);
	}
}
