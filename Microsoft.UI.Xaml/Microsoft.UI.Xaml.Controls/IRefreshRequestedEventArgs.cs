using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(RefreshRequestedEventArgs))]
	[Windows.Foundation.Metadata.Guid(3986139478u, 24601, 21289, 147, 18, 248, 133, 181, 199, 116, 205)]
	internal interface IRefreshRequestedEventArgs
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Deferral GetDeferral();
	}
}
