using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	public sealed class TreeViewCollapsedEventArgs : ITreeViewCollapsedEventArgs, ITreeViewCollapsedEventArgs2
	{
		public extern TreeViewNode Node
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern object Item
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
