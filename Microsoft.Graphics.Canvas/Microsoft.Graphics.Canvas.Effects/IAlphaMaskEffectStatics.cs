using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3425767516u, 887, 22280, 132, 132, 26, 216, 238, 62, 85, 75)]
	[ExclusiveTo(typeof(AlphaMaskEffect))]
	[Version(167772160u)]
	internal interface IAlphaMaskEffectStatics
	{
		bool IsSupported
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
