// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Dialog {


	public partial class TemplatesManager {

		private Gtk.HPaned hpaned1;

		private Gtk.VBox vbox2;

		private Gtk.TreeView treeview;

		private Gtk.HBox hbox2;

		private Gtk.Button newbutton;

		private Gtk.Button deletebutton;

		private Gtk.Button savebutton;

		private Gtk.HBox hbox1;

		private LongoMatch.Gui.Component.ProjectTemplateWidget sectionspropertieswidget1;

		private LongoMatch.Gui.Component.TeamTemplateWidget teamtemplatewidget1;

		private Gtk.Button buttonOk;

		protected virtual void Build() {
			Stetic.Gui.Initialize(this);
			// Widget LongoMatch.Gui.Dialog.TemplatesManager
			this.Name = "LongoMatch.Gui.Dialog.TemplatesManager";
			this.Title = Mono.Unix.Catalog.GetString("Templates Manager");
			this.Icon = Stetic.IconLoader.LoadIcon(this, "longomatch", Gtk.IconSize.Dialog, 48);
			this.WindowPosition = ((Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			this.HasSeparator = false;
			// Internal child LongoMatch.Gui.Dialog.TemplatesManager.VBox
			Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hpaned1 = new Gtk.HPaned();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 144;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox2 = new Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.treeview = new Gtk.TreeView();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			this.vbox2.Add(this.treeview);
			Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.treeview]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			// Container child hbox2.Gtk.Box+BoxChild
			this.newbutton = new Gtk.Button();
			this.newbutton.TooltipMarkup = "Create a new template";
			this.newbutton.CanFocus = true;
			this.newbutton.Name = "newbutton";
			this.newbutton.UseUnderline = true;
			// Container child newbutton.Gtk.Container+ContainerChild
			Gtk.Alignment w3 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			Gtk.HBox w4 = new Gtk.HBox();
			w4.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			Gtk.Image w5 = new Gtk.Image();
			w5.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-new", Gtk.IconSize.Button, 20);
			w4.Add(w5);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			Gtk.Label w7 = new Gtk.Label();
			w4.Add(w7);
			w3.Add(w4);
			this.newbutton.Add(w3);
			this.hbox2.Add(this.newbutton);
			Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.newbutton]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.deletebutton = new Gtk.Button();
			this.deletebutton.TooltipMarkup = "Delete this template";
			this.deletebutton.Sensitive = false;
			this.deletebutton.CanFocus = true;
			this.deletebutton.Name = "deletebutton";
			this.deletebutton.UseUnderline = true;
			// Container child deletebutton.Gtk.Container+ContainerChild
			Gtk.Alignment w12 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			Gtk.HBox w13 = new Gtk.HBox();
			w13.Spacing = 2;
			// Container child GtkHBox1.Gtk.Container+ContainerChild
			Gtk.Image w14 = new Gtk.Image();
			w14.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-delete", Gtk.IconSize.Button, 20);
			w13.Add(w14);
			// Container child GtkHBox1.Gtk.Container+ContainerChild
			Gtk.Label w16 = new Gtk.Label();
			w13.Add(w16);
			w12.Add(w13);
			this.deletebutton.Add(w12);
			this.hbox2.Add(this.deletebutton);
			Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox2[this.deletebutton]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.savebutton = new Gtk.Button();
			this.savebutton.TooltipMarkup = "Save this template";
			this.savebutton.Sensitive = false;
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseUnderline = true;
			// Container child savebutton.Gtk.Container+ContainerChild
			Gtk.Alignment w21 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			Gtk.HBox w22 = new Gtk.HBox();
			w22.Spacing = 2;
			// Container child GtkHBox2.Gtk.Container+ContainerChild
			Gtk.Image w23 = new Gtk.Image();
			w23.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-save", Gtk.IconSize.Button, 20);
			w22.Add(w23);
			// Container child GtkHBox2.Gtk.Container+ContainerChild
			Gtk.Label w25 = new Gtk.Label();
			w22.Add(w25);
			w21.Add(w22);
			this.savebutton.Add(w21);
			this.hbox2.Add(this.savebutton);
			Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.hbox2[this.savebutton]));
			w29.Position = 2;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox2.Add(this.hbox2);
			Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.hpaned1.Add(this.vbox2);
			Gtk.Paned.PanedChild w31 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox2]));
			w31.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.hbox1 = new Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.sectionspropertieswidget1 = new LongoMatch.Gui.Component.ProjectTemplateWidget();
			this.sectionspropertieswidget1.Sensitive = false;
			this.sectionspropertieswidget1.Events = ((Gdk.EventMask)(256));
			this.sectionspropertieswidget1.Name = "sectionspropertieswidget1";
			this.sectionspropertieswidget1.Edited = false;
			this.hbox1.Add(this.sectionspropertieswidget1);
			Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.hbox1[this.sectionspropertieswidget1]));
			w32.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.teamtemplatewidget1 = new LongoMatch.Gui.Component.TeamTemplateWidget();
			this.teamtemplatewidget1.Sensitive = false;
			this.teamtemplatewidget1.Events = ((Gdk.EventMask)(256));
			this.teamtemplatewidget1.Name = "teamtemplatewidget1";
			this.teamtemplatewidget1.Edited = false;
			this.hbox1.Add(this.teamtemplatewidget1);
			Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(this.hbox1[this.teamtemplatewidget1]));
			w33.Position = 1;
			this.hpaned1.Add(this.hbox1);
			w1.Add(this.hpaned1);
			Gtk.Box.BoxChild w35 = ((Gtk.Box.BoxChild)(w1[this.hpaned1]));
			w35.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.TemplatesManager.ActionArea
			Gtk.HButtonBox w36 = this.ActionArea;
			w36.Name = "dialog1_ActionArea";
			w36.Spacing = 6;
			w36.BorderWidth = ((uint)(5));
			w36.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-quit";
			this.AddActionWidget(this.buttonOk, 0);
			Gtk.ButtonBox.ButtonBoxChild w37 = ((Gtk.ButtonBox.ButtonBoxChild)(w36[this.buttonOk]));
			w37.Expand = false;
			w37.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.DefaultWidth = 483;
			this.DefaultHeight = 336;
			this.sectionspropertieswidget1.Hide();
			this.teamtemplatewidget1.Hide();
			this.Show();
			this.treeview.RowActivated += new Gtk.RowActivatedHandler(this.OnTreeviewRowActivated);
			this.treeview.CursorChanged += new System.EventHandler(this.OnTreeviewCursorChanged);
			this.newbutton.Clicked += new System.EventHandler(this.OnNewbuttonClicked);
			this.deletebutton.Clicked += new System.EventHandler(this.OnDeletebuttonClicked);
			this.savebutton.Clicked += new System.EventHandler(this.OnSavebuttonClicked);
			this.buttonOk.Clicked += new System.EventHandler(this.OnButtonOkClicked);
		}
	}
}
