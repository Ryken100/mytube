using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1175755168u, 26831, 23425, 176, 228, 177, 175, 146, 155, 11, 18)]
	[ExclusiveTo(typeof(TreeViewList))]
	internal interface ITreeViewListFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TreeViewList CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
