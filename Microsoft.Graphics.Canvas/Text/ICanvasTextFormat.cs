using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000061 RID: 97
	[ExclusiveTo(typeof(CanvasTextFormat))]
	[Version(167772160U)]
	[Guid(2942418908U, 60091, 19768, 186, 27, 175, 179, 64, 97, 45, 51)]
	internal interface ICanvasTextFormat : IClosable
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000295 RID: 661
		// (set) Token: 0x06000296 RID: 662
		CanvasTextDirection Direction
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000297 RID: 663
		// (set) Token: 0x06000298 RID: 664
		string FontFamily
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000299 RID: 665
		// (set) Token: 0x0600029A RID: 666
		float FontSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600029B RID: 667
		// (set) Token: 0x0600029C RID: 668
		FontStretch FontStretch
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600029D RID: 669
		// (set) Token: 0x0600029E RID: 670
		FontStyle FontStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600029F RID: 671
		// (set) Token: 0x060002A0 RID: 672
		FontWeight FontWeight
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060002A1 RID: 673
		// (set) Token: 0x060002A2 RID: 674
		float IncrementalTabStop
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060002A3 RID: 675
		// (set) Token: 0x060002A4 RID: 676
		float LineSpacing
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060002A5 RID: 677
		// (set) Token: 0x060002A6 RID: 678
		float LineSpacingBaseline
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060002A7 RID: 679
		// (set) Token: 0x060002A8 RID: 680
		string LocaleName
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060002A9 RID: 681
		// (set) Token: 0x060002AA RID: 682
		CanvasVerticalAlignment VerticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060002AB RID: 683
		// (set) Token: 0x060002AC RID: 684
		CanvasHorizontalAlignment HorizontalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060002AD RID: 685
		// (set) Token: 0x060002AE RID: 686
		CanvasTextTrimmingGranularity TrimmingGranularity
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060002AF RID: 687
		// (set) Token: 0x060002B0 RID: 688
		string TrimmingDelimiter
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060002B1 RID: 689
		// (set) Token: 0x060002B2 RID: 690
		int TrimmingDelimiterCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060002B3 RID: 691
		// (set) Token: 0x060002B4 RID: 692
		CanvasWordWrapping WordWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060002B5 RID: 693
		// (set) Token: 0x060002B6 RID: 694
		CanvasDrawTextOptions Options
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060002B7 RID: 695
		// (set) Token: 0x060002B8 RID: 696
		CanvasVerticalGlyphOrientation VerticalGlyphOrientation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060002B9 RID: 697
		// (set) Token: 0x060002BA RID: 698
		CanvasOpticalAlignment OpticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060002BB RID: 699
		// (set) Token: 0x060002BC RID: 700
		bool LastLineWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060002BD RID: 701
		// (set) Token: 0x060002BE RID: 702
		CanvasLineSpacingMode LineSpacingMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060002BF RID: 703
		// (set) Token: 0x060002C0 RID: 704
		CanvasTrimmingSign TrimmingSign
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060002C1 RID: 705
		// (set) Token: 0x060002C2 RID: 706
		ICanvasTextInlineObject CustomTrimmingSign
		{
			get; [param: In]
			set;
		}
	}
}
