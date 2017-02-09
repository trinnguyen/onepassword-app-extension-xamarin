using System;

namespace AgileBits
{
	/// <summary>
	/// Login Dictionary keys - Used to get or set the properties of a 1Password Login
	/// </summary>
	public static class AppExtensionLoginDictionarykeys
	{
		public const string URLStringKey = "url_string";

		public const string UsernameKey = "username";

		public const string PasswordKey = "password";

		public const string TOTPKey = "totp";

		public const string TitleKey = "login_title";

		public const string NotesKey = "notes";

		public const string SectionTitleKey = "section_title";

		public const string FieldsKey = "fields";

		public const string ReturnedFieldsKey = "returned_fields";

		public const string OldPasswordKey = "old_password";

		public const string PasswordGeneratorOptionsKey = "password_generator_options";
	}

	/// <summary>
	/// Password Generator options - Used to set the 1Password Password Generator options when saving a new Login or when changing the password for for an existing Login
	/// </summary>
	public static class AppExtensionPasswordGeneratorOptions
	{
		public const string MinLengthKey = "password_min_length";

		public const string MaxLengthKey = "password_max_length";

		public const string RequireDigitsKey = "password_require_digits";

		public const string RequireSymbolsKey = "password_require_symbols";

		public const string ForbiddenCharactersKey = "password_forbidden_characters";	
	}

	/// <summary>
	/// Errors codes
	/// </summary>
	public static class AppExtensionErrorCodes
	{
		public const int CancelledByUser = 0;

		public const int APINotAvailable = 1;

		public const int FailedToContactExtension = 2;

		public const int FailedToLoadItemProviderData = 3;

		public const int CollectFieldsScriptFailed = 4;

		public const int FillFieldsScriptFailed = 5;

		public const int UnexpectedData = 6;

		public const int FailedToObtainURLStringFromWebView = 7;
	}
}
