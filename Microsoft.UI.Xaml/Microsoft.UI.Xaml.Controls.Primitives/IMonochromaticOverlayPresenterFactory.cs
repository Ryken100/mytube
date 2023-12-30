using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(MonochromaticOverlayPresenter))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1234666619u, 46424, 23692, 130, 152, 190, 21, 50, 232, 152, 236)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IMonochromaticOverlayPresenterFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		MonochromaticOverlayPresenter CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
