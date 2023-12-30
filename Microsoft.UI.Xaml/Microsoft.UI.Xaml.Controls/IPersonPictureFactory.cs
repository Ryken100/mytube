using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(PersonPicture))]
	[Windows.Foundation.Metadata.Guid(2126543180u, 62156, 21122, 168, 157, 205, 59, 183, 101, 183, 26)]
	internal interface IPersonPictureFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		PersonPicture CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
