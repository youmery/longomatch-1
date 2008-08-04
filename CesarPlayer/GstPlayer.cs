// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace CesarPlayer {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public  class GstPlayer :GLib.Object ,IPlayer, IMetadataReader{

			

		public event         SegmentDoneHandler SegmentDoneEvent;
		
		
		[Obsolete]
		protected GstPlayer(GLib.GType gtype) : base(gtype) {}
		public GstPlayer(IntPtr raw) : base(raw) {}

		
		
		
		[DllImport("libcesarplayer.dll")]
		static extern IntPtr bacon_video_widget_new(int width, int height, int type, out IntPtr error);

		public GstPlayer (int width, int height, CesarPlayer.BvwUseType type) : base (IntPtr.Zero)
		{
			
			
		
			if (GetType () != typeof (GstPlayer)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			InitBackend(null);
			IntPtr error = IntPtr.Zero;
			Raw = bacon_video_widget_new(width, height, (int) type, out error);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			
			
		}

		[GLib.Property ("seekable")]
		public bool Seekable {
			get {
				GLib.Value val = GetProperty ("seekable");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_get_logo_mode(IntPtr raw);

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_logo_mode(IntPtr raw, bool logo_mode);

		[GLib.Property ("logo_mode")]
		public bool LogoMode {
			get  {
				bool raw_ret = bacon_video_widget_get_logo_mode(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				bacon_video_widget_set_logo_mode(Handle, value);
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern long bacon_video_widget_get_stream_length(IntPtr raw);

		[GLib.Property ("stream_length")]
		public long StreamLength {
			get  {
				long raw_ret = bacon_video_widget_get_stream_length(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern int bacon_video_widget_get_volume(IntPtr raw);

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_volume(IntPtr raw, int volume);

		[GLib.Property ("volume")]
		public int Volume {
			get  {
				int raw_ret = bacon_video_widget_get_volume(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				bacon_video_widget_set_volume(Handle, value);
			}
		}

		[GLib.Property ("showcursor")]
		public bool Showcursor {
			get {
				GLib.Value val = GetProperty ("showcursor");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("showcursor", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("playing")]
		public bool Playing {
			get {
				GLib.Value val = GetProperty ("playing");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern float bacon_video_widget_get_position(IntPtr raw);

		[GLib.Property ("position")]
		public float Position {
			get  {
				float raw_ret = bacon_video_widget_get_position(Handle);
				float ret = raw_ret;
				return ret;
			}
			set {
				this.Seek(value);
			}
		}

		[GLib.Property ("mediadev")]
		public string Mediadev {
			get {
				GLib.Value val = GetProperty ("mediadev");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("mediadev", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void StateChangedSignalDelegate (IntPtr arg0, bool arg1, IntPtr gch);

		static void StateChangedSignalCallback (IntPtr arg0, bool arg1, IntPtr gch)
		{
			CesarPlayer.StateChangedArgs args = new CesarPlayer.StateChangedArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				args.Args[0] = arg1;
				CesarPlayer.StateChangedHandler handler = (CesarPlayer.StateChangedHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void StateChangedVMDelegate (IntPtr bvw, bool playing);

		static StateChangedVMDelegate StateChangedVMCallback;

		static void statechanged_cb (IntPtr bvw, bool playing)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnStateChanged (playing);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideStateChanged (GLib.GType gtype)
		{
			if (StateChangedVMCallback == null)
				StateChangedVMCallback = new StateChangedVMDelegate (statechanged_cb);
			OverrideVirtualMethod (gtype, "state_changed", StateChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideStateChanged")]
		protected virtual void OnStateChanged (bool playing)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (playing);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("state_changed")]
		public event CesarPlayer.StateChangedHandler StateChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "state_changed", new StateChangedSignalDelegate(StateChangedSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "state_changed", new StateChangedSignalDelegate(StateChangedSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void GotRedirectSignalDelegate (IntPtr arg0, IntPtr arg1, IntPtr gch);

		static void GotRedirectSignalCallback (IntPtr arg0, IntPtr arg1, IntPtr gch)
		{
			CesarPlayer.GotRedirectArgs args = new CesarPlayer.GotRedirectArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				args.Args[0] = GLib.Marshaller.Utf8PtrToString (arg1);
				CesarPlayer.GotRedirectHandler handler = (CesarPlayer.GotRedirectHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void GotRedirectVMDelegate (IntPtr bvw, IntPtr mrl);

		static GotRedirectVMDelegate GotRedirectVMCallback;

		static void gotredirect_cb (IntPtr bvw, IntPtr mrl)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnGotRedirect (GLib.Marshaller.Utf8PtrToString (mrl));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideGotRedirect (GLib.GType gtype)
		{
			if (GotRedirectVMCallback == null)
				GotRedirectVMCallback = new GotRedirectVMDelegate (gotredirect_cb);
			OverrideVirtualMethod (gtype, "got-redirect", GotRedirectVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideGotRedirect")]
		protected virtual void OnGotRedirect (string mrl)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (mrl);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("got-redirect")]
		public event CesarPlayer.GotRedirectHandler GotRedirect {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got-redirect", new GotRedirectSignalDelegate(GotRedirectSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got-redirect", new GotRedirectSignalDelegate(GotRedirectSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void SegmentDoneVMDelegate (IntPtr bvw);

		static SegmentDoneVMDelegate SegmentDoneVMCallback;

		static void segmentdone_cb (IntPtr bvw)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnSegmentDone ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideSegmentDone (GLib.GType gtype)
		{
			if (SegmentDoneVMCallback == null)
				SegmentDoneVMCallback = new SegmentDoneVMDelegate (segmentdone_cb);
			OverrideVirtualMethod (gtype, "segment_done", SegmentDoneVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideSegmentDone")]
		protected virtual void OnSegmentDone ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			
		}

		[GLib.Signal("segment_done")]
		public event System.EventHandler SegmentDone {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "segment_done");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "segment_done");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void EosVMDelegate (IntPtr bvw);

		static EosVMDelegate EosVMCallback;

		static void eos_cb (IntPtr bvw)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnEos ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideEos (GLib.GType gtype)
		{
			if (EosVMCallback == null)
				EosVMCallback = new EosVMDelegate (eos_cb);
			OverrideVirtualMethod (gtype, "eos", EosVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideEos")]
		protected virtual void OnEos ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("eos")]
		public event System.EventHandler Eos {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "eos");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "eos");
				sig.RemoveDelegate (value);
			}
		}
		
		

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void ErrorSignalDelegate (IntPtr arg0, IntPtr arg1, bool arg2, bool arg3, IntPtr gch);

		static void ErrorSignalCallback (IntPtr arg0, IntPtr arg1, bool arg2, bool arg3, IntPtr gch)
		{
			CesarPlayer.ErrorArgs args = new CesarPlayer.ErrorArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[3];
				args.Args[0] = GLib.Marshaller.Utf8PtrToString (arg1);
				args.Args[1] = arg2;
				args.Args[2] = arg3;
				CesarPlayer.ErrorHandler handler = (CesarPlayer.ErrorHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void ErrorVMDelegate (IntPtr bvw, IntPtr message, bool playback_stopped, bool fatal);

		static ErrorVMDelegate ErrorVMCallback;

		static void error_cb (IntPtr bvw, IntPtr message, bool playback_stopped, bool fatal)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnError (GLib.Marshaller.Utf8PtrToString (message), playback_stopped, fatal);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideError (GLib.GType gtype)
		{
			if (ErrorVMCallback == null)
				ErrorVMCallback = new ErrorVMDelegate (error_cb);
			OverrideVirtualMethod (gtype, "error", ErrorVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideError")]
		protected virtual void OnError (string message, bool playback_stopped, bool fatal)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (4);
			GLib.Value[] vals = new GLib.Value [4];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (message);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (playback_stopped);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (fatal);
			inst_and_params.Append (vals [3]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("error")]
		public event CesarPlayer.ErrorHandler Error {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "error", new ErrorSignalDelegate(ErrorSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "error", new ErrorSignalDelegate(ErrorSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void BufferingSignalDelegate (IntPtr arg0, uint arg1, IntPtr gch);

		static void BufferingSignalCallback (IntPtr arg0, uint arg1, IntPtr gch)
		{
			CesarPlayer.BufferingArgs args = new CesarPlayer.BufferingArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				args.Args[0] = arg1;
				CesarPlayer.BufferingHandler handler = (CesarPlayer.BufferingHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void BufferingVMDelegate (IntPtr bvw, uint progress);

		static BufferingVMDelegate BufferingVMCallback;

		static void buffering_cb (IntPtr bvw, uint progress)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnBuffering (progress);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideBuffering (GLib.GType gtype)
		{
			if (BufferingVMCallback == null)
				BufferingVMCallback = new BufferingVMDelegate (buffering_cb);
			OverrideVirtualMethod (gtype, "buffering", BufferingVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideBuffering")]
		protected virtual void OnBuffering (uint progress)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (progress);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("buffering")]
		public event CesarPlayer.BufferingHandler Buffering {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "buffering", new BufferingSignalDelegate(BufferingSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "buffering", new BufferingSignalDelegate(BufferingSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void ChannelsChangeVMDelegate (IntPtr bvw);

		static ChannelsChangeVMDelegate ChannelsChangeVMCallback;

		static void channelschange_cb (IntPtr bvw)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnChannelsChange ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideChannelsChange (GLib.GType gtype)
		{
			if (ChannelsChangeVMCallback == null)
				ChannelsChangeVMCallback = new ChannelsChangeVMDelegate (channelschange_cb);
			OverrideVirtualMethod (gtype, "channels-change", ChannelsChangeVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideChannelsChange")]
		protected virtual void OnChannelsChange ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("channels-change")]
		public event System.EventHandler ChannelsChange {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "channels-change");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "channels-change");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void GotMetadataVMDelegate (IntPtr bvw);

		static GotMetadataVMDelegate GotMetadataVMCallback;

		static void gotmetadata_cb (IntPtr bvw)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnGotMetadata ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideGotMetadata (GLib.GType gtype)
		{
			if (GotMetadataVMCallback == null)
				GotMetadataVMCallback = new GotMetadataVMDelegate (gotmetadata_cb);
			OverrideVirtualMethod (gtype, "got-metadata", GotMetadataVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideGotMetadata")]
		protected virtual void OnGotMetadata ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("got-metadata")]
		public event System.EventHandler GotMetadata {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got-metadata");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got-metadata");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void TickSignalDelegate (IntPtr arg0, long arg1, long arg2, float arg3, bool arg4, IntPtr gch);

		static void TickSignalCallback (IntPtr arg0, long arg1, long arg2, float arg3, bool arg4, IntPtr gch)
		{
			CesarPlayer.TickArgs args = new CesarPlayer.TickArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[4];
				args.Args[0] = arg1;
				args.Args[1] = arg2;
				args.Args[2] = arg3;
				args.Args[3] = arg4;
				CesarPlayer.TickHandler handler = (CesarPlayer.TickHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void TickVMDelegate (IntPtr bvw, long current_time, long stream_length, float current_position, bool seekable);

		static TickVMDelegate TickVMCallback;

		static void tick_cb (IntPtr bvw, long current_time, long stream_length, float current_position, bool seekable)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnTick (current_time, stream_length, current_position, seekable);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideTick (GLib.GType gtype)
		{
			if (TickVMCallback == null)
				TickVMCallback = new TickVMDelegate (tick_cb);
			OverrideVirtualMethod (gtype, "tick", TickVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideTick")]
		protected virtual void OnTick (long current_time, long stream_length, float current_position, bool seekable)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (5);
			GLib.Value[] vals = new GLib.Value [5];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (current_time);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (stream_length);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (current_position);
			inst_and_params.Append (vals [3]);
			vals [4] = new GLib.Value (seekable);
			inst_and_params.Append (vals [4]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("tick")]
		public event CesarPlayer.TickHandler Tick {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "tick", new TickSignalDelegate(TickSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "tick", new TickSignalDelegate(TickSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void TitleChangeSignalDelegate (IntPtr arg0, IntPtr arg1, IntPtr gch);

		static void TitleChangeSignalCallback (IntPtr arg0, IntPtr arg1, IntPtr gch)
		{
			CesarPlayer.TitleChangeArgs args = new CesarPlayer.TitleChangeArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				args.Args[0] = GLib.Marshaller.Utf8PtrToString (arg1);
				CesarPlayer.TitleChangeHandler handler = (CesarPlayer.TitleChangeHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void TitleChangeVMDelegate (IntPtr bvw, IntPtr title);

		static TitleChangeVMDelegate TitleChangeVMCallback;

		static void titlechange_cb (IntPtr bvw, IntPtr title)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnTitleChange (GLib.Marshaller.Utf8PtrToString (title));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideTitleChange (GLib.GType gtype)
		{
			if (TitleChangeVMCallback == null)
				TitleChangeVMCallback = new TitleChangeVMDelegate (titlechange_cb);
			OverrideVirtualMethod (gtype, "title-change", TitleChangeVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideTitleChange")]
		protected virtual void OnTitleChange (string title)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (title);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("title-change")]
		public event CesarPlayer.TitleChangeHandler TitleChange {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "title-change", new TitleChangeSignalDelegate(TitleChangeSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "title-change", new TitleChangeSignalDelegate(TitleChangeSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void GotDurationVMDelegate (IntPtr bvw);

		static GotDurationVMDelegate GotDurationVMCallback;

		static void gotduration_cb (IntPtr bvw)
		{
			try {
				GstPlayer bvw_managed = GLib.Object.GetObject (bvw, false) as GstPlayer;
				bvw_managed.OnGotDuration ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideGotDuration (GLib.GType gtype)
		{
			if (GotDurationVMCallback == null)
				GotDurationVMCallback = new GotDurationVMDelegate (gotduration_cb);
			OverrideVirtualMethod (gtype, "got_duration", GotDurationVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(CesarPlayer.GstPlayer), ConnectionMethod="OverrideGotDuration")]
		protected virtual void OnGotDuration ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("got_duration")]
		public event System.EventHandler GotDuration {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got_duration");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got_duration");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_pause(IntPtr raw);

		public void Pause() {
			bacon_video_widget_pause(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_is_playing(IntPtr raw);

		public bool IsPlaying { 
			get {
				bool raw_ret = bacon_video_widget_is_playing(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_get_auto_resize(IntPtr raw);

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_auto_resize(IntPtr raw, bool auto_resize);

		public bool AutoResize { 
			get {
				bool raw_ret = bacon_video_widget_get_auto_resize(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				bacon_video_widget_set_auto_resize(Handle, value);
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_seek(IntPtr raw, float position);

		public bool Seek(float position) {
			bool raw_ret = bacon_video_widget_seek(Handle, position);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr bacon_video_widget_get_backend_name(IntPtr raw);

		public string BackendName { 
			get {
				IntPtr raw_ret = bacon_video_widget_get_backend_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_can_set_zoom(IntPtr raw);

		public bool CanSetZoom() {
			bool raw_ret = bacon_video_widget_can_set_zoom(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_init_backend(out int argc, IntPtr argv);

		public static int InitBackend(string argv) {
			int argc;
			bacon_video_widget_init_backend(out argc, GLib.Marshaller.StringToPtrGStrdup(argv));
			return argc;
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_get_show_cursor(IntPtr raw);

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_show_cursor(IntPtr raw, bool use_cursor);

		public bool ShowCursor { 
			get {
				bool raw_ret = bacon_video_widget_get_show_cursor(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				bacon_video_widget_set_show_cursor(Handle, value);
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_seek_in_segment(IntPtr raw, long pos);

		public bool SeekInSegment(long pos) {
			bool raw_ret = bacon_video_widget_seek_in_segment(Handle, pos);
			bool ret = raw_ret;
			return ret;
		}
		
		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_new_file_seek(IntPtr raw, long start,long stop);

		public bool NewFileSeek(long start, long stop) {
			bool raw_ret = bacon_video_widget_new_file_seek(Handle,start,stop);
			bool ret = raw_ret;
			this.Play();
			return ret;
		}
		
		[DllImport ("libcesarplayer.dll")]
		private static extern bool bacon_video_widget_segment_start_update(IntPtr player, long start);
			
		public void UpdateSegmentStartTime(long start){
			bacon_video_widget_segment_start_update(Handle,start);
		}
		
		[DllImport ("libcesarplayer.dll")]
		private static extern bool bacon_video_widget_segment_stop_update(IntPtr player, long stop);
			
		public void UpdateSegmentStopTime(long stop){
			bacon_video_widget_segment_stop_update(Handle,stop);
		}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr bacon_video_widget_get_mrl(IntPtr raw);

		public string Mrl { 
			get {
				IntPtr raw_ret = bacon_video_widget_get_mrl(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_stop(IntPtr raw);

		public void Stop() {
			bacon_video_widget_stop(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern long bacon_video_widget_get_accurate_current_time(IntPtr raw);

		public long AccurateCurrentTime { 
			get {
				long raw_ret = bacon_video_widget_get_accurate_current_time(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_media_device(IntPtr raw, IntPtr path);

		public string MediaDevice { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				bacon_video_widget_set_media_device(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}
		
		
		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_set_rate_in_segment(IntPtr raw, float rate, long stop_time);

		public bool SetRateInSegment(float rate, long stopTime) {
			return bacon_video_widget_set_rate_in_segment(Handle, rate, stopTime);
		}
		
		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_set_rate(IntPtr raw, float rate);
		
		public bool SetRate(float rate){
			return bacon_video_widget_set_rate(Handle, rate);
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_seek_time(IntPtr raw, long time, bool accurate);

		public bool SeekTo(long time, bool accurate) {
			bool raw_ret = bacon_video_widget_seek_time(Handle, time, accurate);
			bool ret = raw_ret;
			return ret;
		}
		
		public void CancelProgramedStop(){
			this.SegmentSeek(this.CurrentTime,this.StreamLength);		
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_is_seekable(IntPtr raw);

		public bool IsSeekable { 
			get {
				bool raw_ret = bacon_video_widget_is_seekable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]		
		static extern  bool bacon_video_widget_can_get_frames(IntPtr raw, out IntPtr error);

		public bool CanGetFrames() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = bacon_video_widget_can_get_frames(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}
		
		[DllImport("libcesarplayer.dll")]		
		static extern void  bacon_video_widget_get_metadata	(IntPtr raw,GstPlayerMetadataType type, out GLib.Value val);

		public object GetMetadata(GstPlayerMetadataType type) {
			GLib.Value val;
			bacon_video_widget_get_metadata(Handle,type,out val);
			return val.Val;
		}

		[DllImport("libcesarplayer.dll")]
		static extern long bacon_video_widget_get_current_time(IntPtr raw);

		public long CurrentTime { 
			get {
				long raw_ret = bacon_video_widget_get_current_time(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr bacon_video_widget_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = bacon_video_widget_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_fullscreen(IntPtr raw, bool fullscreen);

		public bool Fullscreen { 
			set {
				bacon_video_widget_set_fullscreen(Handle, value);
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_segment_seek(IntPtr raw, long start, long stop);

		public bool SegmentSeek(long start, long stop) {
			bool raw_ret = bacon_video_widget_segment_seek(Handle, start, stop);
			bool ret = raw_ret;
			this.Play();
			return ret;
		}

		[DllImport("libcesarplayer.dll")]
		static extern int bacon_video_widget_get_zoom(IntPtr raw);

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_zoom(IntPtr raw, int zoom);

		public int Zoom { 
			get {
				int raw_ret = bacon_video_widget_get_zoom(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				bacon_video_widget_set_zoom(Handle, value);
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr bacon_video_widget_get_current_frame(IntPtr raw);

		public Gdk.Pixbuf CurrentFrame { 
			get {
				IntPtr raw_ret = bacon_video_widget_get_current_frame(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_close(IntPtr raw);

		public void Close() {
			bacon_video_widget_close(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr bacon_video_widget_get_window(IntPtr raw);

		public Gtk.Widget Window { 
			get {
				IntPtr raw_ret = bacon_video_widget_get_window(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_can_set_volume(IntPtr raw);

		public bool CanSetVolume() {
			bool raw_ret = bacon_video_widget_can_set_volume(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_can_direct_seek(IntPtr raw);

		public bool CanDirectSeek() {
			bool raw_ret = bacon_video_widget_can_direct_seek(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_open(IntPtr raw, IntPtr mrl,out  IntPtr err);

		public bool Open(string mrl) {
			
			IntPtr native_mrl = GLib.Marshaller.StringToPtrGStrdup (mrl);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = bacon_video_widget_open(Handle, native_mrl, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_mrl);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
			
		}
		

		[DllImport("libcesarplayer.dll")]
		static extern bool bacon_video_widget_play(IntPtr raw);

		public bool Play() {
			bool raw_ret = bacon_video_widget_play(Handle);
			bool ret = raw_ret;
			return ret;
		}
		
		public void  TogglePlay(){	
			
			if(!this.Playing){
				this.Play();
			}
			else{
				 this.Pause();
			}
		
			
		}
		

		[DllImport("libcesarplayer.dll")]
		static extern int bacon_video_widget_error_quark();

		public static int ErrorQuark() {
			int raw_ret = bacon_video_widget_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_logo(IntPtr raw, IntPtr filename);

		public string Logo { 
			set {
				bacon_video_widget_set_logo(Handle, GLib.Marshaller.StringToPtrGStrdup(value));
			}
		}

		[DllImport("libcesarplayer.dll")]
		static extern void bacon_video_widget_set_scale_ratio(IntPtr raw, float ratio);

		public float ScaleRatio { 
			set {
				bacon_video_widget_set_scale_ratio(Handle, value);
			}
		}


		static GstPlayer ()
		{
			GtkSharp.FooSharp.ObjectManager.Initialize ();
		}
#endregion
	}
}
