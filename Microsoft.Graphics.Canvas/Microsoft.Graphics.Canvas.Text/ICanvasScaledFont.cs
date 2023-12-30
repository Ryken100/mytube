using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasScaledFont))]
	[Windows.Foundation.Metadata.Guid(3150248146u, 60203, 17905, 172, 42, 207, 193, 245, 152, 186, 227)]
	[Version(167772160u)]
	internal interface ICanvasScaledFont
	{
		CanvasFontFace FontFace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		float ScaleFactor
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
