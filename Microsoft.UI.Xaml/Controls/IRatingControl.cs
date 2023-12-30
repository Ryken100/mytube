using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000113 RID: 275
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(RatingControl))]
	[WebHostHidden]
	[Guid(1418205499U, 59979, 21190, 133, 68, 192, 99, 33, 155, 205, 144)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IRatingControl
	{
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600046C RID: 1132
		// (set) Token: 0x0600046D RID: 1133
		string Caption
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600046E RID: 1134
		// (set) Token: 0x0600046F RID: 1135
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyDefaultValue(value = "1")]
		int InitialSetValue
		{
			[MUXPropertyDefaultValue(value = "1")]
			get;
			[MUXPropertyDefaultValue(value = "1")]
			[param: In]
			set;
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000470 RID: 1136
		// (set) Token: 0x06000471 RID: 1137
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsClearEnabled
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000472 RID: 1138
		// (set) Token: 0x06000473 RID: 1139
		bool IsReadOnly
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000474 RID: 1140
		// (set) Token: 0x06000475 RID: 1141
		[MUXPropertyDefaultValue(value = "5")]
		[MUXPropertyDefaultValue(value = "5")]
		int MaxRating
		{
			[MUXPropertyDefaultValue(value = "5")]
			get;
			[MUXPropertyDefaultValue(value = "5")]
			[param: In]
			set;
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000476 RID: 1142
		// (set) Token: 0x06000477 RID: 1143
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		double PlaceholderValue
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000478 RID: 1144
		// (set) Token: 0x06000479 RID: 1145
		RatingItemInfo ItemInfo
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600047A RID: 1146
		// (set) Token: 0x0600047B RID: 1147
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		double Value
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600047C RID: 1148
		// (remove) Token: 0x0600047D RID: 1149
		event TypedEventHandler<RatingControl, object> ValueChanged;
	}
}
