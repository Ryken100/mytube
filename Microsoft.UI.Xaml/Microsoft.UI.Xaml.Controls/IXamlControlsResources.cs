using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(XamlControlsResources))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(238395540u, 34446, 24510, 169, 46, 46, 34, 74, 120, 29, 213)]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IXamlControlsResources
	{
	}
}
