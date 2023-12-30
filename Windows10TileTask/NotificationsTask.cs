using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	// Token: 0x02000004 RID: 4
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(16777216U)]
	[Static(typeof(INotificationsTaskStatic), 16777216U)]
	public sealed class NotificationsTask : IBackgroundTask, IStringable
	{
		// Token: 0x06000006 RID: 6
		public extern NotificationsTask();

		// Token: 0x06000007 RID: 7
		public static extern IAsyncAction UpdateNotifications();

		// Token: 0x06000008 RID: 8
		public extern void Run([In] IBackgroundTaskInstance taskInstance);

		// Token: 0x06000009 RID: 9
		string IStringable.ToString();
	}
}
