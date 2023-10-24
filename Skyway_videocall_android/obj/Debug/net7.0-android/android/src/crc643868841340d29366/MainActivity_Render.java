package crc643868841340d29366;


public class MainActivity_Render
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.ntt.skyway.core.content.sink.Renderer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isSetup:()Z:GetIsSetupHandler:Com.Ntt.Skyway.Core.Content.Sink.IRendererInvoker, skyway_core\n" +
			"n_setSetup:(Z)V:GetSetSetup_ZHandler:Com.Ntt.Skyway.Core.Content.Sink.IRendererInvoker, skyway_core\n" +
			"n_dispose:()V:GetDisposeHandler:Com.Ntt.Skyway.Core.Content.Sink.IRendererInvoker, skyway_core\n" +
			"";
		mono.android.Runtime.register ("Skyway_videocall_android.MainActivity+Render, Skyway_videocall_android", MainActivity_Render.class, __md_methods);
	}


	public MainActivity_Render ()
	{
		super ();
		if (getClass () == MainActivity_Render.class) {
			mono.android.TypeManager.Activate ("Skyway_videocall_android.MainActivity+Render, Skyway_videocall_android", "", this, new java.lang.Object[] {  });
		}
	}


	public boolean isSetup ()
	{
		return n_isSetup ();
	}

	private native boolean n_isSetup ();


	public void setSetup (boolean p0)
	{
		n_setSetup (p0);
	}

	private native void n_setSetup (boolean p0);


	public void dispose ()
	{
		n_dispose ();
	}

	private native void n_dispose ();

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
