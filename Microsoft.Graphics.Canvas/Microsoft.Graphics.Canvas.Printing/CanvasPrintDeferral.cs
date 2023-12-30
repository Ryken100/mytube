using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasPrintDeferral : ICanvasPrintDeferral
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Complete();
	}
}
