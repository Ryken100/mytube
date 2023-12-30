using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200014B RID: 331
	[WebHostHidden]
	[ExclusiveTo(typeof(TeachingTipClosedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(624358662U, 16440, 23003, 158, 53, 169, 37, 47, 181, 173, 178)]
	internal interface ITeachingTipClosedEventArgs
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060005AA RID: 1450
		TeachingTipCloseReason Reason { get; }
	}
}
