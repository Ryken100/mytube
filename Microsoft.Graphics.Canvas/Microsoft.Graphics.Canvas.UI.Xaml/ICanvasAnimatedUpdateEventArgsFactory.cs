using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasAnimatedUpdateEventArgs))]
	[Windows.Foundation.Metadata.Guid(1987004519u, 45610, 17995, 137, 177, 13, 166, 171, 98, 190, 104)]
	[Version(167772160u)]
	internal interface ICanvasAnimatedUpdateEventArgsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasAnimatedUpdateEventArgs Create([In] CanvasTimingInformation timingInformation);
	}
}
