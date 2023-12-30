using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	// Token: 0x02000006 RID: 6
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(16777216U)]
	public sealed class SingularBackgroundTask : IBackgroundTask, ISingularBackgroundTaskClass, IStringable
	{
		// Token: 0x0600000B RID: 11
		public extern SingularBackgroundTask();

		// Token: 0x0600000C RID: 12
		public extern void Run([In] IBackgroundTaskInstance taskInstance);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13
		// (set) Token: 0x0600000E RID: 14
		public extern bool SetYouTubeParams
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600000F RID: 15
		string IStringable.ToString();
	}
}
