﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FFTPatcher.Datatypes;
using PatcherLib.Utilities;
namespace FFTPatcher.Editors
{
    public partial class AllPropositionDetailsEditor : UserControl
    {
        private AllPropositions props;

        public AllPropositionDetailsEditor()
        {
            InitializeComponent();
        }

        public void UpdateView( AllPropositions props )
        {
            this.props = props;
            UpdateListBox();
            listBox1.SelectedIndex = 0;
            propositionEditor1.BindTo(
                props.Propositions[0],
                props.Prices,
                props.SmallBonuses,
                props.LargeBonuses );
        }

        private void UpdateListBox()
        {
            listBox1.BeginUpdate();
            int index = listBox1.SelectedIndex;
            listBox1.Items.Clear();
            props.Propositions.ForEach( p => listBox1.Items.Add( p ) );
            listBox1.SelectedIndex = index;
            listBox1.EndUpdate();
        }

        protected override void OnVisibleChanged( EventArgs e )
        {
            if (propositionEditor1 != null && props != null)
            {
                propositionEditor1.NotifyNewPrices( props.Prices, props.SmallBonuses, props.LargeBonuses );
            }
            base.OnVisibleChanged( e );
        }

        private void listBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            if (listBox1.SelectedIndex != -1)
            {
                propositionEditor1.BindTo( props.Propositions[listBox1.SelectedIndex], props.Prices, props.SmallBonuses, props.LargeBonuses );
            }
        }

    }
}