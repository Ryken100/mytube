using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000168 RID: 360
	[WebHostHidden]
	[Guid(901325681U, 14864, 24405, 137, 234, 89, 219, 154, 29, 2, 205)]
	[ExclusiveTo(typeof(TreeViewItemTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITreeViewItemTemplateSettings
	{
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600062A RID: 1578
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility ExpandedGlyphVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600062B RID: 1579
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		Visibility CollapsedGlyphVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600062C RID: 1580
		Thickness Indentation { get; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600062D RID: 1581
		int DragItemsCount { get; }
	}
}
