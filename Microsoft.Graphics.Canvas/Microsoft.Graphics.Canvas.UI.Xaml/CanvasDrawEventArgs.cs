using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	[Activatable(typeof(ICanvasDrawEventArgsFactory), 167772160u)]
	public sealed class CanvasDrawEventArgs : ICanvasDrawEventArgs
	{
		public extern CanvasDrawingSession DrawingSession
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
