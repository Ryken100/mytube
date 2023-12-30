using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ParallaxView))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[Windows.Foundation.Metadata.Guid(1641846589u, 50581, 21089, 169, 183, 53, 244, 16, 66, 235, 0)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IParallaxViewFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ParallaxView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
