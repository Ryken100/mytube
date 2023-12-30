using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000B1 RID: 177
	[ExclusiveTo(typeof(InfoBar))]
	[Guid(2632319114U, 21748, 21760, 167, 61, 141, 1, 2, 80, 228, 218)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface IInfoBarStatics
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000243 RID: 579
		DependencyProperty IsOpenProperty { get; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000244 RID: 580
		DependencyProperty TitleProperty { get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000245 RID: 581
		DependencyProperty MessageProperty { get; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000246 RID: 582
		DependencyProperty SeverityProperty { get; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000247 RID: 583
		DependencyProperty IconSourceProperty { get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000248 RID: 584
		DependencyProperty IsIconVisibleProperty { get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000249 RID: 585
		DependencyProperty IsClosableProperty { get; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600024A RID: 586
		DependencyProperty CloseButtonStyleProperty { get; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600024B RID: 587
		DependencyProperty CloseButtonCommandProperty { get; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600024C RID: 588
		DependencyProperty CloseButtonCommandParameterProperty { get; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600024D RID: 589
		DependencyProperty ActionButtonProperty { get; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600024E RID: 590
		DependencyProperty ContentProperty { get; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600024F RID: 591
		DependencyProperty ContentTemplateProperty { get; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000250 RID: 592
		DependencyProperty TemplateSettingsProperty { get; }
	}
}
