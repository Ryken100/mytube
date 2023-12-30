using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Activatable(typeof(ICanvasAnimatedUpdateEventArgsFactory), 167772160u)]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasAnimatedUpdateEventArgs : ICanvasAnimatedUpdateEventArgs
	{
		public extern CanvasTimingInformation Timing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
