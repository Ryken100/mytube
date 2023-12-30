using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasFontInformation
	{
		None,
		CopyrightNotice,
		VersionStrings,
		Trademark,
		Manufacturer,
		Designer,
		DesignerUrl,
		Description,
		FontVendorUrl,
		LicenseDescription,
		LicenseInfoUrl,
		Win32FamilyNames,
		Win32SubfamilyNames,
		PreferredFamilyNames,
		PreferredSubfamilyNames,
		SampleText,
		FullName,
		PostscriptName,
		PostscriptCidName,
		WwsFamilyName,
		DesignScriptLanguageTag,
		SupportedScriptLanguageTag
	}
}
