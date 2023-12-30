using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2032125475u, 51446, 20738, 129, 189, 24, 105, 205, 232, 34, 132)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TabViewTabDragCompletedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITabViewTabDragCompletedEventArgs
	{
		DataPackageOperation DropResult
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

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
