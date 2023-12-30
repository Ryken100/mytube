using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000099 RID: 153
	[Guid(3441250014U, 36153, 23535, 167, 53, 159, 223, 96, 56, 232, 107)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(Expander))]
	internal interface IExpander
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001E4 RID: 484
		// (set) Token: 0x060001E5 RID: 485
		object Header
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001E6 RID: 486
		// (set) Token: 0x060001E7 RID: 487
		DataTemplate HeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060001E8 RID: 488
		// (set) Token: 0x060001E9 RID: 489
		DataTemplateSelector HeaderTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060001EA RID: 490
		// (set) Token: 0x060001EB RID: 491
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsExpanded
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001EC RID: 492
		// (set) Token: 0x060001ED RID: 493
		[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
		ExpandDirection ExpandDirection
		{
			[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::ExpandDirection::Down")]
			[param: In]
			set;
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060001EE RID: 494
		// (remove) Token: 0x060001EF RID: 495
		event TypedEventHandler<Expander, ExpanderExpandingEventArgs> Expanding;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060001F0 RID: 496
		// (remove) Token: 0x060001F1 RID: 497
		event TypedEventHandler<Expander, ExpanderCollapsedEventArgs> Collapsed;

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060001F2 RID: 498
		[MUXPropertyNeedsDependencyPropertyField]
		ExpanderTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}
	}
}
