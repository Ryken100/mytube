using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(253423821u, 62428, 21238, 182, 50, 57, 103, 66, 83, 50, 49)]
	[ExclusiveTo(typeof(TwoPaneView))]
	internal interface ITwoPaneViewFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TwoPaneView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
