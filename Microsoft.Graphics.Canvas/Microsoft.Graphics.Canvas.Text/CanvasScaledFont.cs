using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasScaledFont : ICanvasScaledFont
	{
		public extern CanvasFontFace FontFace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float ScaleFactor
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
