// 
//  Copyright (C) 2013 Andoni Morales Alastruey
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//  
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
// 
using System;
using Gtk;
using LongoMatch.Interfaces;
using Mono.Unix;

namespace LongoMatch.Gui.Dialog
{
	public partial class DatabasesManager : Gtk.Dialog
	{
		IDataBaseManager manager;
		ListStore store;
			
		public DatabasesManager (IDataBaseManager manager)
		{
			this.Build ();
			this.manager = manager;
		}
		
		void SetTreeView () {
			/* DB name */
			TreeViewColumn nameCol = new TreeViewColumn();
			nameCol.Title = Catalog.GetString("Name");
			CellRendererText nameCell = new CellRendererText();
			nameCol.PackStart(nameCell, true);
			nameCol.SetCellDataFunc(nameCell, new TreeCellDataFunc(RenderName));
			treeview.AppendColumn(nameCol);
			
			/* DB last backup */
			TreeViewColumn lastbackupCol = new TreeViewColumn();
			lastbackupCol.Title = Catalog.GetString("Last backup");
			CellRendererText lastbackupCell = new CellRendererText();
			lastbackupCol.PackStart(lastbackupCell, true);
			lastbackupCol.SetCellDataFunc(lastbackupCell, new TreeCellDataFunc(RenderLastbackup));
			treeview.AppendColumn(lastbackupCol);
			
			/* DB Projects count */
			TreeViewColumn countCol = new TreeViewColumn();
			countCol.Title = Catalog.GetString("Projects count");
			CellRendererText countCell = new CellRendererText();
			countCol.PackStart(countCell, true);
			countCol.SetCellDataFunc(countCell, new TreeCellDataFunc(RenderCount));
			treeview.AppendColumn(countCol);
			store = new ListStore(typeof (IDatabase));
			foreach (IDatabase db in manager.Databases) {
				store.AppendValues(db);
			}
			treeview.Model = store;
		}

		void RenderCount (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			IDatabase db = (IDatabase) store.GetValue(iter, 0);

			(cell as Gtk.CellRendererText).Text = db.Count.ToString(); 
		}

		void RenderLastbackup (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			IDatabase db = (IDatabase) store.GetValue(iter, 0);

			(cell as Gtk.CellRendererText).Text = db.LastBackup.ToShortDateString(); 
		}

		void RenderName (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			IDatabase db = (IDatabase) store.GetValue(iter, 0);

			(cell as Gtk.CellRendererText).Text = db.Name; 
		}

		protected void OnSelectbuttonClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnAddbuttonClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnDelbuttonClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnBackupbuttonClicked (object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
	}
}

