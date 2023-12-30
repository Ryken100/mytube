using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TreeViewItemInvokedEventArgs))]
	[Windows.Foundation.Metadata.Guid(436569404u, 45313, 21548, 154, 30, 119, 90, 4, 76, 70, 82)]
	[WebHostHidden]
	internal interface ITreeViewItemInvokedEventArgs
	{
		object InvokedItem
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool Handled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
