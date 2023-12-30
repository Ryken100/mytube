using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	// Token: 0x02000007 RID: 7
	[Guid(3626136828U, 36349, 22140, 73, 239, 61, 96, 19, 205, 32, 178)]
	[Version(16777216U)]
	[ExclusiveTo(typeof(SingularBackgroundTask))]
	internal interface ISingularBackgroundTaskClass
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16
		// (set) Token: 0x06000011 RID: 17
		bool SetYouTubeParams
		{
			get; [param: In]
			set;
		}
	}
}
