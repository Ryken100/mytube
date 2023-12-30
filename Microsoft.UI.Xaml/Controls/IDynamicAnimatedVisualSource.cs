using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000096 RID: 150
	[WebHostHidden]
	[Guid(2868962767U, 7142, 21916, 173, 91, 2, 83, 187, 23, 192, 247)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public interface IDynamicAnimatedVisualSource : IAnimatedVisualSource
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060001DA RID: 474
		// (remove) Token: 0x060001DB RID: 475
		event TypedEventHandler<IDynamicAnimatedVisualSource, object> AnimatedVisualInvalidated;
	}
}
