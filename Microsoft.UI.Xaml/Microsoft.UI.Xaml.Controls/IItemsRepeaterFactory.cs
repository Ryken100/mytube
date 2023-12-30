using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(3284267588u, 26536, 22159, 166, 247, 93, 168, 176, 234, 221, 73)]
	[ExclusiveTo(typeof(ItemsRepeater))]
	internal interface IItemsRepeaterFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ItemsRepeater CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
