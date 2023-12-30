using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000107 RID: 263
	[ExclusiveTo(typeof(ProgressBarTemplateSettings))]
	[WebHostHidden]
	[MUXPropertyNeedsDependencyPropertyField]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(550644361U, 23025, 24135, 140, 136, 240, 111, 149, 146, 158, 236)]
	internal interface IProgressBarTemplateSettings
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000428 RID: 1064
		double ContainerAnimationStartPosition { get; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000429 RID: 1065
		double ContainerAnimationEndPosition { get; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600042A RID: 1066
		double Container2AnimationStartPosition { get; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600042B RID: 1067
		double Container2AnimationEndPosition { get; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600042C RID: 1068
		double ContainerAnimationMidPosition { get; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600042D RID: 1069
		double IndicatorLengthDelta { get; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600042E RID: 1070
		RectangleGeometry ClipRect { get; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600042F RID: 1071
		double EllipseAnimationEndPosition { get; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000430 RID: 1072
		double EllipseAnimationWellPosition { get; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000431 RID: 1073
		double EllipseDiameter { get; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000432 RID: 1074
		double EllipseOffset { get; }
	}
}
