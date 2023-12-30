using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2498688528u, 957, 20098, 148, 121, 98, 166, 22, 190, 117, 241)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(ColorManagementProfile))]
	internal interface IColorManagementProfileStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorManagementProfile CreateCustom([In] byte[] iccProfile);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorManagementProfile CreateSimple([In] ColorManagementSimpleProfile simpleProfile);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColorManagementProfile CreateExtended([In] ExtendedColorSpace colorSpace);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsSupported([In] ColorManagementProfileType type, [In] CanvasDevice device);
	}
}
