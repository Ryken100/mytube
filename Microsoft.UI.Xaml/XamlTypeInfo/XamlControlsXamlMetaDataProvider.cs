using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.XamlTypeInfo
{
	// Token: 0x02000253 RID: 595
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(IXamlControlsXamlMetaDataProviderStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[Threading(3)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	public sealed class XamlControlsXamlMetaDataProvider : IXamlControlsXamlMetaDataProvider, IXamlMetadataProvider
	{
		// Token: 0x06000CB3 RID: 3251
		public extern XamlControlsXamlMetaDataProvider();

		// Token: 0x06000CB4 RID: 3252
		[DefaultOverload]
		[Overload("GetXamlType")]
		public extern IXamlType GetXamlType([In] TypeName type);

		// Token: 0x06000CB5 RID: 3253
		[Overload("GetXamlTypeByFullName")]
		public extern IXamlType GetXamlType([In] string fullName);

		// Token: 0x06000CB6 RID: 3254
		public extern XmlnsDefinition[] GetXmlnsDefinitions();

		// Token: 0x06000CB7 RID: 3255
		public static extern void Initialize();
	}
}
