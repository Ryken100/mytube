using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(2443693539u, 47543, 21559, 136, 120, 251, 46, 20, 16, 14, 109)]
	[ExclusiveTo(typeof(OpacityEffect))]
	internal interface IOpacityEffectStatics
	{
		bool IsSupported
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
