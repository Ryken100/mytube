using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000026 RID: 38
	[ExclusiveTo(typeof(CanvasDevice))]
	[Version(167772160U)]
	[Guid(2607688487U, 52487, 16922, 143, 105, 10, 232, 167, 135, 254, 140)]
	internal interface ICanvasDeviceStatics
	{
		// Token: 0x0600001D RID: 29
		CanvasDevice CreateFromDirect3D11Device([In] IDirect3DDevice direct3DDevice);

		// Token: 0x0600001E RID: 30
		[Overload("GetSharedDevice")]
		CanvasDevice GetSharedDevice();

		// Token: 0x0600001F RID: 31
		[Overload("GetSharedDeviceWithForceSoftwareRenderer")]
		CanvasDevice GetSharedDevice([In] bool forceSoftwareRenderer);

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000021 RID: 33
		// (set) Token: 0x06000020 RID: 32
		CanvasDebugLevel DebugLevel
		{
			get; [param: In]
			set;
		}
	}
}
