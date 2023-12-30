using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TreeViewDragItemsCompletedEventArgs))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3854062718u, 63545, 21979, 156, 38, 42, 149, 245, 122, 96, 220)]
	internal interface ITreeViewDragItemsCompletedEventArgs
	{
		DataPackageOperation DropResult
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		IReadOnlyList<object> Items
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
