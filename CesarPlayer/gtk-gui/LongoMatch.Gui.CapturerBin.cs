// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui {
    
    
    public partial class CapturerBin {
        
        private Gtk.VBox vbox1;
        
        private Gtk.HBox capturerhbox;
        
        private Gtk.HBox buttonsbox;
        
        private Gtk.Button recbutton;
        
        private Gtk.Button pausebutton;
        
        private Gtk.Button stopbutton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.CapturerBin
            Stetic.BinContainer.Attach(this);
            this.Name = "LongoMatch.Gui.CapturerBin";
            // Container child LongoMatch.Gui.CapturerBin.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.capturerhbox = new Gtk.HBox();
            this.capturerhbox.Name = "capturerhbox";
            this.capturerhbox.Spacing = 6;
            this.vbox1.Add(this.capturerhbox);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.capturerhbox]));
            w1.Position = 0;
            // Container child vbox1.Gtk.Box+BoxChild
            this.buttonsbox = new Gtk.HBox();
            this.buttonsbox.Name = "buttonsbox";
            this.buttonsbox.Spacing = 6;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.recbutton = new Gtk.Button();
            this.recbutton.CanFocus = true;
            this.recbutton.Name = "recbutton";
            this.recbutton.UseUnderline = true;
            // Container child recbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w2 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w3 = new Gtk.HBox();
            w3.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w4 = new Gtk.Image();
            w4.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-record", Gtk.IconSize.Button, 20);
            w3.Add(w4);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w6 = new Gtk.Label();
            w3.Add(w6);
            w2.Add(w3);
            this.recbutton.Add(w2);
            this.buttonsbox.Add(this.recbutton);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.recbutton]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.pausebutton = new Gtk.Button();
            this.pausebutton.CanFocus = true;
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.UseUnderline = true;
            // Container child pausebutton.Gtk.Container+ContainerChild
            Gtk.Alignment w11 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w12 = new Gtk.HBox();
            w12.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w13 = new Gtk.Image();
            w13.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-pause", Gtk.IconSize.Button, 20);
            w12.Add(w13);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w15 = new Gtk.Label();
            w12.Add(w15);
            w11.Add(w12);
            this.pausebutton.Add(w11);
            this.buttonsbox.Add(this.pausebutton);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.pausebutton]));
            w19.Position = 1;
            w19.Expand = false;
            w19.Fill = false;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.stopbutton = new Gtk.Button();
            this.stopbutton.CanFocus = true;
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.UseUnderline = true;
            // Container child stopbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w20 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w21 = new Gtk.HBox();
            w21.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w22 = new Gtk.Image();
            w22.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-stop", Gtk.IconSize.Menu, 16);
            w21.Add(w22);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w24 = new Gtk.Label();
            w21.Add(w24);
            w20.Add(w21);
            this.stopbutton.Add(w20);
            this.buttonsbox.Add(this.stopbutton);
            Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.stopbutton]));
            w28.Position = 2;
            w28.Expand = false;
            w28.Fill = false;
            this.vbox1.Add(this.buttonsbox);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.vbox1[this.buttonsbox]));
            w29.Position = 1;
            w29.Expand = false;
            w29.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.recbutton.Clicked += new System.EventHandler(this.OnRecbuttonClicked);
            this.pausebutton.Clicked += new System.EventHandler(this.OnPausebuttonClicked);
            this.stopbutton.Clicked += new System.EventHandler(this.OnStopbuttonClicked);
        }
    }
}