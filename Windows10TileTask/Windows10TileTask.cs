using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	// Token: 0x02000008 RID: 8
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(16777216U)]
	public sealed class Windows10TileTask : IBackgroundTask, IStringable
	{
		// Token: 0x06000012 RID: 18
		public extern Windows10TileTask();

		// Token: 0x06000013 RID: 19
		public extern void Run([In] IBackgroundTaskInstance taskInstance);

		// Token: 0x06000014 RID: 20
		string IStringable.ToString();
	}
}
