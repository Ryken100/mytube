using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasDevice))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3804413729u, 21528, 17337, 162, 218, 83, 158, 40, 124, 121, 15)]
	internal interface ICanvasDeviceFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasDevice CreateWithForceSoftwareRendererOption([In] bool forceSoftwareRenderer);
	}
}
