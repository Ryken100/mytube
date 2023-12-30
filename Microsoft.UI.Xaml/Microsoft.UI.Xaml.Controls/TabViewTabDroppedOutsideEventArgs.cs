using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class TabViewTabDroppedOutsideEventArgs : ITabViewTabDroppedOutsideEventArgs
	{
		public extern object Item
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern TabViewItem Tab
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}