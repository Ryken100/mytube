using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeViewNode))]
	[Windows.Foundation.Metadata.Guid(3238372837u, 52904, 24317, 139, 232, 61, 137, 181, 76, 189, 95)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITreeViewNodeFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TreeViewNode CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
