using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000027 RID: 39
	[Version(167772160U)]
	[Guid(2726234973U, 60460, 19791, 148, 143, 10, 161, 233, 94, 51, 230)]
	[ExclusiveTo(typeof(CanvasDevice))]
	internal interface ICanvasDevice : IClosable, ICanvasResourceCreator, IDirect3DDevice
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000022 RID: 34
		bool ForceSoftwareRenderer { get; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000023 RID: 35
		int MaximumBitmapSizeInPixels { get; }

		// Token: 0x06000024 RID: 36
		bool IsPixelFormatSupported([In] DirectXPixelFormat pixelFormat);

		// Token: 0x06000025 RID: 37
		bool IsBufferPrecisionSupported([In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000026 RID: 38
		// (set) Token: 0x06000027 RID: 39
		ulong MaximumCacheSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000028 RID: 40
		// (set) Token: 0x06000029 RID: 41
		bool LowPriority
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002A RID: 42
		// (remove) Token: 0x0600002B RID: 43
		event TypedEventHandler<CanvasDevice, object> DeviceLost;

		// Token: 0x0600002C RID: 44
		bool IsDeviceLost([In] int hresult);

		// Token: 0x0600002D RID: 45
		void RaiseDeviceLost();

		// Token: 0x0600002E RID: 46
		CanvasLock Lock();
	}
}
