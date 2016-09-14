using System;
using Bridge.Html5;

namespace Bridge.React
{
	// Based on information from https://facebook.github.io/react/docs/events.html
	[ObjectLiteral]
	public abstract class DomElementWithEventsAttributes<TCurrentTarget> : DomElementsAttributes where TCurrentTarget : Element
	{
		public Action<WheelEvent<TCurrentTarget>> OnCopy { private get; set; }
		public Action<WheelEvent<TCurrentTarget>> OnCut { private get; set; }
		public Action<WheelEvent<TCurrentTarget>> OnPaste { private get; set; }

		public Action<CompositionEvent<TCurrentTarget>> OnCompositionEnd { private get; set; }
		public Action<CompositionEvent<TCurrentTarget>> OnCompositionStart { private get; set; }
		public Action<CompositionEvent<TCurrentTarget>> OnCompositionUpdate { private get; set; }

		public Action<KeyboardEvent<TCurrentTarget>> OnKeyDown { private get; set; }
		public Action<KeyboardEvent<TCurrentTarget>> OnKeyPress { private get; set; }
		public Action<KeyboardEvent<TCurrentTarget>> OnKeyUp { private get; set; }

		public Action<FocusEvent<TCurrentTarget>> OnFocus { private get; set; }
		public Action<FocusEvent<TCurrentTarget>> OnBlur { private get; set; }

		public Action<FormEvent<TCurrentTarget>> OnChange { private get; set; }
		public Action<FormEvent<TCurrentTarget>> OnInput { private get; set; }
		public Action<FormEvent<TCurrentTarget>> OnSubmit { private get; set; }

		public Action<MouseEvent<TCurrentTarget>> OnClick { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnContextMenu { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDoubleClick { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDrag { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDragEnd { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDragEnter { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDragExit { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDragLeave { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDragOver { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDragStart { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDrop { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseDown { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseEnter { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseLeave { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseMove { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseOut { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseOver { private get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseUp { private get; set; }

		public Action<SelectionEvent<TCurrentTarget>> OnSelect { private get; set; }

		public Action<TouchEvent<TCurrentTarget>> OnTouchCancel { private get; set; }
		public Action<TouchEvent<TCurrentTarget>> OnTouchEnd { private get; set; }
		public Action<TouchEvent<TCurrentTarget>> OnTouchMove { private get; set; }
		public Action<TouchEvent<TCurrentTarget>> OnTouchStart { private get; set; }

		public Action<UIEvent<TCurrentTarget>> OnScroll { private get; set; }

		public Action<WheelEvent<TCurrentTarget>> OnWheel { private get; set; }

		public Action<MediaEvent<TCurrentTarget>> OnAbort { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnCanPlay { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnCanPlayThrough { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnDurationChange { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnEmptied { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnEncrypted { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnEnded { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnError { private get; set; } // This is listed as both a media event AND an image event, but they're basically the same so just left it as a media event
		public Action<ImageEvent<TCurrentTarget>> OnLoad { private get; set; } // This is listed as a image event but since OnError was made a media event, it's easiest to do the same for this too
		public Action<MediaEvent<TCurrentTarget>> OnLoadedData { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnLoadedMetadata { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnLoadStart { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnPause { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnPlay { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnPlaying { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnProgress { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnRateChange { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnSeeked { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnSeeking { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnStalled { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnSuspend { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnTimeUpdate { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnVolumeChange { private get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnWaiting { private get; set; }
	}
}
