using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasAnimatedUpdateEventArgs))]
	[Windows.Foundation.Metadata.Guid(2842372906u, 3182, 19112, 146, 91, 113, 55, 38, 59, 78, 68)]
	internal interface ICanvasAnimatedUpdateEventArgs
	{
		CanvasTimingInformation Timing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
