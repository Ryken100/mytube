using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000023 RID: 35
	[MarshalingBehavior(2)]
	[Activatable(typeof(ICanvasDeviceFactory), 167772160U)]
	[Threading(3)]
	[Activatable(167772160U)]
	[Version(167772160U)]
	[Static(typeof(ICanvasDeviceStatics), 167772160U)]
	public sealed class CanvasDevice : ICanvasDevice, IDirect3DDevice, IClosable, ICanvasResourceCreator
	{
		// Token: 0x06000002 RID: 2
		public extern CanvasDevice([In] bool forceSoftwareRenderer);

		// Token: 0x06000003 RID: 3
		public extern CanvasDevice();

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000004 RID: 4
		public extern bool ForceSoftwareRenderer { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000005 RID: 5
		public extern int MaximumBitmapSizeInPixels { get; }

		// Token: 0x06000006 RID: 6
		public extern bool IsPixelFormatSupported([In] DirectXPixelFormat pixelFormat);

		// Token: 0x06000007 RID: 7
		public extern bool IsBufferPrecisionSupported([In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000008 RID: 8
		// (set) Token: 0x06000009 RID: 9
		public extern ulong MaximumCacheSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600000A RID: 10
		// (set) Token: 0x0600000B RID: 11
		public extern bool LowPriority
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000C RID: 12
		// (remove) Token: 0x0600000D RID: 13
		public extern event TypedEventHandler<CanvasDevice, object> DeviceLost;

		// Token: 0x0600000E RID: 14
		public extern bool IsDeviceLost([In] int hresult);

		// Token: 0x0600000F RID: 15
		public extern void RaiseDeviceLost();

		// Token: 0x06000010 RID: 16
		public extern CanvasLock Lock();

		// Token: 0x06000011 RID: 17
		public extern void Close();

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000012 RID: 18
		public extern CanvasDevice Device { get; }

		// Token: 0x06000013 RID: 19
		public extern void Trim();

		// Token: 0x06000014 RID: 20
		public static extern CanvasDevice CreateFromDirect3D11Device([In] IDirect3DDevice direct3DDevice);

		// Token: 0x06000015 RID: 21
		[Overload("GetSharedDevice")]
		public static extern CanvasDevice GetSharedDevice();

		// Token: 0x06000016 RID: 22
		[Overload("GetSharedDeviceWithForceSoftwareRenderer")]
		public static extern CanvasDevice GetSharedDevice([In] bool forceSoftwareRenderer);

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000018 RID: 24
		// (set) Token: 0x06000017 RID: 23
		public static extern CanvasDebugLevel DebugLevel
		{
			get; [param: In]
			set;
		}
	}
}
