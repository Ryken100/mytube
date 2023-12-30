using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2047810712u, 38086, 17953, 152, 119, 197, 26, 23, 130, 62, 223)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(ColorManagementProfile))]
	internal interface IColorManagementProfileFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorManagementProfile Create([In] CanvasColorSpace colorSpace);
	}
}
