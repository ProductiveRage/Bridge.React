using System;
using Bridge.Html5;

namespace Bridge.React
{
	// Based on information from https://facebook.github.io/react/docs/events.html
	[External]
	[ObjectLiteral]
	public abstract class DomElementWithEventsAttributes<TCurrentTarget> : DomElementsAttributes where TCurrentTarget : HTMLElement
	{
		public Action<WheelEvent<TCurrentTarget>> OnCopy { get; set; }
		public Action<WheelEvent<TCurrentTarget>> OnCut { get; set; }
		public Action<WheelEvent<TCurrentTarget>> OnPaste { get; set; }

		public Action<CompositionEvent<TCurrentTarget>> OnCompositionEnd { get; set; }
		public Action<CompositionEvent<TCurrentTarget>> OnCompositionStart { get; set; }
		public Action<CompositionEvent<TCurrentTarget>> OnCompositionUpdate { get; set; }

		public Action<KeyboardEvent<TCurrentTarget>> OnKeyDown { get; set; }
		public Action<KeyboardEvent<TCurrentTarget>> OnKeyPress { get; set; }
		public Action<KeyboardEvent<TCurrentTarget>> OnKeyUp { get; set; }

		public Action<FocusEvent<TCurrentTarget>> OnFocus { get; set; }
		public Action<FocusEvent<TCurrentTarget>> OnBlur { get; set; }

		public Action<FormEvent<TCurrentTarget>> OnChange { get; set; }
		public Action<FormEvent<TCurrentTarget>> OnInput { get; set; }
		public Action<FormEvent<TCurrentTarget>> OnSubmit { get; set; }

		public Action<MouseEvent<TCurrentTarget>> OnClick { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnContextMenu { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnDoubleClick { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDrag { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDragEnd { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDragEnter { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDragExit { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDragLeave { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDragOver { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDragStart { get; set; }
		public Action<DragEvent<TCurrentTarget>> OnDrop { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseDown { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseEnter { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseLeave { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseMove { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseOut { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseOver { get; set; }
		public Action<MouseEvent<TCurrentTarget>> OnMouseUp { get; set; }

		public Action<SelectionEvent<TCurrentTarget>> OnSelect { get; set; }

		public Action<TouchEvent<TCurrentTarget>> OnTouchCancel { get; set; }
		public Action<TouchEvent<TCurrentTarget>> OnTouchEnd { get; set; }
		public Action<TouchEvent<TCurrentTarget>> OnTouchMove { get; set; }
		public Action<TouchEvent<TCurrentTarget>> OnTouchStart { get; set; }

		public Action<UIEvent<TCurrentTarget>> OnScroll { get; set; }

		public Action<WheelEvent<TCurrentTarget>> OnWheel { get; set; }

		public Action<MediaEvent<TCurrentTarget>> OnAbort { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnCanPlay { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnCanPlayThrough { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnDurationChange { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnEmptied { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnEncrypted { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnEnded { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnError { get; set; } // This is listed as both a media event AND an image event, but they're basically the same so just left it as a media event
		public Action<ImageEvent<TCurrentTarget>> OnLoad { get; set; } // This is listed as a image event but since OnError was made a media event, it's easiest to do the same for this too
		public Action<MediaEvent<TCurrentTarget>> OnLoadedData { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnLoadedMetadata { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnLoadStart { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnPause { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnPlay { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnPlaying { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnProgress { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnRateChange { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnSeeked { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnSeeking { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnStalled { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnSuspend { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnTimeUpdate { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnVolumeChange { get; set; }
		public Action<MediaEvent<TCurrentTarget>> OnWaiting { get; set; }
	}
}
