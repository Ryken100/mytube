using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	// Token: 0x02000005 RID: 5
	[Guid(2517917873U, 49343, 20735, 116, 135, 239, 244, 240, 252, 158, 239)]
	[Version(16777216U)]
	[ExclusiveTo(typeof(NotificationsTask))]
	internal interface INotificationsTaskStatic
	{
		// Token: 0x0600000A RID: 10
		IAsyncAction UpdateNotifications();
	}
}
