/*
    Copyright 2007, Joe Davidson <joedavidson@gmail.com>

    This file is part of FFTPatcher.

    FFTPatcher is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    FFTPatcher is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FFTPatcher.  If not, see <http://www.gnu.org/licenses/>.
*/

using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class MapMoveFindItemEditor : BaseEditor
    {
		#region Instance Variables (1) 

        private MapMoveFindItems mapMoveFindItems;

		#endregion Instance Variables 

		#region Public Properties (1) 

        public MapMoveFindItems MapMoveFindItems
        {
            get { return mapMoveFindItems; }
            set
            {
                if ( value == null )
                {
                    this.Enabled = false;
                    mapMoveFindItems = null;
                }
                else if ( mapMoveFindItems != value )
                {
                    mapMoveFindItems = value;
                    this.Enabled = true;
                    UpdateView();
                }
            }
        }

		#endregion Public Properties 

		#region Constructors (1) 

        public MapMoveFindItemEditor()
        {
            InitializeComponent();
            moveFindItemEditor1.DataChanged += OnDataChanged;
            moveFindItemEditor2.DataChanged += OnDataChanged;
            moveFindItemEditor3.DataChanged += OnDataChanged;
            moveFindItemEditor4.DataChanged += OnDataChanged;
        }

		#endregion Constructors 

		#region Private Methods (1) 

        private void UpdateView()
        {
            moveFindItemEditor1.MoveFindItem = mapMoveFindItems.Items[0];
            moveFindItemEditor2.MoveFindItem = mapMoveFindItems.Items[1];
            moveFindItemEditor3.MoveFindItem = mapMoveFindItems.Items[2];
            moveFindItemEditor4.MoveFindItem = mapMoveFindItems.Items[3];
        }

		#endregion Private Methods 
    }
}
