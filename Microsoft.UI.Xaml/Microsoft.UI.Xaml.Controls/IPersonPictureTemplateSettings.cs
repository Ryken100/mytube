using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MUXPropertyNeedsDependencyPropertyField]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(PersonPictureTemplateSettings))]
	[Windows.Foundation.Metadata.Guid(2679421456u, 52216, 23999, 145, 138, 131, 35, 218, 164, 247, 228)]
	internal interface IPersonPictureTemplateSettings
	{
		string ActualInitials
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		ImageBrush ActualImageBrush
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
