using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000FB RID: 251
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2540380426U, 56831, 24112, 159, 189, 149, 18, 59, 233, 170, 172)]
	[ExclusiveTo(typeof(PersonPicture))]
	internal interface IPersonPicture
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060003D8 RID: 984
		// (set) Token: 0x060003D9 RID: 985
		int BadgeNumber
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060003DA RID: 986
		// (set) Token: 0x060003DB RID: 987
		string BadgeGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060003DC RID: 988
		// (set) Token: 0x060003DD RID: 989
		ImageSource BadgeImageSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060003DE RID: 990
		// (set) Token: 0x060003DF RID: 991
		string BadgeText
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060003E0 RID: 992
		// (set) Token: 0x060003E1 RID: 993
		bool IsGroup
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060003E2 RID: 994
		// (set) Token: 0x060003E3 RID: 995
		Contact Contact
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060003E4 RID: 996
		// (set) Token: 0x060003E5 RID: 997
		string DisplayName
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060003E6 RID: 998
		// (set) Token: 0x060003E7 RID: 999
		string Initials
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060003E8 RID: 1000
		// (set) Token: 0x060003E9 RID: 1001
		bool PreferSmallImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060003EA RID: 1002
		// (set) Token: 0x060003EB RID: 1003
		ImageSource ProfilePicture
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060003EC RID: 1004
		[MUXPropertyNeedsDependencyPropertyField]
		PersonPictureTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}
	}
}
