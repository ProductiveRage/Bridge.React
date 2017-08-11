using Bridge.Html5;

namespace Bridge.React
{
	[External]
	[ObjectLiteral]
	public sealed class KeyboardEvent<TCurrentTarget> : SyntheticEvent<TCurrentTarget> where TCurrentTarget : Element
	{
		private KeyboardEvent() { }

		public readonly bool AltKey;
		public readonly int CharCode;
		public readonly bool CtrlKey;
		public readonly string Key;
		public readonly int KeyCode;
		public readonly string Locale;
		public readonly int Location;
		public readonly bool MetaKey;
		public readonly bool Repeat;
		public readonly bool ShiftKey;
		public readonly int Which;

		[External]
		public extern bool GetModifierState(int key);

		/// <summary>
		/// A collection of named <see cref="KeyboardEvent{TCurrentTarget}.Key"/> attribute values.
		/// These are all based on the W3C UI Events Specification, with the key values listed in https://www.w3.org/TR/uievents-key/.
		/// </summary>
		public static class NamedKeys
		{
			// NOTE: These are only a collection of reserved names for keyboard keys that aren't representable in Unicode.
			// The Key attribute can be any Unicode string to represent other characters like "Q", "3", " ", etc.
			// I've not attempted to "enum" these names because the Key attribute can accept any string, and having it be
			// something like a Union<string, NamedKey> wouldn't allow handy constructs like switching on the value easily.

			// § 3.1. Special Keys
			public const string Unidentified = "Unidentified";

			// § 3.2. Modifier Keys
			public const string Alt = "Alt";
			public const string AltGraph = "AltGraph";
			public const string CapsLock = "CapsLock";
			public const string Control = "Control";
			public const string Fn = "Fn";
			public const string FnLock = "FnLock";
			public const string Meta = "Meta";
			public const string NumLock = "NumLock";
			public const string ScrollLock = "ScrollLock";
			public const string Shift = "Shift";
			public const string Symbol = "Symbol";
			public const string SymbolLock = "SymbolLock";

			// Legacy modifier keys:
			public const string Hyper = "Hyper";
			public const string Super = "Super";


			// § 3.3. Whitespace Keys
			public const string Enter = "Enter";
			public const string Tab = "Tab";


			// § 3.4. Navigation Keys
			public const string ArrowDown = "ArrowDown";
			public const string ArrowLeft = "ArrowLeft";
			public const string ArrowRight = "ArrowRight";
			public const string ArrowUp = "ArrowUp";
			public const string End = "End";
			public const string Home = "Home";
			public const string PageDown = "PageDown";
			public const string PageUp = "PageUp";


			// § 3.5. Editing Keys
			public const string Backspace = "Backspace";
			public const string Clear = "Clear";
			public const string Copy = "Copy";
			public const string CrSel = "CrSel";
			public const string Cut = "Cut";
			public const string Delete = "Delete";
			public const string EraseEof = "EraseEof";
			public const string ExSel = "ExSel";
			public const string Insert = "Insert";
			public const string Paste = "Paste";
			public const string Redo = "Redo";
			public const string Undo = "Undo";


			// § 3.6. UI Keys
			public const string Accept = "Accept";
			public const string Again = "Again";
			public const string Attn = "Attn";
			public const string Cancel = "Cancel";
			public const string ContextMenu = "ContextMenu";
			public const string Escape = "Escape";
			public const string Execute = "Execute";
			public const string Find = "Find";
			public const string Help = "Help";
			public const string Pause = "Pause";
			public const string Play = "Play";
			public const string Props = "Props";
			public const string Select = "Select";
			public const string ZoomIn = "ZoomIn";
			public const string ZoomOut = "ZoomOut";


			// § 3.7. Device Keys
			public const string BrightnessDown = "BrightnessDown";
			public const string BrightnessUp = "BrightnessUp";
			public const string Eject = "Eject";
			public const string LogOff = "LogOff";
			public const string Power = "Power";
			public const string PowerOff = "PowerOff";
			public const string PrintScreen = "PrintScreen";
			public const string Hibernate = "Hibernate";
			public const string Standby = "Standby";
			public const string WakeUp = "WakeUp";


			// § 3.8. IME and Composition Keys
			public const string AllCandidates = "AllCandidates";
			public const string Alphanumeric = "Alphanumeric";
			public const string CodeInput = "CodeInput";
			public const string Compose = "Compose";
			public const string Convert = "Convert";
			public const string Dead = "Dead";
			public const string FinalMode = "FinalMode";
			public const string GroupFirst = "GroupFirst";
			public const string GroupLast = "GroupLast";
			public const string GroupNext = "GroupNext";
			public const string GroupPrevious = "GroupPrevious";
			public const string ModeChange = "ModeChange";
			public const string NextCandidate = "NextCandidate";
			public const string NonConvert = "NonConvert";
			public const string PreviousCandidate = "PreviousCandidate";
			public const string Process = "Process";
			public const string SingleCandidate = "SingleCandidate";

			// Keys specific to Korean keyboards:
			public const string HangulMode = "HangulMode";
			public const string HanjaMode = "HanjaMode";
			public const string JunjaMode = "JunjaMode";

			// Keys specific to Japanese keyboards:
			public const string Eisu = "Eisu";
			public const string Hankaku = "Hankaku";
			public const string Hiragana = "Hiragana";
			public const string HiraganaKatakana = "HiraganaKatakana";
			public const string KanaMode = "KanaMode";
			public const string KanjiMode = "KanjiMode";
			public const string Katakana = "Katakana";
			public const string Romaji = "Romaji";
			public const string Zenkaku = "Zenkaku";
			public const string ZenkakuHankaku = "ZenkakuHankaku";


			// § 3.9. General-Purpose Function Keys
			public const string F1 = "F1";
			public const string F2 = "F2";
			public const string F3 = "F3";
			public const string F4 = "F4";
			public const string F5 = "F5";
			public const string F6 = "F6";
			public const string F7 = "F7";
			public const string F8 = "F8";
			public const string F9 = "F9";
			public const string F10 = "F10";
			public const string F11 = "F11";
			public const string F12 = "F12";
			public const string Soft1 = "Soft1";
			public const string Soft2 = "Soft2";
			public const string Soft3 = "Soft3";
			public const string Soft4 = "Soft4";


			// § 3.10. Multimedia Keys
			public const string ChannelDown = "ChannelDown";
			public const string ChannelUp = "ChannelUp";
			public const string Close = "Close";
			public const string MailForward = "MailForward";
			public const string MailReply = "MailReply";
			public const string MailSend = "MailSend";
			public const string MediaClose = "MediaClose";
			public const string MediaFastForward = "MediaFastForward";
			public const string MediaPause = "MediaPause";
			public const string MediaPlay = "MediaPlay";
			public const string MediaPlayPause = "MediaPlayPause";
			public const string MediaRecord = "MediaRecord";
			public const string MediaRewind = "MediaRewind";
			public const string MediaStop = "MediaStop";
			public const string MediaTrackNext = "MediaTrackNext";
			public const string MediaTrackPrevious = "MediaTrackPrevious";
			public const string New = "New";
			public const string Open = "Open";
			public const string Print = "Print";
			public const string Save = "Save";
			public const string SpellCheck = "SpellCheck";


			// § 3.11. Multimedia Numpad Keys
			public const string Key11 = "Key11";
			public const string Key12 = "Key12";


			// § 3.12. Audio Keys
			public const string AudioBalanceLeft = "AudioBalanceLeft";
			public const string AudioBalanceRight = "AudioBalanceRight";
			public const string AudioBassBoostDown = "AudioBassBoostDown";
			public const string AudioBassBoostToggle = "AudioBassBoostToggle";
			public const string AudioBassBoostUp = "AudioBassBoostUp";
			public const string AudioFaderFront = "AudioFaderFront";
			public const string AudioFaderRear = "AudioFaderRear";
			public const string AudioSurroundModeNext = "AudioSurroundModeNext";
			public const string AudioTrebleDown = "AudioTrebleDown";
			public const string AudioTrebleUp = "AudioTrebleUp";
			public const string AudioVolumeDown = "AudioVolumeDown";
			public const string AudioVolumeUp = "AudioVolumeUp";
			public const string AudioVolumeMute = "AudioVolumeMute";
			public const string MicrophoneToggle = "MicrophoneToggle";
			public const string MicrophoneVolumeDown = "MicrophoneVolumeDown";
			public const string MicrophoneVolumeUp = "MicrophoneVolumeUp";
			public const string MicrophoneVolumeMute = "MicrophoneVolumeMute";


			// § 3.13. Speech Keys
			public const string SpeechCorrectionList = "SpeechCorrectionList";
			public const string SpeechInputToggle = "SpeechInputToggle";


			// § 3.14. Application Keys
			public const string LaunchApplication1 = "LaunchApplication1";
			public const string LaunchApplication2 = "LaunchApplication2";
			public const string LaunchCalendar = "LaunchCalendar";
			public const string LaunchContacts = "LaunchContacts";
			public const string LaunchMail = "LaunchMail";
			public const string LaunchMediaPlayer = "LaunchMediaPlayer";
			public const string LaunchMusicPlayer = "LaunchMusicPlayer";
			public const string LaunchPhone = "LaunchPhone";
			public const string LaunchScreenSaver = "LaunchScreenSaver";
			public const string LaunchSpreadsheet = "LaunchSpreadsheet";
			public const string LaunchWebBrowser = "LaunchWebBrowser";
			public const string LaunchWebCam = "LaunchWebCam";
			public const string LaunchWordProcessor = "LaunchWordProcessor";


			// § 3.15. Browser Keys
			public const string BrowserBack = "BrowserBack";
			public const string BrowserFavorites = "BrowserFavorites";
			public const string BrowserForward = "BrowserForward";
			public const string BrowserHome = "BrowserHome";
			public const string BrowserRefresh = "BrowserRefresh";
			public const string BrowserSearch = "BrowserSearch";
			public const string BrowserStop = "BrowserStop";


			// § 3.16. Mobile Phone Keys
			public const string AppSwitch = "AppSwitch";
			public const string Call = "Call";
			public const string Camera = "Camera";
			public const string CameraFocus = "CameraFocus";
			public const string EndCall = "EndCall";
			public const string GoBack = "GoBack";
			public const string GoHome = "GoHome";
			public const string HeadsetHook = "HeadsetHook";
			public const string LastNumberRedial = "LastNumberRedial";
			public const string Notification = "Notification";
			public const string MannerMode = "MannerMode";
			public const string VoiceDial = "VoiceDial";


			// § 3.17. TV Keys
			public const string TV = "TV";
			public const string TV3DMode = "TV3DMode";
			public const string TVAntennaCable = "TVAntennaCable";
			public const string TVAudioDescription = "TVAudioDescription";
			public const string TVAudioDescriptionMixDown = "TVAudioDescriptionMixDown";
			public const string TVAudioDescriptionMixUp = "TVAudioDescriptionMixUp";
			public const string TVContentsMenu = "TVContentsMenu";
			public const string TVDataService = "TVDataService";
			public const string TVInput = "TVInput";
			public const string TVInputComponent1 = "TVInputComponent1";
			public const string TVInputComponent2 = "TVInputComponent2";
			public const string TVInputComposite1 = "TVInputComposite1";
			public const string TVInputComposite2 = "TVInputComposite2";
			public const string TVInputHDMI1 = "TVInputHDMI1";
			public const string TVInputHDMI2 = "TVInputHDMI2";
			public const string TVInputHDMI3 = "TVInputHDMI3";
			public const string TVInputHDMI4 = "TVInputHDMI4";
			public const string TVInputVGA1 = "TVInputVGA1";
			public const string TVMediaContext = "TVMediaContext";
			public const string TVNetwork = "TVNetwork";
			public const string TVNumberEntry = "TVNumberEntry";
			public const string TVPower = "TVPower";
			public const string TVRadioService = "TVRadioService";
			public const string TVSatellite = "TVSatellite";
			public const string TVSatelliteBS = "TVSatelliteBS";
			public const string TVSatelliteCS = "TVSatelliteCS";
			public const string TVSatelliteToggle = "TVSatelliteToggle";
			public const string TVTerrestrialAnalog = "TVTerrestrialAnalog";
			public const string TVTerrestrialDigital = "TVTerrestrialDigital";
			public const string TVTimer = "TVTimer";


			// § 3.18. Media Controller Keys
			public const string AVRInput = "AVRInput";
			public const string AVRPower = "AVRPower";
			public const string ColorF0Red = "ColorF0Red";
			public const string ColorF1Green = "ColorF1Green";
			public const string ColorF2Yellow = "ColorF2Yellow";
			public const string ColorF3Blue = "ColorF3Blue";
			public const string ColorF4Grey = "ColorF4Grey";
			public const string ColorF5Brown = "ColorF5Brown";
			public const string ClosedCaptionToggle = "ClosedCaptionToggle";
			public const string Dimmer = "Dimmer";
			public const string DisplaySwap = "DisplaySwap";
			public const string DVR = "DVR";
			public const string Exit = "Exit";
			public const string FavoriteClear0 = "FavoriteClear0";
			public const string FavoriteClear1 = "FavoriteClear1";
			public const string FavoriteClear2 = "FavoriteClear2";
			public const string FavoriteClear3 = "FavoriteClear3";
			public const string FavoriteRecall0 = "FavoriteRecall0";
			public const string FavoriteRecall1 = "FavoriteRecall1";
			public const string FavoriteRecall2 = "FavoriteRecall2";
			public const string FavoriteRecall3 = "FavoriteRecall3";
			public const string FavoriteStore0 = "FavoriteStore0";
			public const string FavoriteStore1 = "FavoriteStore1";
			public const string FavoriteStore2 = "FavoriteStore2";
			public const string FavoriteStore3 = "FavoriteStore3";
			public const string Guide = "Guide";
			public const string GuideNextDay = "GuideNextDay";
			public const string GuidePreviousDay = "GuidePreviousDay";
			public const string Info = "Info";
			public const string InstantReplay = "InstantReplay";
			public const string Link = "Link";
			public const string ListProgram = "ListProgram";
			public const string LiveContent = "LiveContent";
			public const string Lock = "Lock";
			public const string MediaApps = "MediaApps";
			public const string MediaAudioTrack = "MediaAudioTrack";
			public const string MediaLast = "MediaLast";
			public const string MediaSkipBackward = "MediaSkipBackward";
			public const string MediaSkipForward = "MediaSkipForward";
			public const string MediaStepBackward = "MediaStepBackward";
			public const string MediaStepForward = "MediaStepForward";
			public const string MediaTopMenu = "MediaTopMenu";
			public const string NavigateIn = "NavigateIn";
			public const string NavigateNext = "NavigateNext";
			public const string NavigateOut = "NavigateOut";
			public const string NavigatePrevious = "NavigatePrevious";
			public const string NextFavoriteChannel = "NextFavoriteChannel";
			public const string NextUserProfile = "NextUserProfile";
			public const string OnDemand = "OnDemand";
			public const string Pairing = "Pairing";
			public const string PinPDown = "PinPDown";
			public const string PinPMove = "PinPMove";
			public const string PinPToggle = "PinPToggle";
			public const string PinPUp = "PinPUp";
			public const string PlaySpeedDown = "PlaySpeedDown";
			public const string PlaySpeedReset = "PlaySpeedReset";
			public const string PlaySpeedUp = "PlaySpeedUp";
			public const string RandomToggle = "RandomToggle";
			public const string RcLowBattery = "RcLowBattery";
			public const string RecordSpeedNext = "RecordSpeedNext";
			public const string RfBypass = "RfBypass";
			public const string ScanChannelsToggle = "ScanChannelsToggle";
			public const string ScreenModeNext = "ScreenModeNext";
			public const string Settings = "Settings";
			public const string SplitScreenToggle = "SplitScreenToggle";
			public const string STBInput = "STBInput";
			public const string STBPower = "STBPower";
			public const string Subtitle = "Subtitle";
			public const string Teletext = "Teletext";
			public const string VideoModeNext = "VideoModeNext";
			public const string Wink = "Wink";
			public const string ZoomToggle = "ZoomToggle";
		}
	}
}
