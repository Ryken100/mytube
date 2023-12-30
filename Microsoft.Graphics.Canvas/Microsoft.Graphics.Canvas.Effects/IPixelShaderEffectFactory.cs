using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[ExclusiveTo(typeof(PixelShaderEffect))]
	[Windows.Foundation.Metadata.Guid(2635540453u, 18589, 19132, 177, 41, 83, 97, 227, 83, 74, 244)]
	[Version(167772160u)]
	internal interface IPixelShaderEffectFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		PixelShaderEffect Create([In] byte[] shaderCode);
	}
}
