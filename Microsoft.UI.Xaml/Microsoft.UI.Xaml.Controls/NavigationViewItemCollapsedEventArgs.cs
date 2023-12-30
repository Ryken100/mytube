using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	public sealed class NavigationViewItemCollapsedEventArgs : INavigationViewItemCollapsedEventArgs
	{
		public extern object CollapsedItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern NavigationViewItemBase CollapsedItemContainer
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
