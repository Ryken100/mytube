using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MUXPropertyNeedsDependencyPropertyField]
	[Windows.Foundation.Metadata.Guid(3518474954u, 1952, 21999, 169, 197, 142, 68, 237, 173, 116, 153)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ProgressRingTemplateSettings))]
	internal interface IProgressRingTemplateSettings
	{
		double EllipseDiameter
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		Thickness EllipseOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		double MaxSideLength
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
