using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000080 RID: 128
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(440095655U, 43262, 22945, 181, 68, 67, 164, 217, 200, 30, 242)]
	public interface IAnimatedVisualSource2 : IAnimatedVisualSource
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600017E RID: 382
		IMapView<string, double> Markers { get; }

		// Token: 0x0600017F RID: 383
		void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
