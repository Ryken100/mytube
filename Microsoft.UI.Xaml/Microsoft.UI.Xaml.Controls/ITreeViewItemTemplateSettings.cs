using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(901325681u, 14864, 24405, 137, 234, 89, 219, 154, 29, 2, 205)]
	[ExclusiveTo(typeof(TreeViewItemTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITreeViewItemTemplateSettings
	{
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility ExpandedGlyphVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility CollapsedGlyphVisibility
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		Thickness Indentation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		int DragItemsCount
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
