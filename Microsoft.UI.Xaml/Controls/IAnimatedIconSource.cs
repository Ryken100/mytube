using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000077 RID: 119
	[WebHostHidden]
	[ExclusiveTo(typeof(AnimatedIconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(675717528U, 29467, 21369, 133, 172, 143, 40, 2, 127, 113, 131)]
	internal interface IAnimatedIconSource
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600014C RID: 332
		// (set) Token: 0x0600014D RID: 333
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IAnimatedVisualSource2 Source
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600014E RID: 334
		// (set) Token: 0x0600014F RID: 335
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IconSource FallbackIconSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000150 RID: 336
		// (set) Token: 0x06000151 RID: 337
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool MirroredWhenRightToLeft
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
