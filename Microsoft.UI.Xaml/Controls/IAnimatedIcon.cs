using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000075 RID: 117
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(4144357338U, 33174, 22224, 141, 207, 43, 102, 194, 174, 215, 145)]
	[ExclusiveTo(typeof(AnimatedIcon))]
	internal interface IAnimatedIcon
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000145 RID: 325
		// (set) Token: 0x06000146 RID: 326
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000147 RID: 327
		// (set) Token: 0x06000148 RID: 328
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000149 RID: 329
		// (set) Token: 0x0600014A RID: 330
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
