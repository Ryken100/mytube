using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F5 RID: 245
	[Guid(1764630099U, 16945, 24032, 172, 180, 133, 158, 73, 77, 171, 115)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ParallaxView))]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IParallaxView
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060003A7 RID: 935
		// (set) Token: 0x060003A8 RID: 936
		UIElement Child
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060003A9 RID: 937
		// (set) Token: 0x060003AA RID: 938
		double HorizontalShift
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060003AB RID: 939
		// (set) Token: 0x060003AC RID: 940
		double HorizontalSourceEndOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060003AD RID: 941
		// (set) Token: 0x060003AE RID: 942
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		ParallaxSourceOffsetKind HorizontalSourceOffsetKind
		{
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			[param: In]
			set;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060003AF RID: 943
		// (set) Token: 0x060003B0 RID: 944
		double HorizontalSourceStartOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060003B1 RID: 945
		// (set) Token: 0x060003B2 RID: 946
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsHorizontalShiftClamped
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060003B3 RID: 947
		// (set) Token: 0x060003B4 RID: 948
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsVerticalShiftClamped
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060003B5 RID: 949
		// (set) Token: 0x060003B6 RID: 950
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		double MaxHorizontalShiftRatio
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060003B7 RID: 951
		// (set) Token: 0x060003B8 RID: 952
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		double MaxVerticalShiftRatio
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060003B9 RID: 953
		// (set) Token: 0x060003BA RID: 954
		UIElement Source
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060003BB RID: 955
		// (set) Token: 0x060003BC RID: 956
		double VerticalShift
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060003BD RID: 957
		// (set) Token: 0x060003BE RID: 958
		double VerticalSourceEndOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060003BF RID: 959
		// (set) Token: 0x060003C0 RID: 960
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
		ParallaxSourceOffsetKind VerticalSourceOffsetKind
		{
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ParallaxSourceOffsetKind::Relative")]
			[param: In]
			set;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060003C1 RID: 961
		// (set) Token: 0x060003C2 RID: 962
		double VerticalSourceStartOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x060003C3 RID: 963
		void RefreshAutomaticHorizontalOffsets();

		// Token: 0x060003C4 RID: 964
		void RefreshAutomaticVerticalOffsets();
	}
}
