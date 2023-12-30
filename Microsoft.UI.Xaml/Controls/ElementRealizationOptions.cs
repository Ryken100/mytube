using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200006E RID: 110
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Flags]
	[WebHostHidden]
	public enum ElementRealizationOptions : uint
	{
		// Token: 0x04000014 RID: 20
		None = 0U,
		// Token: 0x04000015 RID: 21
		ForceCreate = 1U,
		// Token: 0x04000016 RID: 22
		SuppressAutoRecycle = 2U
	}
}
