using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Local.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/source/VideoSource", DoNotGenerateAcw=true)]
	public abstract partial class VideoSource : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/source/VideoSource", typeof (VideoSource));

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

		protected VideoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']/constructor[@name='VideoSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoSource () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		protected unsafe global::Org.Webrtc.VideoSource Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lorg/webrtc/VideoSource;", "")]
			get {
				const string __id = "getSource.()Lorg/webrtc/VideoSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoSource']]"
			[Register ("setSource", "(Lorg/webrtc/VideoSource;)V", "")]
			set {
				const string __id = "setSource.(Lorg/webrtc/VideoSource;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		protected unsafe global::Org.Webrtc.SurfaceTextureHelper TextureHelper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']/method[@name='getTextureHelper' and count(parameter)=0]"
			[Register ("getTextureHelper", "()Lorg/webrtc/SurfaceTextureHelper;", "")]
			get {
				const string __id = "getTextureHelper.()Lorg/webrtc/SurfaceTextureHelper;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']/method[@name='setTextureHelper' and count(parameter)=1 and parameter[1][@type='org.webrtc.SurfaceTextureHelper']]"
			[Register ("setTextureHelper", "(Lorg/webrtc/SurfaceTextureHelper;)V", "")]
			set {
				const string __id = "setTextureHelper.(Lorg/webrtc/SurfaceTextureHelper;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		protected unsafe global::Org.Webrtc.YuvConverter YuvConverter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']/method[@name='getYuvConverter' and count(parameter)=0]"
			[Register ("getYuvConverter", "()Lorg/webrtc/YuvConverter;", "")]
			get {
				const string __id = "getYuvConverter.()Lorg/webrtc/YuvConverter;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.YuvConverter> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.local.source']/class[@name='VideoSource']/method[@name='createStream' and count(parameter)=0]"
		[Register ("createStream", "()Lcom/ntt/skyway/core/content/local/LocalVideoStream;", "")]
		public unsafe global::Com.Ntt.Skyway.Core.Content.Local.LocalVideoStream CreateStream ()
		{
			const string __id = "createStream.()Lcom/ntt/skyway/core/content/local/LocalVideoStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.LocalVideoStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/local/source/VideoSource", DoNotGenerateAcw=true)]
	internal partial class VideoSourceInvoker : VideoSource {
		public VideoSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/local/source/VideoSource", typeof (VideoSourceInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
