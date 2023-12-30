using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001EF RID: 495
	[MUXPropertyNeedsDependencyPropertyField]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class ProgressRingTemplateSettings : DependencyObject, IProgressRingTemplateSettings
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060009CD RID: 2509
		public extern double EllipseDiameter { get; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060009CE RID: 2510
		public extern Thickness EllipseOffset { get; }

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060009CF RID: 2511
		public extern double MaxSideLength { get; }
	}
}
