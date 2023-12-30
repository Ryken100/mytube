using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3626136828u, 36349, 22140, 73, 239, 61, 96, 19, 205, 32, 178)]
	[Version(16777216u)]
	[ExclusiveTo(typeof(SingularBackgroundTask))]
	internal interface ISingularBackgroundTaskClass
	{
		bool SetYouTubeParams
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
