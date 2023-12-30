using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(101529889u, 22432, 23493, 190, 38, 50, 11, 217, 193, 166, 232)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TreeViewDragItemsCompletedEventArgs))]
	[WebHostHidden]
	internal interface ITreeViewDragItemsCompletedEventArgs2
	{
		object NewParentItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
