using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001EE RID: 494
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IProgressRingFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IProgressRingStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[WebHostHidden]
	public class ProgressRing : Control, IProgressRing
	{
		// Token: 0x060009BC RID: 2492
		public extern ProgressRing();

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060009BD RID: 2493
		// (set) Token: 0x060009BE RID: 2494
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsActive
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060009BF RID: 2495
		// (set) Token: 0x060009C0 RID: 2496
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		public extern bool IsIndeterminate
		{
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060009C1 RID: 2497
		[MUXPropertyNeedsDependencyPropertyField]
		public extern ProgressRingTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060009C2 RID: 2498
		// (set) Token: 0x060009C3 RID: 2499
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double Value
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060009C4 RID: 2500
		// (set) Token: 0x060009C5 RID: 2501
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern double Minimum
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060009C6 RID: 2502
		// (set) Token: 0x060009C7 RID: 2503
		[MUXPropertyDefaultValue(value = "100.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "100.0")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern double Maximum
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "100.0")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "100.0")]
			[param: In]
			set;
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060009C8 RID: 2504
		public static extern DependencyProperty IsActiveProperty { get; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060009C9 RID: 2505
		public static extern DependencyProperty IsIndeterminateProperty { get; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060009CA RID: 2506
		public static extern DependencyProperty ValueProperty { get; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060009CB RID: 2507
		public static extern DependencyProperty MinimumProperty { get; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060009CC RID: 2508
		public static extern DependencyProperty MaximumProperty { get; }
	}
}
