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


	public partial class Win32CalendarDialog {

		private Gtk.Calendar calendar1;

		private Gtk.Button buttonOk;

		protected virtual void Build() {
			Stetic.Gui.Initialize(this);
			// Widget LongoMatch.Gui.Dialog.Win32CalendarDialog
			this.Name = "LongoMatch.Gui.Dialog.Win32CalendarDialog";
			this.Title = Mono.Unix.Catalog.GetString("Calendar");
			this.Icon = Stetic.IconLoader.LoadIcon(this, "longomatch", Gtk.IconSize.Menu, 16);
			this.WindowPosition = ((Gtk.WindowPosition)(4));
			this.Gravity = ((Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			this.HasSeparator = false;
			// Internal child LongoMatch.Gui.Dialog.Win32CalendarDialog.VBox
			Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.calendar1 = new Gtk.Calendar();
			this.calendar1.CanFocus = true;
			this.calendar1.Name = "calendar1";
			this.calendar1.DisplayOptions = ((Gtk.CalendarDisplayOptions)(35));
			w1.Add(this.calendar1);
			Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(w1[this.calendar1]));
			w2.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.Win32CalendarDialog.ActionArea
			Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 6;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			Gtk.ButtonBox.ButtonBoxChild w4 = ((Gtk.ButtonBox.ButtonBoxChild)(w3[this.buttonOk]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.DefaultWidth = 217;
			this.DefaultHeight = 204;
			this.Show();
			this.calendar1.DaySelectedDoubleClick += new System.EventHandler(this.OnCalendar1DaySelectedDoubleClick);
			this.calendar1.DaySelected += new System.EventHandler(this.OnCalendar1DaySelected);
		}
	}
}
