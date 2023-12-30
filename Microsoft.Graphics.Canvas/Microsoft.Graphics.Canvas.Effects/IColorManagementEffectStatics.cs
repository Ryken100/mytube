using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[ExclusiveTo(typeof(ColorManagementEffect))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(835170200u, 62164, 22012, 177, 41, 167, 7, 54, 230, 218, 5)]
	internal interface IColorManagementEffectStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsBestQualitySupported([In] CanvasDevice device);
	}
}
