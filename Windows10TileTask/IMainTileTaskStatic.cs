using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	// Token: 0x02000003 RID: 3
	[Guid(3628217455U, 23900, 24220, 85, 200, 90, 185, 229, 88, 236, 111)]
	[Version(16777216U)]
	[ExclusiveTo(typeof(MainTileTask))]
	internal interface IMainTileTaskStatic
	{
		// Token: 0x06000005 RID: 5
		IAsyncAction UpdateMainTile();
	}
}
