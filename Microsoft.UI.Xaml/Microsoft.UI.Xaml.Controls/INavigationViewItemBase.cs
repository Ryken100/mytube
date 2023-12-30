using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(861430932u, 44872, 20799, 190, 77, 246, 69, 232, 200, 144, 5)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NavigationViewItemBase))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface INavigationViewItemBase
	{
	}
}
