// 
//  Copyright (C) 2011 Andoni Morales Alastruey
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
using System.IO;

using LongoMatch.Common;

namespace LongoMatch
{
	public class Config
	{
		public static string homeDirectory;
		public static string baseDirectory;
		public static string configDirectory;
		static ConfigState state;
		
		public static void Load () {
			state = ConfigState.Load<ConfigState>(Config.ConfigFile, SerializableObject.SerializationType.Xml);
		}
		
		public static void Save () {
			ConfigState.Save(state, Config.ConfigFile, SerializableObject.SerializationType.Xml); 
		}
		
		public static string ConfigFile {
			get {
				string filename = Constants.SOFTWARE_NAME.ToLower() + ".config";
				return Path.Combine(Config.ConfigDir, filename);
			}
		}
		
		public static string HomeDir {
			get {
				return homeDirectory;
			}
		}

		public static string BaseDir {
			set {
				baseDirectory = value;
			}
		}
		
		public static string ConfigDir {
			set {
				configDirectory = value;
			}
			get {
				return configDirectory;
			}
		}
		
		public static string PlayListDir {
			get {
				return Path.Combine(homeDirectory, "playlists");
			}
		}

		public static string SnapshotsDir {
			get {
				return Path.Combine(homeDirectory, "snapshots");
			}
		}

		public static string TemplatesDir {
			get {
				return Path.Combine(homeDirectory, "templates");
			}
		}

		public static string VideosDir {
			get {
				return Path.Combine(homeDirectory, "videos");
			}
		}

		public static string TempVideosDir {
			get {
				return Path.Combine(configDirectory, "temp");
			}
		}

		public static string ImagesDir {
			get {
				return RelativeToPrefix(String.Format("share/{0}/images",
				                                      Constants.SOFTWARE_NAME.ToLower()));
			}
		}
		
		public static string PluginsDir {
			get {
				return RelativeToPrefix(String.Format("lib/{0}/plugins",
				                                      Constants.SOFTWARE_NAME.ToLower()));
			}
		}
		
		public static string PluginsConfigDir {
			get {
				return Path.Combine(configDirectory, "addins");
			}
		}

		public static string DBDir {
			get {
				return Path.Combine(configDirectory, "db");
			}
		}
		
		public static string RelativeToPrefix(string relativePath) {
			return Path.Combine(baseDirectory, relativePath);
		}
		
		#region Properties
		public bool FastTagging {
			get {
				return state.fastTagging;
			}
			set {
				state.fastTagging = true;
			}
		}
		
		public bool UseGameUnits {
			get {
				return state.useGameUnits;
			}
			set {
				state.useGameUnits = value;
			}
		}
		
		public string CurrentDatabase {
			get {
				return state.currentDatabase;
			}
			set {
				state.currentDatabase = value;
			}
		}
		#endregion

	}
	
	class ConfigState: SerializableObject
	{
		public bool fastTagging=false;
		public string currentDatabase=Constants.DEFAULT_DB_FILE;
		public bool useGameUnits=false;
	}
}

