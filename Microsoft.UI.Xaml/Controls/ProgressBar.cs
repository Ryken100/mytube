using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001EC RID: 492
	[WebHostHidden]
	[Composable(typeof(IProgressBarFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[Static(typeof(IProgressBarStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	public class ProgressBar : RangeBase, IProgressBar
	{
		// Token: 0x060009A6 RID: 2470
		public extern ProgressBar();

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060009A7 RID: 2471
		// (set) Token: 0x060009A8 RID: 2472
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsIndeterminate
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060009A9 RID: 2473
		// (set) Token: 0x060009AA RID: 2474
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool ShowError
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060009AB RID: 2475
		// (set) Token: 0x060009AC RID: 2476
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool ShowPaused
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060009AD RID: 2477
		[MUXPropertyNeedsDependencyPropertyField]
		public extern ProgressBarTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060009AE RID: 2478
		public static extern DependencyProperty IsIndeterminateProperty { get; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060009AF RID: 2479
		public static extern DependencyProperty ShowErrorProperty { get; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060009B0 RID: 2480
		public static extern DependencyProperty ShowPausedProperty { get; }
	}
}
