﻿/*
 *                     GNU AFFERO GENERAL PUBLIC LICENSE
 *                       Version 3, 19 November 2007
 *  Copyright (C) 2007 Free Software Foundation, Inc. <https://fsf.org/>
 *  Everyone is permitted to copy and distribute verbatim copies
 *  of this license document, but changing it is not allowed.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using UVtools.Core;

namespace UVtools.GUI.Forms
{
    public partial class FrmMutation : Form
    {
        #region Properties

        private Mutation Mutation { get; }

        public uint LayerRangeStart
        {
            get => (uint) nmLayerRangeStart.Value;
            set => nmLayerRangeStart.Value = value;
        }

        public uint LayerRangeEnd
        {
            get => (uint)Math.Min(nmLayerRangeEnd.Value, Program.SlicerFile.LayerCount-1);
            set => nmLayerRangeEnd.Value = value;
        }

        public uint Iterations
        {
            get => (uint) numIterationsStart.Value;
            set => numIterationsStart.Value = value;
        }

        public uint IterationsEnd
        {
            get => (uint)nmIterationsEnd.Value;
            set => nmIterationsEnd.Value = value;
        }

        public bool IterationsFade
        {
            get => cbIterationsFade.Checked;
            set => cbIterationsFade.Checked = value;
        }

        public Matrix<byte> KernelMatrix { get; private set; }
        public Point KernelAnchor => ctrlKernel.KernelAnchor;
        #endregion

        #region Constructors

        public FrmMutation()
        {
            InitializeComponent();
        }

        public FrmMutation(Mutation mutation, uint defaultIterations = 1) : this()
        {
            
            Mutation = mutation;
            DialogResult = DialogResult.Cancel;

            if (defaultIterations == 0)
            {
                lbIterationsStart.Enabled =
                numIterationsStart.Enabled =
                lbIterationsStop.Enabled =
                nmIterationsEnd.Enabled =
                cbIterationsFade.Enabled =
                        false;
            }
            else
            {
                Iterations = defaultIterations;
                numIterationsStart.Select();
            }

            Text = $"Mutate: {mutation.MenuName}";
            lbDescription.Text = Mutation.Description;

            if (ReferenceEquals(mutation.Image, null))
            {
                Width = pbInfo.Location.X+25;
            }
            else
            {
                pbInfo.Image = mutation.Image;
                pbInfo.Visible = true;
            }

            nmLayerRangeEnd.Value = Program.SlicerFile.LayerCount-1;

        }
        #endregion

        #region Overrides
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Enter)
            {
                if (ctrlKernel.tbKernel.ContainsFocus) return;
                btnMutate.PerformClick();
                e.Handled = true;
                return;
            }

            if ((ModifierKeys & Keys.Shift) == Keys.Shift && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (e.KeyCode == Keys.A)
                {
                    btnLayerRangeAllLayers.PerformClick();
                    e.Handled = true;
                    return;
                }

                if (e.KeyCode == Keys.C)
                {
                    btnLayerRangeCurrentLayer.PerformClick();
                    e.Handled = true;
                    return;
                }

                if (e.KeyCode == Keys.B)
                {
                    btnLayerRangeBottomLayers.PerformClick();
                    e.Handled = true;
                    return;
                }

                if (e.KeyCode == Keys.N)
                {
                    btnLayerRangeNormalLayers.PerformClick();
                    e.Handled = true;
                    return;
                }
            }
        }

        #endregion

        #region Events
        private void ItemClicked(object sender, EventArgs e)
        {
            if (ReferenceEquals(sender, btnLayerRangeAllLayers))
            {
                nmLayerRangeStart.Value = 0;
                nmLayerRangeEnd.Value = Program.SlicerFile.LayerCount-1;
                return;
            }

            if (ReferenceEquals(sender, btnLayerRangeCurrentLayer))
            {
                nmLayerRangeStart.Value = Program.FrmMain.ActualLayer;
                nmLayerRangeEnd.Value = Program.FrmMain.ActualLayer;
                return;
            }

            if (ReferenceEquals(sender, btnLayerRangeBottomLayers))
            {
                nmLayerRangeStart.Value = 0;
                nmLayerRangeEnd.Value = Program.SlicerFile.InitialLayerCount-1;
                return;
            }

            if (ReferenceEquals(sender, btnLayerRangeNormalLayers))
            {
                nmLayerRangeStart.Value = Program.SlicerFile.InitialLayerCount - 1;
                nmLayerRangeEnd.Value = Program.SlicerFile.LayerCount - 1;
                return;
            }

            if (ReferenceEquals(sender, btnMutate))
            {
                if (!btnMutate.Enabled) return;
                if (LayerRangeStart > LayerRangeEnd)
                {
                    MessageBox.Show("Layer range start can't be higher than layer end.\nPlease fix and try again.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nmLayerRangeStart.Select();
                    return;
                }

                KernelMatrix = ctrlKernel.GetMatrix();
                if (ReferenceEquals(KernelMatrix, null)) return;


                var operationName = string.IsNullOrEmpty(Mutation.MenuName) ? Mutation.Mutate.ToString() : Mutation.MenuName;
                if (MessageBox.Show($"Are you sure you want to {operationName}?", Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    if (Iterations <= 0) // Should never happen!
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    Close();
                }

                return;
            }

            if (ReferenceEquals(sender, btnCancel))
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (ReferenceEquals(sender, cbIterationsFade))
            {
                lbIterationsStop.Enabled =
                    nmIterationsEnd.Enabled =
                        cbIterationsFade.Checked;

                return;
            }
        }
        #endregion


    }
}
