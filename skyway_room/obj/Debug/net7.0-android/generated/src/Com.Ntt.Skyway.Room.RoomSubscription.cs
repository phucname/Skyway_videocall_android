using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Room {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']"
	[global::Android.Runtime.Register ("com/ntt/skyway/room/RoomSubscription", DoNotGenerateAcw=true)]
	public sealed partial class RoomSubscription : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription.Options']"
		[global::Android.Runtime.Register ("com/ntt/skyway/room/RoomSubscription$Options", DoNotGenerateAcw=true)]
		public sealed partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/RoomSubscription$Options", typeof (Options));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription.Options']/constructor[@name='RoomSubscription.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Options () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription.Options']/constructor[@name='RoomSubscription.Options' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Options (string? preferredEncodingId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_preferredEncodingId = JNIEnv.NewString ((string?)preferredEncodingId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_preferredEncodingId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_preferredEncodingId);
				}
			}

			public unsafe string? PreferredEncodingId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription.Options']/method[@name='getPreferredEncodingId' and count(parameter)=0]"
				[Register ("getPreferredEncodingId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getPreferredEncodingId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription.Options']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription.Options']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;)Lcom/ntt/skyway/room/RoomSubscription$Options;", "")]
			public unsafe global::Com.Ntt.Skyway.Room.RoomSubscription.Options Copy (string? preferredEncodingId)
			{
				const string __id = "copy.(Ljava/lang/String;)Lcom/ntt/skyway/room/RoomSubscription$Options;";
				IntPtr native_preferredEncodingId = JNIEnv.NewString ((string?)preferredEncodingId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_preferredEncodingId);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.RoomSubscription.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_preferredEncodingId);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/room/RoomSubscription", typeof (RoomSubscription));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal RoomSubscription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "")]
			get {
				const string __id = "getContentType.()Lcom/ntt/skyway/core/content/Stream$ContentType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.ContentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction0? OnCanceledHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getOnCanceledHandler' and count(parameter)=0]"
			[Register ("getOnCanceledHandler", "()Lkotlin/jvm/functions/Function0;", "")]
			get {
				const string __id = "getOnCanceledHandler.()Lkotlin/jvm/functions/Function0;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction0> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='setOnCanceledHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function0&lt;kotlin.Unit&gt;']]"
			[Register ("setOnCanceledHandler", "(Lkotlin/jvm/functions/Function0;)V", "")]
			set {
				const string __id = "setOnCanceledHandler.(Lkotlin/jvm/functions/Function0;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1? OnConnectionStateChangedHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getOnConnectionStateChangedHandler' and count(parameter)=0]"
			[Register ("getOnConnectionStateChangedHandler", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getOnConnectionStateChangedHandler.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='setOnConnectionStateChangedHandler' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super java.lang.String, kotlin.Unit&gt;']]"
			[Register ("setOnConnectionStateChangedHandler", "(Lkotlin/jvm/functions/Function1;)V", "")]
			set {
				const string __id = "setOnConnectionStateChangedHandler.(Lkotlin/jvm/functions/Function1;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe string PreferredEncodingId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getPreferredEncodingId' and count(parameter)=0]"
			[Register ("getPreferredEncodingId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPreferredEncodingId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Room.RoomPublication Publication {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getPublication' and count(parameter)=0]"
			[Register ("getPublication", "()Lcom/ntt/skyway/room/RoomPublication;", "")]
			get {
				const string __id = "getPublication.()Lcom/ntt/skyway/room/RoomPublication;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.RoomPublication> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Room.Room Room {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getRoom' and count(parameter)=0]"
			[Register ("getRoom", "()Lcom/ntt/skyway/room/Room;", "")]
			get {
				const string __id = "getRoom.()Lcom/ntt/skyway/room/Room;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.Room> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.ISubscription.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/Subscription$State;", "")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/Subscription$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.ISubscription.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.WebRTCStats? Stats {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getStats' and count(parameter)=0]"
			[Register ("getStats", "()Lcom/ntt/skyway/core/content/WebRTCStats;", "")]
			get {
				const string __id = "getStats.()Lcom/ntt/skyway/core/content/WebRTCStats;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.WebRTCStats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream? Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/ntt/skyway/core/content/remote/RemoteStream;", "")]
			get {
				const string __id = "getStream.()Lcom/ntt/skyway/core/content/remote/RemoteStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Remote.RemoteStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Room.Member.RoomMember? Subscriber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='getSubscriber' and count(parameter)=0]"
			[Register ("getSubscriber", "()Lcom/ntt/skyway/room/member/RoomMember;", "")]
			get {
				const string __id = "getSubscriber.()Lcom/ntt/skyway/room/member/RoomMember;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Room.Member.RoomMember> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("cancel", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? Cancel (global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "cancel.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (_completion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.room']/class[@name='RoomSubscription']/method[@name='changePreferredEncoding' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("changePreferredEncoding", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object? ChangePreferredEncoding (string preferredEncodingId, global::Kotlin.Coroutines.IContinuation _completion)
		{
			const string __id = "changePreferredEncoding.(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
			IntPtr native_preferredEncodingId = JNIEnv.NewString ((string?)preferredEncodingId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_preferredEncodingId);
				__args [1] = new JniArgumentValue ((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _completion).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_preferredEncodingId);
				global::System.GC.KeepAlive (_completion);
			}
		}

	}
}
