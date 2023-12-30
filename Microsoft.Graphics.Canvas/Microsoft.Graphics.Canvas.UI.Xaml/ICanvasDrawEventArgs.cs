using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasDrawEventArgs))]
	[Windows.Foundation.Metadata.Guid(4219868831u, 9684, 17745, 189, 143, 33, 75, 234, 240, 172, 36)]
	[Version(167772160u)]
	internal interface ICanvasDrawEventArgs
	{
		CanvasDrawingSession DrawingSession
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
