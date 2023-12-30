using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000225 RID: 549
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[Composable(typeof(ITreeViewItemTemplateSettingsFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Static(typeof(ITreeViewItemTemplateSettingsStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class TreeViewItemTemplateSettings : DependencyObject, ITreeViewItemTemplateSettings
	{
		// Token: 0x06000BD0 RID: 3024
		public extern TreeViewItemTemplateSettings();

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06000BD1 RID: 3025
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility ExpandedGlyphVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06000BD2 RID: 3026
		[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
		public extern Visibility CollapsedGlyphVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::Visibility::Collapsed")]
			get;
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06000BD3 RID: 3027
		public extern Thickness Indentation { get; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06000BD4 RID: 3028
		public extern int DragItemsCount { get; }

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06000BD5 RID: 3029
		public static extern DependencyProperty ExpandedGlyphVisibilityProperty { get; }

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06000BD6 RID: 3030
		public static extern DependencyProperty CollapsedGlyphVisibilityProperty { get; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06000BD7 RID: 3031
		public static extern DependencyProperty IndentationProperty { get; }

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06000BD8 RID: 3032
		public static extern DependencyProperty DragItemsCountProperty { get; }
	}
}
