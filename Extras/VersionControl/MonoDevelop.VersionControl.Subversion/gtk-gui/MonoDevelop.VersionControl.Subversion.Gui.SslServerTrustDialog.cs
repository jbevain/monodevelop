// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.VersionControl.Subversion.Gui {
    
    
    public partial class SslServerTrustDialog {
        
        private Gtk.HBox hbox1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Image image1;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label label2;
        
        private Gtk.Label labelReason;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.Table table1;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.Label label8;
        
        private Gtk.Label labelFprint;
        
        private Gtk.Label labelFrom;
        
        private Gtk.Label labelHost;
        
        private Gtk.Label labelIssuer;
        
        private Gtk.Label labelRealm;
        
        private Gtk.Label labelUntil;
        
        private Gtk.HSeparator hseparator1;
        
        private Gtk.Label label15;
        
        private Gtk.RadioButton radioAccept;
        
        private Gtk.RadioButton radioAcceptSession;
        
        private Gtk.RadioButton radioNotAccept;
        
        private Gtk.Button button98;
        
        private Gtk.Button button104;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.VersionControl.Subversion.Gui.SslServerTrustDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.VersionControl.Subversion.Gui.SslServerTrustDialog";
            this.Title = Mono.Unix.Catalog.GetString("Repository Certified by an Unknown Authority");
            this.Modal = true;
            // Internal child MonoDevelop.VersionControl.Subversion.Gui.SslServerTrustDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            this.hbox1.BorderWidth = ((uint)(6));
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            // Container child vbox2.Gtk.Box+BoxChild
            this.image1 = new Gtk.Image();
            this.image1.Name = "image1";
            this.image1.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-warning", Gtk.IconSize.Dialog, 48);
            this.vbox2.Add(this.image1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.image1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            this.hbox1.Add(this.vbox2);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            this.vbox3.BorderWidth = ((uint)(12));
            // Container child vbox3.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Unable to verify the identity of host as a trusted site.");
            this.vbox3.Add(this.label2);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox3[this.label2]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.labelReason = new Gtk.Label();
            this.labelReason.Name = "labelReason";
            this.labelReason.Xalign = 0F;
            this.labelReason.LabelProp = "<b>Reason</b>";
            this.labelReason.UseMarkup = true;
            this.vbox3.Add(this.labelReason);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.labelReason]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox3.Add(this.hseparator2);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox3[this.hseparator2]));
            w6.Position = 2;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(6)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("<b>Host name</b>:");
            this.label3.UseMarkup = true;
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("<b>Issued by:</b>");
            this.label4.UseMarkup = true;
            this.table1.Add(this.label4);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.label4]));
            w8.TopAttach = ((uint)(2));
            w8.BottomAttach = ((uint)(3));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("<b>Issued on:</b>");
            this.label5.UseMarkup = true;
            this.table1.Add(this.label5);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.label5]));
            w9.TopAttach = ((uint)(3));
            w9.BottomAttach = ((uint)(4));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("<b>Expires on:</b>");
            this.label6.UseMarkup = true;
            this.table1.Add(this.label6);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table1[this.label6]));
            w10.TopAttach = ((uint)(4));
            w10.BottomAttach = ((uint)(5));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("<b>Fingerprint:</b>");
            this.label7.UseMarkup = true;
            this.table1.Add(this.label7);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.label7]));
            w11.TopAttach = ((uint)(5));
            w11.BottomAttach = ((uint)(6));
            w11.XOptions = ((Gtk.AttachOptions)(4));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("<b>Auth. Realm:</b>");
            this.label8.UseMarkup = true;
            this.table1.Add(this.label8);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table1[this.label8]));
            w12.XOptions = ((Gtk.AttachOptions)(4));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelFprint = new Gtk.Label();
            this.labelFprint.Name = "labelFprint";
            this.labelFprint.Xalign = 0F;
            this.labelFprint.LabelProp = "label14";
            this.table1.Add(this.labelFprint);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table1[this.labelFprint]));
            w13.TopAttach = ((uint)(5));
            w13.BottomAttach = ((uint)(6));
            w13.LeftAttach = ((uint)(1));
            w13.RightAttach = ((uint)(2));
            w13.XOptions = ((Gtk.AttachOptions)(4));
            w13.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelFrom = new Gtk.Label();
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Xalign = 0F;
            this.labelFrom.LabelProp = "label12";
            this.table1.Add(this.labelFrom);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table1[this.labelFrom]));
            w14.TopAttach = ((uint)(3));
            w14.BottomAttach = ((uint)(4));
            w14.LeftAttach = ((uint)(1));
            w14.RightAttach = ((uint)(2));
            w14.XOptions = ((Gtk.AttachOptions)(4));
            w14.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelHost = new Gtk.Label();
            this.labelHost.Name = "labelHost";
            this.labelHost.Xalign = 0F;
            this.labelHost.LabelProp = "label10";
            this.table1.Add(this.labelHost);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table1[this.labelHost]));
            w15.TopAttach = ((uint)(1));
            w15.BottomAttach = ((uint)(2));
            w15.LeftAttach = ((uint)(1));
            w15.RightAttach = ((uint)(2));
            w15.XOptions = ((Gtk.AttachOptions)(4));
            w15.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelIssuer = new Gtk.Label();
            this.labelIssuer.Name = "labelIssuer";
            this.labelIssuer.Xalign = 0F;
            this.labelIssuer.LabelProp = "label11";
            this.table1.Add(this.labelIssuer);
            Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table1[this.labelIssuer]));
            w16.TopAttach = ((uint)(2));
            w16.BottomAttach = ((uint)(3));
            w16.LeftAttach = ((uint)(1));
            w16.RightAttach = ((uint)(2));
            w16.XOptions = ((Gtk.AttachOptions)(4));
            w16.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelRealm = new Gtk.Label();
            this.labelRealm.Name = "labelRealm";
            this.labelRealm.Xalign = 0F;
            this.labelRealm.LabelProp = "label9";
            this.table1.Add(this.labelRealm);
            Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.table1[this.labelRealm]));
            w17.LeftAttach = ((uint)(1));
            w17.RightAttach = ((uint)(2));
            w17.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.labelUntil = new Gtk.Label();
            this.labelUntil.Name = "labelUntil";
            this.labelUntil.Xalign = 0F;
            this.labelUntil.LabelProp = "label13";
            this.table1.Add(this.labelUntil);
            Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.table1[this.labelUntil]));
            w18.TopAttach = ((uint)(4));
            w18.BottomAttach = ((uint)(5));
            w18.LeftAttach = ((uint)(1));
            w18.RightAttach = ((uint)(2));
            w18.XOptions = ((Gtk.AttachOptions)(4));
            w18.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox3.Add(this.table1);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox3[this.table1]));
            w19.Position = 3;
            w19.Expand = false;
            w19.Fill = false;
            w19.Padding = ((uint)(6));
            // Container child vbox3.Gtk.Box+BoxChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.vbox3.Add(this.hseparator1);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox3[this.hseparator1]));
            w20.Position = 4;
            w20.Expand = false;
            w20.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.label15 = new Gtk.Label();
            this.label15.Name = "label15";
            this.label15.Xalign = 0F;
            this.label15.LabelProp = Mono.Unix.Catalog.GetString("Do you want to accept the certificate and connect to the repository?");
            this.vbox3.Add(this.label15);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox3[this.label15]));
            w21.Position = 5;
            w21.Expand = false;
            w21.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.radioAccept = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Accept this certificate permanently"));
            this.radioAccept.CanFocus = true;
            this.radioAccept.Name = "radioAccept";
            this.radioAccept.Active = true;
            this.radioAccept.DrawIndicator = true;
            this.radioAccept.UseUnderline = true;
            this.radioAccept.Group = new GLib.SList(System.IntPtr.Zero);
            this.vbox3.Add(this.radioAccept);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox3[this.radioAccept]));
            w22.Position = 6;
            w22.Expand = false;
            w22.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.radioAcceptSession = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Accept this certificate temporarily for this session"));
            this.radioAcceptSession.CanFocus = true;
            this.radioAcceptSession.Name = "radioAcceptSession";
            this.radioAcceptSession.DrawIndicator = true;
            this.radioAcceptSession.UseUnderline = true;
            this.radioAcceptSession.Group = this.radioAccept.Group;
            this.vbox3.Add(this.radioAcceptSession);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.vbox3[this.radioAcceptSession]));
            w23.Position = 7;
            w23.Expand = false;
            w23.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.radioNotAccept = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Do not accept this certificate and do not connect to this repository"));
            this.radioNotAccept.CanFocus = true;
            this.radioNotAccept.Name = "radioNotAccept";
            this.radioNotAccept.DrawIndicator = true;
            this.radioNotAccept.UseUnderline = true;
            this.radioNotAccept.Group = this.radioAccept.Group;
            this.vbox3.Add(this.radioNotAccept);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox3[this.radioNotAccept]));
            w24.Position = 8;
            w24.Expand = false;
            w24.Fill = false;
            this.hbox1.Add(this.vbox3);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
            w25.Position = 1;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w26.Position = 0;
            // Internal child MonoDevelop.VersionControl.Subversion.Gui.SslServerTrustDialog.ActionArea
            Gtk.HButtonBox w27 = this.ActionArea;
            w27.Events = ((Gdk.EventMask)(256));
            w27.Name = "MonoDevelop.VersionControl.Subversion.SslServerTrustDialog_ActionArea";
            w27.Spacing = 10;
            w27.BorderWidth = ((uint)(5));
            w27.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child MonoDevelop.VersionControl.Subversion.SslServerTrustDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button98 = new Gtk.Button();
            this.button98.CanDefault = true;
            this.button98.CanFocus = true;
            this.button98.Name = "button98";
            this.button98.UseStock = true;
            this.button98.UseUnderline = true;
            this.button98.Label = "gtk-cancel";
            this.AddActionWidget(this.button98, -6);
            Gtk.ButtonBox.ButtonBoxChild w28 = ((Gtk.ButtonBox.ButtonBoxChild)(w27[this.button98]));
            w28.Expand = false;
            w28.Fill = false;
            // Container child MonoDevelop.VersionControl.Subversion.SslServerTrustDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button104 = new Gtk.Button();
            this.button104.CanDefault = true;
            this.button104.CanFocus = true;
            this.button104.Name = "button104";
            this.button104.UseStock = true;
            this.button104.UseUnderline = true;
            this.button104.Label = "gtk-ok";
            this.AddActionWidget(this.button104, -5);
            Gtk.ButtonBox.ButtonBoxChild w29 = ((Gtk.ButtonBox.ButtonBoxChild)(w27[this.button104]));
            w29.Position = 1;
            w29.Expand = false;
            w29.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 508;
            this.DefaultHeight = 415;
            this.Show();
        }
    }
}
