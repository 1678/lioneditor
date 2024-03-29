﻿/*
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

namespace FFTPatcher.Editors
{
    partial class FFTPatchEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.abilitiesPage = new System.Windows.Forms.TabPage();
            this.allAbilitiesEditor1 = new FFTPatcher.Editors.AllAbilitiesEditor();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.allItemsEditor1 = new FFTPatcher.Editors.AllItemsEditor();
            this.itemAttributesTabPage = new System.Windows.Forms.TabPage();
            this.allItemAttributesEditor1 = new FFTPatcher.Editors.AllItemAttributesEditor();
            this.jobsPage = new System.Windows.Forms.TabPage();
            this.allJobsEditor1 = new FFTPatcher.Editors.AllJobsEditor();
            this.jobLevelsTab = new System.Windows.Forms.TabPage();
            this.jobLevelsEditor1 = new FFTPatcher.Editors.JobLevelsEditor();
            this.skillSetsPage = new System.Windows.Forms.TabPage();
            this.allSkillSetsEditor1 = new FFTPatcher.Editors.AllSkillSetsEditor();
            this.monsterSkillsTab = new System.Windows.Forms.TabPage();
            this.allMonsterSkillsEditor1 = new FFTPatcher.Editors.AllMonsterSkillsEditor();
            this.actionMenusTabPage = new System.Windows.Forms.TabPage();
            this.allActionMenusEditor1 = new FFTPatcher.Editors.AllActionMenusEditor();
            this.statusEffectsTab = new System.Windows.Forms.TabPage();
            this.allStatusAttributesEditor1 = new FFTPatcher.Editors.AllStatusAttributesEditor();
            this.inflictStatusesTabPage = new System.Windows.Forms.TabPage();
            this.allInflictStatusesEditor1 = new FFTPatcher.Editors.AllInflictStatusesEditor();
            this.poachingTabPage = new System.Windows.Forms.TabPage();
            this.allPoachProbabilitiesEditor1 = new FFTPatcher.Editors.AllPoachProbabilitiesEditor();
            this.codesTab = new System.Windows.Forms.TabPage();
            this.codeCreator1 = new FFTPatcher.Editors.CodeCreator();
            this.entdTab = new System.Windows.Forms.TabPage();
            this.entdEditor1 = new FFTPatcher.Editors.ENTDEditor();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.allMoveFindItemsEditor1 = new FFTPatcher.Editors.AllMoveFindItemsEditor();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.allStoreInventoryEditor1 = new FFTPatcher.Editors.Items.AllStoreInventoryEditor();
            this.tabControl.SuspendLayout();
            this.abilitiesPage.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.itemAttributesTabPage.SuspendLayout();
            this.jobsPage.SuspendLayout();
            this.jobLevelsTab.SuspendLayout();
            this.skillSetsPage.SuspendLayout();
            this.monsterSkillsTab.SuspendLayout();
            this.actionMenusTabPage.SuspendLayout();
            this.statusEffectsTab.SuspendLayout();
            this.inflictStatusesTabPage.SuspendLayout();
            this.poachingTabPage.SuspendLayout();
            this.codesTab.SuspendLayout();
            this.entdTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add( this.abilitiesPage );
            this.tabControl.Controls.Add( this.itemsTabPage );
            this.tabControl.Controls.Add( this.itemAttributesTabPage );
            this.tabControl.Controls.Add( this.jobsPage );
            this.tabControl.Controls.Add( this.jobLevelsTab );
            this.tabControl.Controls.Add( this.skillSetsPage );
            this.tabControl.Controls.Add( this.monsterSkillsTab );
            this.tabControl.Controls.Add( this.actionMenusTabPage );
            this.tabControl.Controls.Add( this.statusEffectsTab );
            this.tabControl.Controls.Add( this.inflictStatusesTabPage );
            this.tabControl.Controls.Add( this.poachingTabPage );
            this.tabControl.Controls.Add( this.codesTab );
            this.tabControl.Controls.Add( this.entdTab );
            this.tabControl.Controls.Add( this.tabPage1 );
            this.tabControl.Controls.Add( this.inventoryTab );
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point( 0, 0 );
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size( 800, 741 );
            this.tabControl.TabIndex = 2;
            // 
            // abilitiesPage
            // 
            this.abilitiesPage.Controls.Add( this.allAbilitiesEditor1 );
            this.abilitiesPage.Location = new System.Drawing.Point( 4, 40 );
            this.abilitiesPage.Name = "abilitiesPage";
            this.abilitiesPage.Padding = new System.Windows.Forms.Padding( 3 );
            this.abilitiesPage.Size = new System.Drawing.Size( 792, 697 );
            this.abilitiesPage.TabIndex = 0;
            this.abilitiesPage.Text = "Abilities";
            this.abilitiesPage.UseVisualStyleBackColor = true;
            // 
            // allAbilitiesEditor1
            // 
            this.allAbilitiesEditor1.AutoSize = true;
            this.allAbilitiesEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allAbilitiesEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allAbilitiesEditor1.Name = "allAbilitiesEditor1";
            this.allAbilitiesEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.allAbilitiesEditor1.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add( this.allItemsEditor1 );
            this.itemsTabPage.Location = new System.Drawing.Point( 4, 40 );
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Size = new System.Drawing.Size( 792, 697 );
            this.itemsTabPage.TabIndex = 9;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // allItemsEditor1
            // 
            this.allItemsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allItemsEditor1.Location = new System.Drawing.Point( 0, 0 );
            this.allItemsEditor1.Name = "allItemsEditor1";
            this.allItemsEditor1.Size = new System.Drawing.Size( 792, 697 );
            this.allItemsEditor1.TabIndex = 0;
            // 
            // itemAttributesTabPage
            // 
            this.itemAttributesTabPage.Controls.Add( this.allItemAttributesEditor1 );
            this.itemAttributesTabPage.Location = new System.Drawing.Point( 4, 40 );
            this.itemAttributesTabPage.Name = "itemAttributesTabPage";
            this.itemAttributesTabPage.Size = new System.Drawing.Size( 792, 697 );
            this.itemAttributesTabPage.TabIndex = 11;
            this.itemAttributesTabPage.Text = "Item Attributes";
            this.itemAttributesTabPage.UseVisualStyleBackColor = true;
            // 
            // allItemAttributesEditor1
            // 
            this.allItemAttributesEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allItemAttributesEditor1.Location = new System.Drawing.Point( 0, 0 );
            this.allItemAttributesEditor1.Name = "allItemAttributesEditor1";
            this.allItemAttributesEditor1.SelectedIndex = -1;
            this.allItemAttributesEditor1.Size = new System.Drawing.Size( 792, 697 );
            this.allItemAttributesEditor1.TabIndex = 0;
            // 
            // jobsPage
            // 
            this.jobsPage.Controls.Add( this.allJobsEditor1 );
            this.jobsPage.Location = new System.Drawing.Point( 4, 40 );
            this.jobsPage.Name = "jobsPage";
            this.jobsPage.Padding = new System.Windows.Forms.Padding( 3 );
            this.jobsPage.Size = new System.Drawing.Size( 792, 697 );
            this.jobsPage.TabIndex = 1;
            this.jobsPage.Text = "Jobs";
            this.jobsPage.UseVisualStyleBackColor = true;
            // 
            // allJobsEditor1
            // 
            this.allJobsEditor1.AutoScroll = true;
            this.allJobsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allJobsEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allJobsEditor1.Name = "allJobsEditor1";
            this.allJobsEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.allJobsEditor1.TabIndex = 0;
            // 
            // jobLevelsTab
            // 
            this.jobLevelsTab.Controls.Add( this.jobLevelsEditor1 );
            this.jobLevelsTab.Location = new System.Drawing.Point( 4, 40 );
            this.jobLevelsTab.Name = "jobLevelsTab";
            this.jobLevelsTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.jobLevelsTab.Size = new System.Drawing.Size( 792, 697 );
            this.jobLevelsTab.TabIndex = 8;
            this.jobLevelsTab.Text = "Job Levels";
            this.jobLevelsTab.UseVisualStyleBackColor = true;
            // 
            // jobLevelsEditor1
            // 
            this.jobLevelsEditor1.AutoScroll = true;
            this.jobLevelsEditor1.AutoSize = true;
            this.jobLevelsEditor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jobLevelsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobLevelsEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.jobLevelsEditor1.Name = "jobLevelsEditor1";
            this.jobLevelsEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.jobLevelsEditor1.TabIndex = 0;
            // 
            // skillSetsPage
            // 
            this.skillSetsPage.Controls.Add( this.allSkillSetsEditor1 );
            this.skillSetsPage.Location = new System.Drawing.Point( 4, 40 );
            this.skillSetsPage.Name = "skillSetsPage";
            this.skillSetsPage.Size = new System.Drawing.Size( 792, 697 );
            this.skillSetsPage.TabIndex = 2;
            this.skillSetsPage.Text = "Skill Sets";
            this.skillSetsPage.UseVisualStyleBackColor = true;
            // 
            // allSkillSetsEditor1
            // 
            this.allSkillSetsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSkillSetsEditor1.Location = new System.Drawing.Point( 0, 0 );
            this.allSkillSetsEditor1.Name = "allSkillSetsEditor1";
            this.allSkillSetsEditor1.SelectedIndex = -1;
            this.allSkillSetsEditor1.Size = new System.Drawing.Size( 792, 697 );
            this.allSkillSetsEditor1.TabIndex = 0;
            // 
            // monsterSkillsTab
            // 
            this.monsterSkillsTab.Controls.Add( this.allMonsterSkillsEditor1 );
            this.monsterSkillsTab.Location = new System.Drawing.Point( 4, 40 );
            this.monsterSkillsTab.Name = "monsterSkillsTab";
            this.monsterSkillsTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.monsterSkillsTab.Size = new System.Drawing.Size( 792, 697 );
            this.monsterSkillsTab.TabIndex = 4;
            this.monsterSkillsTab.Text = "Monster Skills";
            this.monsterSkillsTab.UseVisualStyleBackColor = true;
            // 
            // allMonsterSkillsEditor1
            // 
            this.allMonsterSkillsEditor1.AutoSize = true;
            this.allMonsterSkillsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allMonsterSkillsEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allMonsterSkillsEditor1.Name = "allMonsterSkillsEditor1";
            this.allMonsterSkillsEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.allMonsterSkillsEditor1.TabIndex = 0;
            // 
            // actionMenusTabPage
            // 
            this.actionMenusTabPage.Controls.Add( this.allActionMenusEditor1 );
            this.actionMenusTabPage.Location = new System.Drawing.Point( 4, 40 );
            this.actionMenusTabPage.Name = "actionMenusTabPage";
            this.actionMenusTabPage.Size = new System.Drawing.Size( 792, 697 );
            this.actionMenusTabPage.TabIndex = 5;
            this.actionMenusTabPage.Text = "Action Menus";
            this.actionMenusTabPage.UseVisualStyleBackColor = true;
            // 
            // allActionMenusEditor1
            // 
            this.allActionMenusEditor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.allActionMenusEditor1.Location = new System.Drawing.Point( 0, 0 );
            this.allActionMenusEditor1.Name = "allActionMenusEditor1";
            this.allActionMenusEditor1.Size = new System.Drawing.Size( 356, 697 );
            this.allActionMenusEditor1.TabIndex = 0;
            // 
            // statusEffectsTab
            // 
            this.statusEffectsTab.Controls.Add( this.allStatusAttributesEditor1 );
            this.statusEffectsTab.Location = new System.Drawing.Point( 4, 40 );
            this.statusEffectsTab.Name = "statusEffectsTab";
            this.statusEffectsTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.statusEffectsTab.Size = new System.Drawing.Size( 792, 697 );
            this.statusEffectsTab.TabIndex = 6;
            this.statusEffectsTab.Text = "Status Effects";
            this.statusEffectsTab.UseVisualStyleBackColor = true;
            // 
            // allStatusAttributesEditor1
            // 
            this.allStatusAttributesEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allStatusAttributesEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allStatusAttributesEditor1.Name = "allStatusAttributesEditor1";
            this.allStatusAttributesEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.allStatusAttributesEditor1.TabIndex = 0;
            // 
            // inflictStatusesTabPage
            // 
            this.inflictStatusesTabPage.Controls.Add( this.allInflictStatusesEditor1 );
            this.inflictStatusesTabPage.Location = new System.Drawing.Point( 4, 40 );
            this.inflictStatusesTabPage.Name = "inflictStatusesTabPage";
            this.inflictStatusesTabPage.Padding = new System.Windows.Forms.Padding( 3 );
            this.inflictStatusesTabPage.Size = new System.Drawing.Size( 792, 697 );
            this.inflictStatusesTabPage.TabIndex = 10;
            this.inflictStatusesTabPage.Text = "Inflict Statuses";
            this.inflictStatusesTabPage.UseVisualStyleBackColor = true;
            // 
            // allInflictStatusesEditor1
            // 
            this.allInflictStatusesEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allInflictStatusesEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allInflictStatusesEditor1.Name = "allInflictStatusesEditor1";
            this.allInflictStatusesEditor1.SelectedIndex = -1;
            this.allInflictStatusesEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.allInflictStatusesEditor1.TabIndex = 0;
            // 
            // poachingTabPage
            // 
            this.poachingTabPage.Controls.Add( this.allPoachProbabilitiesEditor1 );
            this.poachingTabPage.Location = new System.Drawing.Point( 4, 40 );
            this.poachingTabPage.Name = "poachingTabPage";
            this.poachingTabPage.Size = new System.Drawing.Size( 792, 697 );
            this.poachingTabPage.TabIndex = 7;
            this.poachingTabPage.Text = "Poaching";
            this.poachingTabPage.UseVisualStyleBackColor = true;
            // 
            // allPoachProbabilitiesEditor1
            // 
            this.allPoachProbabilitiesEditor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.allPoachProbabilitiesEditor1.Location = new System.Drawing.Point( 0, 0 );
            this.allPoachProbabilitiesEditor1.Name = "allPoachProbabilitiesEditor1";
            this.allPoachProbabilitiesEditor1.Size = new System.Drawing.Size( 350, 697 );
            this.allPoachProbabilitiesEditor1.TabIndex = 0;
            // 
            // codesTab
            // 
            this.codesTab.Controls.Add( this.codeCreator1 );
            this.codesTab.Location = new System.Drawing.Point( 4, 40 );
            this.codesTab.Name = "codesTab";
            this.codesTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.codesTab.Size = new System.Drawing.Size( 792, 697 );
            this.codesTab.TabIndex = 3;
            this.codesTab.Text = "CWCheat";
            this.codesTab.UseVisualStyleBackColor = true;
            // 
            // codeCreator1
            // 
            this.codeCreator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeCreator1.Location = new System.Drawing.Point( 3, 3 );
            this.codeCreator1.Name = "codeCreator1";
            this.codeCreator1.Size = new System.Drawing.Size( 786, 691 );
            this.codeCreator1.TabIndex = 0;
            // 
            // entdTab
            // 
            this.entdTab.Controls.Add( this.entdEditor1 );
            this.entdTab.Location = new System.Drawing.Point( 4, 40 );
            this.entdTab.Name = "entdTab";
            this.entdTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.entdTab.Size = new System.Drawing.Size( 792, 697 );
            this.entdTab.TabIndex = 12;
            this.entdTab.Text = "ENTD";
            this.entdTab.UseVisualStyleBackColor = true;
            // 
            // entdEditor1
            // 
            this.entdEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entdEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.entdEditor1.Name = "entdEditor1";
            this.entdEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.entdEditor1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add( this.allMoveFindItemsEditor1 );
            this.tabPage1.Location = new System.Drawing.Point( 4, 40 );
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage1.Size = new System.Drawing.Size( 792, 697 );
            this.tabPage1.TabIndex = 14;
            this.tabPage1.Text = "Move-Find Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // allMoveFindItemsEditor1
            // 
            this.allMoveFindItemsEditor1.AutoSize = true;
            this.allMoveFindItemsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allMoveFindItemsEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allMoveFindItemsEditor1.Name = "allMoveFindItemsEditor1";
            this.allMoveFindItemsEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.allMoveFindItemsEditor1.TabIndex = 0;
            // 
            // inventoryTab
            // 
            this.inventoryTab.BackColor = System.Drawing.SystemColors.Control;
            this.inventoryTab.Controls.Add( this.allStoreInventoryEditor1 );
            this.inventoryTab.Location = new System.Drawing.Point( 4, 40 );
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.inventoryTab.Size = new System.Drawing.Size( 792, 697 );
            this.inventoryTab.TabIndex = 15;
            this.inventoryTab.Text = "Shop Inventories";
            // 
            // allStoreInventoryEditor1
            // 
            this.allStoreInventoryEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allStoreInventoryEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allStoreInventoryEditor1.Name = "allStoreInventoryEditor1";
            this.allStoreInventoryEditor1.Size = new System.Drawing.Size( 786, 691 );
            this.allStoreInventoryEditor1.TabIndex = 0;
            // 
            // FFTPatchEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.tabControl );
            this.Name = "FFTPatchEditor";
            this.Size = new System.Drawing.Size( 800, 741 );
            this.tabControl.ResumeLayout( false );
            this.abilitiesPage.ResumeLayout( false );
            this.abilitiesPage.PerformLayout();
            this.itemsTabPage.ResumeLayout( false );
            this.itemAttributesTabPage.ResumeLayout( false );
            this.jobsPage.ResumeLayout( false );
            this.jobLevelsTab.ResumeLayout( false );
            this.jobLevelsTab.PerformLayout();
            this.skillSetsPage.ResumeLayout( false );
            this.monsterSkillsTab.ResumeLayout( false );
            this.monsterSkillsTab.PerformLayout();
            this.actionMenusTabPage.ResumeLayout( false );
            this.statusEffectsTab.ResumeLayout( false );
            this.inflictStatusesTabPage.ResumeLayout( false );
            this.poachingTabPage.ResumeLayout( false );
            this.codesTab.ResumeLayout( false );
            this.entdTab.ResumeLayout( false );
            this.tabPage1.ResumeLayout( false );
            this.tabPage1.PerformLayout();
            this.inventoryTab.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage abilitiesPage;
        private AllAbilitiesEditor allAbilitiesEditor1;
        private System.Windows.Forms.TabPage itemsTabPage;
        private AllItemsEditor allItemsEditor1;
        private System.Windows.Forms.TabPage itemAttributesTabPage;
        private AllItemAttributesEditor allItemAttributesEditor1;
        private System.Windows.Forms.TabPage jobsPage;
        private AllJobsEditor allJobsEditor1;
        private System.Windows.Forms.TabPage jobLevelsTab;
        private JobLevelsEditor jobLevelsEditor1;
        private System.Windows.Forms.TabPage skillSetsPage;
        private AllSkillSetsEditor allSkillSetsEditor1;
        private System.Windows.Forms.TabPage monsterSkillsTab;
        private AllMonsterSkillsEditor allMonsterSkillsEditor1;
        private System.Windows.Forms.TabPage actionMenusTabPage;
        private AllActionMenusEditor allActionMenusEditor1;
        private System.Windows.Forms.TabPage statusEffectsTab;
        private AllStatusAttributesEditor allStatusAttributesEditor1;
        private System.Windows.Forms.TabPage inflictStatusesTabPage;
        private AllInflictStatusesEditor allInflictStatusesEditor1;
        private System.Windows.Forms.TabPage poachingTabPage;
        private AllPoachProbabilitiesEditor allPoachProbabilitiesEditor1;
        private System.Windows.Forms.TabPage codesTab;
        private CodeCreator codeCreator1;
        private System.Windows.Forms.TabPage entdTab;
        private ENTDEditor entdEditor1;
        private System.Windows.Forms.TabPage tabPage1;
        private AllMoveFindItemsEditor allMoveFindItemsEditor1;
        private System.Windows.Forms.TabPage inventoryTab;
        private FFTPatcher.Editors.Items.AllStoreInventoryEditor allStoreInventoryEditor1;
    }
}
