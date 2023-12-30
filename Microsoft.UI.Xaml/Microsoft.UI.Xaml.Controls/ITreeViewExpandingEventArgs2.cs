using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3984081125u, 56309, 22839, 137, 221, 153, 122, 111, 222, 13, 92)]
	[ExclusiveTo(typeof(TreeViewExpandingEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITreeViewExpandingEventArgs2
	{
		object Item
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
