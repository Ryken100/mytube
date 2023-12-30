using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(834262961u, 31800, 22806, 153, 198, 199, 31, 107, 1, 43, 27)]
	[ExclusiveTo(typeof(NavigationViewItemBase))]
	[WebHostHidden]
	internal interface INavigationViewItemBaseFactory
	{
	}
}
