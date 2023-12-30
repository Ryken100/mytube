using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000070 RID: 112
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IExpanderFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Static(typeof(IExpanderStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	public class Expander : ContentControl, IExpander
	{
		// Token: 0x06000118 RID: 280
		public extern Expander();

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000119 RID: 281
		// (set) Token: 0x0600011A RID: 282
		public extern object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600011B RID: 283
		// (set) Token: 0x0600011C RID: 284
		public extern DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600011D RID: 285
		// (set) Token: 0x0600011E RID: 286
		public extern DataTemplateSelector HeaderTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600011F RID: 287
		// (set) Token: 0x06000120 RID: 288
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsExpanded
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000121 RID: 289
		// (set) Token: 0x06000122 RID: 290
		[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern ExpandDirection ExpandDirection
		{
			[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
			[param: In]
			set;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000123 RID: 291
		// (remove) Token: 0x06000124 RID: 292
		public extern event TypedEventHandler<Expander, ExpanderExpandingEventArgs> Expanding;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000125 RID: 293
		// (remove) Token: 0x06000126 RID: 294
		public extern event TypedEventHandler<Expander, ExpanderCollapsedEventArgs> Collapsed;

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000127 RID: 295
		[MUXPropertyNeedsDependencyPropertyField]
		public extern ExpanderTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000128 RID: 296
		public static extern DependencyProperty HeaderProperty { get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000129 RID: 297
		public static extern DependencyProperty HeaderTemplateProperty { get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600012A RID: 298
		public static extern DependencyProperty HeaderTemplateSelectorProperty { get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600012B RID: 299
		public static extern DependencyProperty IsExpandedProperty { get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600012C RID: 300
		public static extern DependencyProperty ExpandDirectionProperty { get; }
	}
}
