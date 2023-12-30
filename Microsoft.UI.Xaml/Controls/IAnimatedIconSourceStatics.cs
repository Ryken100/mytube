using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000079 RID: 121
	[Guid(1846481701U, 56280, 20915, 180, 189, 45, 91, 124, 207, 81, 120)]
	[WebHostHidden]
	[ExclusiveTo(typeof(AnimatedIconSource))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAnimatedIconSourceStatics
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000153 RID: 339
		DependencyProperty SourceProperty { get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000154 RID: 340
		DependencyProperty FallbackIconSourceProperty { get; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000155 RID: 341
		DependencyProperty MirroredWhenRightToLeftProperty { get; }
	}
}
