using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ExclusiveTo(typeof(CommandBarFlyoutCommandBar))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(259072197u, 27904, 21641, 145, 113, 190, 221, 45, 78, 246, 119)]
	internal interface ICommandBarFlyoutCommandBar
	{
		[MUXPropertyNeedsDependencyPropertyField]
		CommandBarFlyoutCommandBarTemplateSettings FlyoutTemplateSettings
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}
	}
}
