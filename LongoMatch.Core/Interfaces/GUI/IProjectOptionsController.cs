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
using LongoMatch.Handlers;

namespace LongoMatch.Interfaces.GUI
{
	public interface IProjectOptionsController
	{
		event SaveProjectHandler SaveProjectEvent;
		event CloseOpenendProjectHandler CloseOpenedProjectEvent;
		event ShowFullScreenHandler ShowFullScreenEvent;
		event PlaylistVisibiltyHandler PlaylistVisibilityEvent;
		event AnalysisWidgetsVisibilityHandler AnalysisWidgetsVisibilityEvent;
		event AnalysisModeChangedHandler AnalysisModeChangedEvent;
		event ShowProjectStats ShowProjectStatsEvent;
		event TagSubcategoriesChangedHandler TagSubcategoriesChangedEvent;
	}
}

