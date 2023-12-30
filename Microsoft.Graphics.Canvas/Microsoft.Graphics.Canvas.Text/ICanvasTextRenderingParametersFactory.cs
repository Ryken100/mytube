using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3527453733u, 19747, 18788, 157, 154, 219, 47, 200, 175, 24, 93)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasTextRenderingParameters))]
	internal interface ICanvasTextRenderingParametersFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasTextRenderingParameters Create([In] CanvasTextRenderingMode textRenderingMode, [In] CanvasTextGridFit gridFit);
	}
}
