using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001ED RID: 493
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[MUXPropertyNeedsDependencyPropertyField]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	public sealed class ProgressBarTemplateSettings : DependencyObject, IProgressBarTemplateSettings
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060009B1 RID: 2481
		public extern double ContainerAnimationStartPosition { get; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060009B2 RID: 2482
		public extern double ContainerAnimationEndPosition { get; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060009B3 RID: 2483
		public extern double Container2AnimationStartPosition { get; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060009B4 RID: 2484
		public extern double Container2AnimationEndPosition { get; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060009B5 RID: 2485
		public extern double ContainerAnimationMidPosition { get; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060009B6 RID: 2486
		public extern double IndicatorLengthDelta { get; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060009B7 RID: 2487
		public extern RectangleGeometry ClipRect { get; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060009B8 RID: 2488
		public extern double EllipseAnimationEndPosition { get; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060009B9 RID: 2489
		public extern double EllipseAnimationWellPosition { get; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060009BA RID: 2490
		public extern double EllipseDiameter { get; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060009BB RID: 2491
		public extern double EllipseOffset { get; }
	}
}
