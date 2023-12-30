using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x020000FF RID: 255
	[ExclusiveTo(typeof(PixelShaderEffect))]
	[Guid(2635540453U, 18589, 19132, 177, 41, 83, 97, 227, 83, 74, 244)]
	[Version(167772160U)]
	internal interface IPixelShaderEffectFactory
	{
		// Token: 0x06000885 RID: 2181
		PixelShaderEffect Create([In] byte[] shaderCode);
	}
}
