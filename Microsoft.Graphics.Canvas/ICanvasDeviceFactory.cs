using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000025 RID: 37
	[ExclusiveTo(typeof(CanvasDevice))]
	[Version(167772160U)]
	[Guid(3804413729U, 21528, 17337, 162, 218, 83, 158, 40, 124, 121, 15)]
	internal interface ICanvasDeviceFactory
	{
		// Token: 0x0600001C RID: 28
		CanvasDevice CreateWithForceSoftwareRendererOption([In] bool forceSoftwareRenderer);
	}
}
