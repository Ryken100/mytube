using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows10TileTask
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2517917873u, 49343, 20735, 116, 135, 239, 244, 240, 252, 158, 239)]
	[Version(16777216u)]
	[ExclusiveTo(typeof(NotificationsTask))]
	internal interface INotificationsTaskStatic
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAsyncAction UpdateNotifications();
	}
}
