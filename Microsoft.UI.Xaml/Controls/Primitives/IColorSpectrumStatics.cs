using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001CA RID: 458
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[ExclusiveTo(typeof(ColorSpectrum))]
	[Guid(2854036765U, 40571, 22375, 173, 185, 252, 211, 104, 85, 216, 46)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IColorSpectrumStatics
	{
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600092A RID: 2346
		DependencyProperty ColorProperty { get; }

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600092B RID: 2347
		DependencyProperty HsvColorProperty { get; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x0600092C RID: 2348
		DependencyProperty MinHueProperty { get; }

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600092D RID: 2349
		DependencyProperty MaxHueProperty { get; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600092E RID: 2350
		DependencyProperty MinSaturationProperty { get; }

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600092F RID: 2351
		DependencyProperty MaxSaturationProperty { get; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000930 RID: 2352
		DependencyProperty MinValueProperty { get; }

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000931 RID: 2353
		DependencyProperty MaxValueProperty { get; }

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000932 RID: 2354
		DependencyProperty ShapeProperty { get; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000933 RID: 2355
		DependencyProperty ComponentsProperty { get; }
	}
}
