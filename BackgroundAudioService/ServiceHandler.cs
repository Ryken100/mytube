using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace BackgroundAudioService
{
	// Token: 0x02000002 RID: 2
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(16777216U)]
	public sealed class ServiceHandler : IBackgroundTask, IStringable
	{
		// Token: 0x06000001 RID: 1
		public extern ServiceHandler();

		// Token: 0x06000002 RID: 2
		void IBackgroundTask.Run([In] IBackgroundTaskInstance taskInstance);

		// Token: 0x06000003 RID: 3
		string IStringable.ToString();
	}
}
