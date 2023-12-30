using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000108 RID: 264
	[Guid(644927551U, 57996, 22098, 190, 226, 181, 33, 46, 189, 247, 255)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ProgressRing))]
	internal interface IProgressRing
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000433 RID: 1075
		// (set) Token: 0x06000434 RID: 1076
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsActive
		{
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000435 RID: 1077
		// (set) Token: 0x06000436 RID: 1078
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsIndeterminate
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000437 RID: 1079
		[MUXPropertyNeedsDependencyPropertyField]
		ProgressRingTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000438 RID: 1080
		// (set) Token: 0x06000439 RID: 1081
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		double Value
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600043A RID: 1082
		// (set) Token: 0x0600043B RID: 1083
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyChangedCallback(enable = true)]
		double Minimum
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600043C RID: 1084
		// (set) Token: 0x0600043D RID: 1085
		[MUXPropertyDefaultValue(value = "100.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "100.0")]
		[MUXPropertyChangedCallback(enable = true)]
		double Maximum
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "100.0")]
			get;
			[MUXPropertyDefaultValue(value = "100.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
