using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200016A RID: 362
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(507930568U, 17818, 23094, 177, 49, 33, 89, 204, 47, 229, 67)]
	[ExclusiveTo(typeof(TreeViewItemTemplateSettings))]
	[WebHostHidden]
	internal interface ITreeViewItemTemplateSettingsStatics
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600062F RID: 1583
		DependencyProperty ExpandedGlyphVisibilityProperty { get; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000630 RID: 1584
		DependencyProperty CollapsedGlyphVisibilityProperty { get; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000631 RID: 1585
		DependencyProperty IndentationProperty { get; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000632 RID: 1586
		DependencyProperty DragItemsCountProperty { get; }
	}
}
