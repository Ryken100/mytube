using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.XamlTypeInfo
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(763278333u, 60635, 20612, 183, 224, 18, 249, 89, 131, 129, 239)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(XamlControlsXamlMetaDataProvider))]
	internal interface IXamlControlsXamlMetaDataProviderStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Initialize();
	}
}
