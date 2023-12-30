using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000104 RID: 260
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(2270518412U, 2735, 21185, 131, 144, 13, 177, 127, 64, 67, 142)]
	[ExclusiveTo(typeof(ProgressBar))]
	internal interface IProgressBar
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600041D RID: 1053
		// (set) Token: 0x0600041E RID: 1054
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsIndeterminate
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600041F RID: 1055
		// (set) Token: 0x06000420 RID: 1056
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool ShowError
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000421 RID: 1057
		// (set) Token: 0x06000422 RID: 1058
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool ShowPaused
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000423 RID: 1059
		[MUXPropertyNeedsDependencyPropertyField]
		ProgressBarTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}
	}
}
