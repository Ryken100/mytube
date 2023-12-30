using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyNeedsDependencyPropertyField]
	[Windows.Foundation.Metadata.Guid(2408943640u, 63160, 23554, 190, 8, 205, 25, 108, 159, 205, 45)]
	[ExclusiveTo(typeof(ExpanderTemplateSettings))]
	[WebHostHidden]
	internal interface IExpanderTemplateSettings
	{
		double ContentHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		double NegativeContentHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
