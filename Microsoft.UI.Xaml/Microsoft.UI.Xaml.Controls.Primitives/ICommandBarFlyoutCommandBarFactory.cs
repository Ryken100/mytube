using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(CommandBarFlyoutCommandBar))]
	[Windows.Foundation.Metadata.Guid(1490800041u, 14564, 24316, 183, 64, 38, 253, 163, 208, 163, 198)]
	[WebHostHidden]
	internal interface ICommandBarFlyoutCommandBarFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CommandBarFlyoutCommandBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
