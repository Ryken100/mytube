using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x02000003 RID: 3
	[Guid(796633080U, 44991, 22435, 111, 66, 206, 189, 230, 252, 62, 66)]
	[Version(16777216U)]
	public interface IVideoEffectHandler
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		// (set) Token: 0x06000003 RID: 3
		bool IsEnabled
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000004 RID: 4
		bool ProcessFrame([In] IVideoEffectHandlerArgs args);

		// Token: 0x06000005 RID: 5
		void CreateResources();

		// Token: 0x06000006 RID: 6
		void DestroyResources();
	}
}
