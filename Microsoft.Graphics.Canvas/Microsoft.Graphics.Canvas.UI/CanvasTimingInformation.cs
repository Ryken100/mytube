using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasTimingInformation
	{
		public long UpdateCount;

		public TimeSpan TotalTime;

		public TimeSpan ElapsedTime;

		public bool IsRunningSlowly;
	}
}
