package mono.org.webrtc.audio;


public class WebRtcAudioRecord_OnAudioBufferListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.webrtc.audio.WebRtcAudioRecord.OnAudioBufferListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAudioBuffer:(Ljava/nio/ByteBuffer;)V:GetOnAudioBuffer_Ljava_nio_ByteBuffer_Handler:Org.Webrtc.Audio.WebRtcAudioRecord/IOnAudioBufferListenerInvoker, skyway_room\n" +
			"";
		mono.android.Runtime.register ("Org.Webrtc.Audio.WebRtcAudioRecord+IOnAudioBufferListenerImplementor, skyway_room", WebRtcAudioRecord_OnAudioBufferListenerImplementor.class, __md_methods);
	}


	public WebRtcAudioRecord_OnAudioBufferListenerImplementor ()
	{
		super ();
		if (getClass () == WebRtcAudioRecord_OnAudioBufferListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Org.Webrtc.Audio.WebRtcAudioRecord+IOnAudioBufferListenerImplementor, skyway_room", "", this, new java.lang.Object[] {  });
		}
	}


	public void onAudioBuffer (java.nio.ByteBuffer p0)
	{
		n_onAudioBuffer (p0);
	}

	private native void n_onAudioBuffer (java.nio.ByteBuffer p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
