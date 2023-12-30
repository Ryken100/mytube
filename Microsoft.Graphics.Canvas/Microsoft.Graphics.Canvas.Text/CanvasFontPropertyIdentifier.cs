using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasFontPropertyIdentifier
	{
		None,
		FamilyName,
		PreferredFamilyName,
		FaceName,
		FullName,
		Win32FamilyName,
		PostscriptName,
		DesignScriptLanguageTag,
		SupportedScriptLanguageTag,
		SemanticTag,
		Weight,
		Stretch,
		Style,
		Total
	}
}
