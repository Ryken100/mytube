using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(CommandBarFlyout))]
	[Windows.Foundation.Metadata.Guid(2710887398u, 17169, 23506, 168, 235, 180, 156, 71, 51, 163, 60)]
	internal interface ICommandBarFlyoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CommandBarFlyout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
