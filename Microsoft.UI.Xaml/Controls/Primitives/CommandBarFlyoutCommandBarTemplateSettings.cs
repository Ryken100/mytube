using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001BE RID: 446
	[Threading(3)]
	[MUXPropertyNeedsDependencyPropertyField]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class CommandBarFlyoutCommandBarTemplateSettings : DependencyObject, ICommandBarFlyoutCommandBarTemplateSettings
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060008E6 RID: 2278
		public extern double OpenAnimationStartPosition { get; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060008E7 RID: 2279
		public extern double OpenAnimationEndPosition { get; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060008E8 RID: 2280
		public extern double CloseAnimationEndPosition { get; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060008E9 RID: 2281
		public extern double CurrentWidth { get; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060008EA RID: 2282
		public extern double ExpandedWidth { get; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060008EB RID: 2283
		public extern double WidthExpansionDelta { get; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060008EC RID: 2284
		public extern double WidthExpansionAnimationStartPosition { get; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060008ED RID: 2285
		public extern double WidthExpansionAnimationEndPosition { get; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060008EE RID: 2286
		public extern double WidthExpansionMoreButtonAnimationStartPosition { get; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060008EF RID: 2287
		public extern double WidthExpansionMoreButtonAnimationEndPosition { get; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060008F0 RID: 2288
		public extern double ExpandUpOverflowVerticalPosition { get; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060008F1 RID: 2289
		public extern double ExpandDownOverflowVerticalPosition { get; }

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060008F2 RID: 2290
		public extern double ExpandUpAnimationStartPosition { get; }

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060008F3 RID: 2291
		public extern double ExpandUpAnimationEndPosition { get; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060008F4 RID: 2292
		public extern double ExpandUpAnimationHoldPosition { get; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060008F5 RID: 2293
		public extern double ExpandDownAnimationStartPosition { get; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060008F6 RID: 2294
		public extern double ExpandDownAnimationEndPosition { get; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060008F7 RID: 2295
		public extern double ExpandDownAnimationHoldPosition { get; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060008F8 RID: 2296
		public extern Rect ContentClipRect { get; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060008F9 RID: 2297
		public extern Rect OverflowContentClipRect { get; }
	}
}
