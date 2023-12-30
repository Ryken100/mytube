using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.XamlTypeInfo
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Static(typeof(IXamlControlsXamlMetaDataProviderStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[Threading(ThreadingModel.Both)]
	[Activatable(65536u, "Microsoft.UI.Xaml.XamlContract")]
	public sealed class XamlControlsXamlMetaDataProvider : IXamlControlsXamlMetaDataProvider, IXamlMetadataProvider
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("GetXamlType")]
		public extern IXamlType GetXamlType([In] Type type);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetXamlTypeByFullName")]
		public extern IXamlType GetXamlType([In] string fullName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern XmlnsDefinition[] GetXmlnsDefinitions();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void Initialize();
	}
}
