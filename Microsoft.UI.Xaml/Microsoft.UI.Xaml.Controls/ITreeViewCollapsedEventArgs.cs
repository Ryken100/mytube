using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(TreeViewCollapsedEventArgs))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2397047641u, 17094, 23923, 128, 159, 104, 113, 0, 136, 229, 165)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITreeViewCollapsedEventArgs
	{
		TreeViewNode Node
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
