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
using System.Collections.Generic;
using System.Windows.Forms;
using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class RequirementsEditor : UserControl
    {
        private List<Requirements> requirements;
        public List<Requirements> Requirements
        {
            get { return requirements; }
            set
            {
                if( value == null )
                {
                    this.Enabled = false;
                    this.requirements = null;
                    dataGridView1.DataSource = null;
                }
                else if( value != requirements )
                {
                    OnionKnight.Visible = FFTPatch.Context == Context.US_PSP;
                    DarkKnight.Visible = FFTPatch.Context == Context.US_PSP;
                    Unknown1.Visible = FFTPatch.Context == Context.US_PSP;
                    Unknown2.Visible = FFTPatch.Context == Context.US_PSP;
                    this.Enabled = true;
                    this.requirements = value;
                    dataGridView1.DataSource = value;
                }
            }
        }


        public RequirementsEditor()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellParsing += dataGridView1_CellParsing;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
        }

        private void dataGridView1_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
        {
            int result;
            if( !Int32.TryParse( e.FormattedValue.ToString(), out result ) || (result < 0) || (result > 8) )
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellParsing( object sender, DataGridViewCellParsingEventArgs e )
        {
            int result;
            if( Int32.TryParse( e.Value.ToString(), out result ) )
            {
                if( result > 8 )
                    result = 8;
                if( result < 0 )
                    result = 0;
                e.Value = result;

                e.ParsingApplied = true;
            }
        }
    }
}