using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3904641478u, 39524, 23636, 147, 56, 225, 142, 7, 104, 117, 191)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(IconSource))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IIconSourceFactory
	{
	}
}
