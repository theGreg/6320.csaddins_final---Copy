namespace csAddins
{
    partial class ToolbarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnTopLevel = new System.Windows.Forms.Button();
            this.btnToolSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.Image = global::csAddins.Properties.Resources.modal;
            this.btnModal.Location = new System.Drawing.Point(5, 3);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(32, 32);
            this.btnModal.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnModal, "Demo Modal Dialogbox");
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnTopLevel
            // 
            this.btnTopLevel.Image = global::csAddins.Properties.Resources.toplevel;
            this.btnTopLevel.Location = new System.Drawing.Point(43, 3);
            this.btnTopLevel.Name = "btnTopLevel";
            this.btnTopLevel.Size = new System.Drawing.Size(32, 32);
            this.btnTopLevel.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnTopLevel, "Demo TopLevel Dialogbox");
            this.btnTopLevel.UseVisualStyleBackColor = true;
            this.btnTopLevel.Click += new System.EventHandler(this.btnTopLevel_Click);
            // 
            // btnToolSettings
            // 
            this.btnToolSettings.Image = global::csAddins.Properties.Resources.tool;
            this.btnToolSettings.Location = new System.Drawing.Point(81, 3);
            this.btnToolSettings.Name = "btnToolSettings";
            this.btnToolSettings.Size = new System.Drawing.Size(32, 32);
            this.btnToolSettings.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnToolSettings, "Demo ToolSettings Dialogbox");
            this.btnToolSettings.UseVisualStyleBackColor = true;
            this.btnToolSettings.Click += new System.EventHandler(this.btnToolSettings_Click);
            // 
            // ToolbarForm
            // 
            this.ClientSize = new System.Drawing.Size(118, 34);
            this.Controls.Add(this.btnToolSettings);
            this.Controls.Add(this.btnTopLevel);
            this.Controls.Add(this.btnModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolbarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Demo Toolbar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnTopLevel;
        private System.Windows.Forms.Button btnToolSettings;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}