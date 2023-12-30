using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Version(16777216u)]
	[Activatable(16777216u)]
	[Static(typeof(IMainTileTaskStatic), 16777216u)]
	public sealed class MainTileTask : IBackgroundTask, IStringable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern IAsyncAction UpdateMainTile();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Run([In] IBackgroundTaskInstance taskInstance);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		extern string IStringable.ToString();
	}
}
