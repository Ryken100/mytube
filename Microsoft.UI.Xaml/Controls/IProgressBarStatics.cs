using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000106 RID: 262
	[WebHostHidden]
	[ExclusiveTo(typeof(ProgressBar))]
	[Guid(1923495105U, 45613, 22010, 144, 157, 123, 116, 88, 171, 20, 226)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IProgressBarStatics
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000425 RID: 1061
		DependencyProperty IsIndeterminateProperty { get; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000426 RID: 1062
		DependencyProperty ShowErrorProperty { get; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000427 RID: 1063
		DependencyProperty ShowPausedProperty { get; }
	}
}
