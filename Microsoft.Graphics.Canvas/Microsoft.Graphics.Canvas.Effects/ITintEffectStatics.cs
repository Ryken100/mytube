using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1709381489u, 19375, 23692, 147, 244, 59, 135, 78, 41, 246, 141)]
	[ExclusiveTo(typeof(TintEffect))]
	internal interface ITintEffectStatics
	{
		bool IsSupported
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
