using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasDevice))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(2607688487u, 52487, 16922, 143, 105, 10, 232, 167, 135, 254, 140)]
	internal interface ICanvasDeviceStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDevice CreateFromDirect3D11Device([In] IDirect3DDevice direct3DDevice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSharedDevice")]
		CanvasDevice GetSharedDevice();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetSharedDeviceWithForceSoftwareRenderer")]
		CanvasDevice GetSharedDevice([In] bool forceSoftwareRenderer);

		CanvasDebugLevel DebugLevel
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
