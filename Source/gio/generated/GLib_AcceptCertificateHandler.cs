// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void AcceptCertificateHandler(object o, AcceptCertificateArgs args);

	public class AcceptCertificateArgs : GLib.SignalArgs {
		public GLib.TlsCertificate PeerCert{
			get {
				return (GLib.TlsCertificate) Args [0];
			}
		}

		public GLib.TlsCertificateFlags Errors{
			get {
				return (GLib.TlsCertificateFlags) Args [1];
			}
		}

	}
}