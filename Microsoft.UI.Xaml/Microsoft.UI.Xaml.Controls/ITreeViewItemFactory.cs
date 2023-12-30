using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(TreeViewItem))]
	[Windows.Foundation.Metadata.Guid(2274351384u, 59262, 23528, 140, 138, 183, 155, 39, 176, 141, 155)]
	internal interface ITreeViewItemFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TreeViewItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
