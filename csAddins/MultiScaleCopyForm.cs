﻿using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Bentley.MicroStation.WinForms;

namespace csAddins
{
    public partial class MultiScaleCopyForm : //Form
                                              Adapter 
    {
        public MultiScaleCopyForm()
        {
            InitializeComponent();
        }
        
        private void txtScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtXOffset_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
                e.Handled = true;
        }

        private void txtCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtScale.Text = txtScale.Tag.ToString();
            txtXOffset.Text = txtXOffset.Tag.ToString();
            txtYOffset.Text = txtYOffset.Tag.ToString();
            txtZOffset.Text = txtZOffset.Tag.ToString();
            txtCopies.Text = txtCopies.Tag.ToString();
        }

        private void MultiScaleCopyForm_Load(object sender, EventArgs e)
        {
            RegistryKey myKey = Registry.CurrentUser.OpenSubKey("Software\\csAddins\\MultiScaleCopy");
            if (null != myKey)
            {
                txtScale.Text = myKey.GetValue("txtScale").ToString();
                txtXOffset.Text = myKey.GetValue("txtXOffset").ToString();
                txtYOffset.Text = myKey.GetValue("txtYOffset").ToString();
                txtZOffset.Text = myKey.GetValue("txtZOffset").ToString();
                txtCopies.Text = myKey.GetValue("txtCopies").ToString();
            }
        }

        private void MultiScaleCopyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistryKey rootKey = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey appKey = rootKey.CreateSubKey("csAddins");
            RegistryKey myKey = appKey.CreateSubKey ("MultiScaleCopy");
            myKey.SetValue("txtScale", txtScale.Text.ToString());
            myKey.SetValue("txtXOffset", txtXOffset.Text.ToString());
            myKey.SetValue("txtYOffset", txtYOffset.Text.ToString());
            myKey.SetValue("txtZOffset", txtZOffset.Text.ToString());
            myKey.SetValue("txtCopies", txtCopies.Text.ToString());
        }
    }
}
