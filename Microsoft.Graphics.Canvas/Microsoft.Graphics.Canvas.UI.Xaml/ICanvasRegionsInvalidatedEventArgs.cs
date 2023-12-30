using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasRegionsInvalidatedEventArgs))]
	[Windows.Foundation.Metadata.Guid(975282692u, 62767, 20090, 155, 63, 148, 102, 152, 25, 217, 129)]
	[Version(167772160u)]
	internal interface ICanvasRegionsInvalidatedEventArgs
	{
		Rect[] InvalidatedRegions
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Rect VisibleRegion
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
