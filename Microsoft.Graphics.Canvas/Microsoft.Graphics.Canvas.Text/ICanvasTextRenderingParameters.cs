using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2987128632u, 60857, 20204, 161, 47, 182, 174, 50, 232, 172, 230)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasTextRenderingParameters))]
	internal interface ICanvasTextRenderingParameters
	{
		CanvasTextRenderingMode RenderingMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		CanvasTextGridFit GridFit
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
