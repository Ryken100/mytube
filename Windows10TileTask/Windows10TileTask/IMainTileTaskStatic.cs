using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3628217455u, 23900, 24220, 85, 200, 90, 185, 229, 88, 236, 111)]
	[Version(16777216u)]
	[ExclusiveTo(typeof(MainTileTask))]
	internal interface IMainTileTaskStatic
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAsyncAction UpdateMainTile();
	}
}
