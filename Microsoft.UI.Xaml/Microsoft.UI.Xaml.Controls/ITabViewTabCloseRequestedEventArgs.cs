using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(3580541362u, 57956, 23678, 161, 203, 228, 26, 22, 166, 198, 198)]
	[ExclusiveTo(typeof(TabViewTabCloseRequestedEventArgs))]
	internal interface ITabViewTabCloseRequestedEventArgs
	{
		object Item
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		TabViewItem Tab
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
