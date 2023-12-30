using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasPrintTaskOptionsChangedEventArgs))]
	[Windows.Foundation.Metadata.Guid(4179659194u, 27801, 19628, 178, 138, 181, 220, 236, 122, 49, 13)]
	[Version(167772160u)]
	internal interface ICanvasPrintTaskOptionsChangedEventArgs
	{
		uint CurrentPreviewPageNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		uint NewPreviewPageNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasPrintDeferral GetDeferral();

		PrintTaskOptions PrintTaskOptions
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
