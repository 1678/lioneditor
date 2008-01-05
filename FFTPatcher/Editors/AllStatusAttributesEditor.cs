﻿/*
    Copyright 2007, Joe Davidson <joedavidson@gmail.com>

    This file is part of FFTPatcher.

    LionEditor is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LionEditor is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with LionEditor.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Forms;
using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class AllStatusAttributesEditor : UserControl
    {
        public AllStatusAttributesEditor()
        {
            InitializeComponent();
        }

        public void UpdateView( AllStatusAttributes attributes )
        {
            listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
            listBox.Items.Clear();
            listBox.Items.AddRange( attributes.StatusAttributes );
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBox.SelectedIndex = 0;
            statusAttributeEditor.StatusAttribute = listBox.SelectedItem as StatusAttribute;
        }

        private void listBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            StatusAttribute a = listBox.SelectedItem as StatusAttribute;
            statusAttributeEditor.StatusAttribute = a;
        }
    }
}