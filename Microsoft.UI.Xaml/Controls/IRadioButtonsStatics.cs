using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200010E RID: 270
	[ExclusiveTo(typeof(RadioButtons))]
	[Guid(275759037U, 17156, 23885, 142, 106, 196, 193, 90, 187, 187, 239)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IRadioButtonsStatics
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600045A RID: 1114
		DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600045B RID: 1115
		DependencyProperty ItemsProperty { get; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600045C RID: 1116
		DependencyProperty ItemTemplateProperty { get; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600045D RID: 1117
		DependencyProperty SelectedIndexProperty { get; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600045E RID: 1118
		DependencyProperty SelectedItemProperty { get; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600045F RID: 1119
		DependencyProperty MaxColumnsProperty { get; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000460 RID: 1120
		DependencyProperty HeaderProperty { get; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000461 RID: 1121
		DependencyProperty HeaderTemplateProperty { get; }
	}
}
