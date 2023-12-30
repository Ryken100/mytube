using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	// Token: 0x02000002 RID: 2
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(16777216U)]
	[Static(typeof(IMainTileTaskStatic), 16777216U)]
	public sealed class MainTileTask : IBackgroundTask, IStringable
	{
		// Token: 0x06000001 RID: 1
		public extern MainTileTask();

		// Token: 0x06000002 RID: 2
		public static extern IAsyncAction UpdateMainTile();

		// Token: 0x06000003 RID: 3
		public extern void Run([In] IBackgroundTaskInstance taskInstance);

		// Token: 0x06000004 RID: 4
		string IStringable.ToString();
	}
}
