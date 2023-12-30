using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000063 RID: 99
	[Version(167772160U)]
	[Static(typeof(ICanvasTextFormatStatics), 167772160U)]
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CanvasTextFormat : ICanvasTextFormat, IClosable
	{
		// Token: 0x060002C5 RID: 709
		public extern CanvasTextFormat();

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060002C6 RID: 710
		// (set) Token: 0x060002C7 RID: 711
		public extern CanvasTextDirection Direction
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060002C8 RID: 712
		// (set) Token: 0x060002C9 RID: 713
		public extern string FontFamily
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060002CA RID: 714
		// (set) Token: 0x060002CB RID: 715
		public extern float FontSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060002CC RID: 716
		// (set) Token: 0x060002CD RID: 717
		public extern FontStretch FontStretch
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060002CE RID: 718
		// (set) Token: 0x060002CF RID: 719
		public extern FontStyle FontStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060002D0 RID: 720
		// (set) Token: 0x060002D1 RID: 721
		public extern FontWeight FontWeight
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060002D2 RID: 722
		// (set) Token: 0x060002D3 RID: 723
		public extern float IncrementalTabStop
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060002D4 RID: 724
		// (set) Token: 0x060002D5 RID: 725
		public extern float LineSpacing
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060002D6 RID: 726
		// (set) Token: 0x060002D7 RID: 727
		public extern float LineSpacingBaseline
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060002D8 RID: 728
		// (set) Token: 0x060002D9 RID: 729
		public extern string LocaleName
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060002DA RID: 730
		// (set) Token: 0x060002DB RID: 731
		public extern CanvasVerticalAlignment VerticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060002DC RID: 732
		// (set) Token: 0x060002DD RID: 733
		public extern CanvasHorizontalAlignment HorizontalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060002DE RID: 734
		// (set) Token: 0x060002DF RID: 735
		public extern CanvasTextTrimmingGranularity TrimmingGranularity
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060002E0 RID: 736
		// (set) Token: 0x060002E1 RID: 737
		public extern string TrimmingDelimiter
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060002E2 RID: 738
		// (set) Token: 0x060002E3 RID: 739
		public extern int TrimmingDelimiterCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060002E4 RID: 740
		// (set) Token: 0x060002E5 RID: 741
		public extern CanvasWordWrapping WordWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060002E6 RID: 742
		// (set) Token: 0x060002E7 RID: 743
		public extern CanvasDrawTextOptions Options
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060002E8 RID: 744
		// (set) Token: 0x060002E9 RID: 745
		public extern CanvasVerticalGlyphOrientation VerticalGlyphOrientation
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060002EA RID: 746
		// (set) Token: 0x060002EB RID: 747
		public extern CanvasOpticalAlignment OpticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060002EC RID: 748
		// (set) Token: 0x060002ED RID: 749
		public extern bool LastLineWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060002EE RID: 750
		// (set) Token: 0x060002EF RID: 751
		public extern CanvasLineSpacingMode LineSpacingMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060002F0 RID: 752
		// (set) Token: 0x060002F1 RID: 753
		public extern CanvasTrimmingSign TrimmingSign
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060002F2 RID: 754
		// (set) Token: 0x060002F3 RID: 755
		public extern ICanvasTextInlineObject CustomTrimmingSign
		{
			get; [param: In]
			set;
		}

		// Token: 0x060002F4 RID: 756
		public extern void Close();

		// Token: 0x060002F5 RID: 757
		[Overload("GetSystemFontFamilies")]
		public static extern string[] GetSystemFontFamilies();

		// Token: 0x060002F6 RID: 758
		[Overload("GetSystemFontFamiliesFromLocaleList")]
		public static extern string[] GetSystemFontFamilies([In] IVectorView<string> localeList);
	}
}
