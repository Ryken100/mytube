using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x02000022 RID: 34
	[Guid(2406320808U, 18735, 19398, 179, 208, 231, 245, 234, 232, 75, 17)]
	[Version(167772160U)]
	public interface ICanvasResourceCreator
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000001 RID: 1
		CanvasDevice Device { get; }
	}
}
