using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000030 RID: 48
	[Guid(4124411281U, 51203, 16820, 135, 142, 121, 217, 42, 177, 50, 149)]
	[Version(167772160U)]
	public interface ICanvasBrush : IClosable
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000044 RID: 68
		// (set) Token: 0x06000045 RID: 69
		float Opacity
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000046 RID: 70
		// (set) Token: 0x06000047 RID: 71
		Matrix3x2 Transform
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000048 RID: 72
		CanvasDevice Device { get; }
	}
}
