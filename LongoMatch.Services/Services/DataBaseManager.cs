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
using System.Collections.Generic;
using System.IO;
using System.Linq;

using LongoMatch.Interfaces;

namespace LongoMatch.DB
{
	public class DataBaseManager: IDataBaseManager
	{
		string DBDir;
		const int SUPPORTED_MAJOR_VERSION = 2;
		
		public DataBaseManager (string DBDir)
		{
			this.DBDir = DBDir;
			FindDBS();
		}
		
		public void SetActiveByName (string name) {
			foreach (DataBase db in Databases) {
				if (db.Name == name) {
					Log.Information ("Selecting active database " + db.Name);
					ActiveDB = db;
					return;
				}
			}
			DataBase newdb = new DataBase(Path.Combine (DBDir, name));
			Log.Information ("Creating new database " + newdb.Name);
			Databases.Add (newdb);
			ActiveDB = newdb;
		}
		
		public IDatabase ActiveDB {
			get;
			set;
		}
		
		public List<IDatabase> Databases {
			get;
			set;
		}
		
		string Extension {
			get {
				return SUPPORTED_MAJOR_VERSION -1 + ".db";
			}
		}
		
		void FindDBS (){
			Databases = new List<IDatabase>();
			
			var paths = Directory.GetFiles(this.DBDir).Where
				(f => f.EndsWith(Extension)).ToList();
				
			foreach (string p in paths) {
				try {
					DataBase db = new DataBase (p);
					if (db.Version.Major == SUPPORTED_MAJOR_VERSION) {
						Log.Information ("Found new database " + db.Name);
						Databases.Add (db);
					}
				} catch (Exception ex) {
					Log.Exception (ex);
				}
			}
		}
	}
}

