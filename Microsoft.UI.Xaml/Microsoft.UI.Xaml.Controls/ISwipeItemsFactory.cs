using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(SwipeItems))]
	[Windows.Foundation.Metadata.Guid(2589818231u, 14781, 23425, 171, 78, 244, 74, 202, 110, 222, 63)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISwipeItemsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		SwipeItems CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
