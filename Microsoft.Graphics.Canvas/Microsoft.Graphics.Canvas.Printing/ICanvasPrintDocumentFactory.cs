using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2718019358u, 52810, 16413, 167, 25, 43, 240, 4, 213, 194, 106)]
	[ExclusiveTo(typeof(CanvasPrintDocument))]
	[Version(167772160u)]
	internal interface ICanvasPrintDocumentFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasPrintDocument CreateWithDevice([In] CanvasDevice device);
	}
}
