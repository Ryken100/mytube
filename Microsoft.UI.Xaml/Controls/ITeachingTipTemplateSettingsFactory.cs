using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000150 RID: 336
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TeachingTipTemplateSettings))]
	[WebHostHidden]
	[Guid(1663108421U, 57749, 22221, 188, 205, 22, 146, 85, 225, 52, 227)]
	internal interface ITeachingTipTemplateSettingsFactory
	{
		// Token: 0x060005CB RID: 1483
		TeachingTipTemplateSettings CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
