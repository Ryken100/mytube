using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000064 RID: 100
	[Version(167772160U)]
	public enum CanvasTypographyFeatureName
	{
		// Token: 0x040000F2 RID: 242
		None,
		// Token: 0x040000F3 RID: 243
		Default = 1953261156,
		// Token: 0x040000F4 RID: 244
		VerticalWriting = 1953654134,
		// Token: 0x040000F5 RID: 245
		VerticalAlternatesAndRotation = 846492278,
		// Token: 0x040000F6 RID: 246
		AlternativeFractions = 1668441697,
		// Token: 0x040000F7 RID: 247
		PetiteCapitalsFromCapitals = 1668297315,
		// Token: 0x040000F8 RID: 248
		SmallCapitalsFromCapitals = 1668493923,
		// Token: 0x040000F9 RID: 249
		ContextualAlternates = 1953259875,
		// Token: 0x040000FA RID: 250
		CaseSensitiveForms = 1702060387,
		// Token: 0x040000FB RID: 251
		GlyphCompositionDecomposition = 1886217059,
		// Token: 0x040000FC RID: 252
		ContextualLigatures = 1734962275,
		// Token: 0x040000FD RID: 253
		CapitalSpacing = 1886613603,
		// Token: 0x040000FE RID: 254
		ContextualSwash = 1752658787,
		// Token: 0x040000FF RID: 255
		CursivePositioning = 1936880995,
		// Token: 0x04000100 RID: 256
		DiscretionaryLigatures = 1734962276,
		// Token: 0x04000101 RID: 257
		ExpertForms = 1953527909,
		// Token: 0x04000102 RID: 258
		Fractions = 1667330662,
		// Token: 0x04000103 RID: 259
		FullWidth = 1684633446,
		// Token: 0x04000104 RID: 260
		HalfForms = 1718378856,
		// Token: 0x04000105 RID: 261
		HalantForms = 1852596584,
		// Token: 0x04000106 RID: 262
		AlternateHalfWidth = 1953259880,
		// Token: 0x04000107 RID: 263
		HistoricalForms = 1953720680,
		// Token: 0x04000108 RID: 264
		HorizontalKanaAlternates = 1634626408,
		// Token: 0x04000109 RID: 265
		HistoricalLigatures = 1734962280,
		// Token: 0x0400010A RID: 266
		HalfWidth = 1684633448,
		// Token: 0x0400010B RID: 267
		HojoKanjiForms = 1869246312,
		// Token: 0x0400010C RID: 268
		Jis04Forms = 875589738,
		// Token: 0x0400010D RID: 269
		Jis78Forms = 943157354,
		// Token: 0x0400010E RID: 270
		Jis83Forms = 859336810,
		// Token: 0x0400010F RID: 271
		Jis90Forms = 809070698,
		// Token: 0x04000110 RID: 272
		Kerning = 1852990827,
		// Token: 0x04000111 RID: 273
		StandardLigatures = 1634167148,
		// Token: 0x04000112 RID: 274
		LiningFigures = 1836412524,
		// Token: 0x04000113 RID: 275
		LocalizedForms = 1818455916,
		// Token: 0x04000114 RID: 276
		MarkPositioning = 1802658157,
		// Token: 0x04000115 RID: 277
		MathematicalGreek = 1802659693,
		// Token: 0x04000116 RID: 278
		MarkToMarkPositioning = 1802333037,
		// Token: 0x04000117 RID: 279
		AlternateAnnotationForms = 1953259886,
		// Token: 0x04000118 RID: 280
		NlcKanjiForms = 1801677934,
		// Token: 0x04000119 RID: 281
		OldStyleFigures = 1836412527,
		// Token: 0x0400011A RID: 282
		Ordinals = 1852076655,
		// Token: 0x0400011B RID: 283
		ProportionalAlternateWidth = 1953259888,
		// Token: 0x0400011C RID: 284
		PetiteCapitals = 1885430640,
		// Token: 0x0400011D RID: 285
		ProportionalFigures = 1836412528,
		// Token: 0x0400011E RID: 286
		ProportionalWidths = 1684633456,
		// Token: 0x0400011F RID: 287
		QuarterWidths,
		// Token: 0x04000120 RID: 288
		RequiredLigatures = 1734962290,
		// Token: 0x04000121 RID: 289
		RubyNotationForms = 2036495730,
		// Token: 0x04000122 RID: 290
		StylisticAlternates = 1953259891,
		// Token: 0x04000123 RID: 291
		ScientificInferiors = 1718511987,
		// Token: 0x04000124 RID: 292
		SmallCapitals = 1885564275,
		// Token: 0x04000125 RID: 293
		SimplifiedForms = 1819307379,
		// Token: 0x04000126 RID: 294
		StylisticSet1 = 825258867,
		// Token: 0x04000127 RID: 295
		StylisticSet2 = 842036083,
		// Token: 0x04000128 RID: 296
		StylisticSet3 = 858813299,
		// Token: 0x04000129 RID: 297
		StylisticSet4 = 875590515,
		// Token: 0x0400012A RID: 298
		StylisticSet5 = 892367731,
		// Token: 0x0400012B RID: 299
		StylisticSet6 = 909144947,
		// Token: 0x0400012C RID: 300
		StylisticSet7 = 925922163,
		// Token: 0x0400012D RID: 301
		StylisticSet8 = 942699379,
		// Token: 0x0400012E RID: 302
		StylisticSet9 = 959476595,
		// Token: 0x0400012F RID: 303
		StylisticSet10 = 808547187,
		// Token: 0x04000130 RID: 304
		StylisticSet11 = 825324403,
		// Token: 0x04000131 RID: 305
		StylisticSet12 = 842101619,
		// Token: 0x04000132 RID: 306
		StylisticSet13 = 858878835,
		// Token: 0x04000133 RID: 307
		StylisticSet14 = 875656051,
		// Token: 0x04000134 RID: 308
		StylisticSet15 = 892433267,
		// Token: 0x04000135 RID: 309
		StylisticSet16 = 909210483,
		// Token: 0x04000136 RID: 310
		StylisticSet17 = 925987699,
		// Token: 0x04000137 RID: 311
		StylisticSet18 = 942764915,
		// Token: 0x04000138 RID: 312
		StylisticSet19 = 959542131,
		// Token: 0x04000139 RID: 313
		StylisticSet20 = 808612723,
		// Token: 0x0400013A RID: 314
		Subscript = 1935832435,
		// Token: 0x0400013B RID: 315
		Superscript = 1936749939,
		// Token: 0x0400013C RID: 316
		Swash = 1752397683,
		// Token: 0x0400013D RID: 317
		Titling = 1819568500,
		// Token: 0x0400013E RID: 318
		TraditionalNameForms = 1835101812,
		// Token: 0x0400013F RID: 319
		TabularFigures = 1836412532,
		// Token: 0x04000140 RID: 320
		TraditionalForms = 1684107892,
		// Token: 0x04000141 RID: 321
		ThirdWidths = 1684633460,
		// Token: 0x04000142 RID: 322
		Unicase = 1667853941,
		// Token: 0x04000143 RID: 323
		SlashedZero = 1869768058
	}
}
