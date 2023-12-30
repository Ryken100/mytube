using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TabViewTabDroppedOutsideEventArgs))]
	[Windows.Foundation.Metadata.Guid(522145117u, 4017, 20907, 182, 111, 247, 163, 34, 191, 45, 19)]
	internal interface ITabViewTabDroppedOutsideEventArgs
	{
		object Item
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		TabViewItem Tab
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
