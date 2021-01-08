
namespace PresentationLayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuButtonLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.updateProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(284, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.addProductToolStripMenuItem.Text = "Add product";
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.deleteProductToolStripMenuItem.Text = "Delete product";
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.updateProductToolStripMenuItem.Text = "Update product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.bunifuButtonLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 512);
            this.panel2.TabIndex = 17;
            // 
            // bunifuButtonLogin
            // 
            this.bunifuButtonLogin.AllowAnimations = true;
            this.bunifuButtonLogin.AllowMouseEffects = true;
            this.bunifuButtonLogin.AllowToggling = false;
            this.bunifuButtonLogin.AnimationSpeed = 200;
            this.bunifuButtonLogin.AutoGenerateColors = false;
            this.bunifuButtonLogin.AutoRoundBorders = false;
            this.bunifuButtonLogin.AutoSizeLeftIcon = true;
            this.bunifuButtonLogin.AutoSizeRightIcon = true;
            this.bunifuButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonLogin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonLogin.BackgroundImage")));
            this.bunifuButtonLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonLogin.ButtonText = "Login";
            this.bunifuButtonLogin.ButtonTextMarginLeft = 0;
            this.bunifuButtonLogin.ColorContrastOnClick = 45;
            this.bunifuButtonLogin.ColorContrastOnHover = 45;
            this.bunifuButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButtonLogin.CustomizableEdges = borderEdges1;
            this.bunifuButtonLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuButtonLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonLogin.IconMarginLeft = 11;
            this.bunifuButtonLogin.IconPadding = 10;
            this.bunifuButtonLogin.IconRightAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bunifuButtonLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonLogin.IconSize = 25;
            this.bunifuButtonLogin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonLogin.IdleBorderRadius = 1;
            this.bunifuButtonLogin.IdleBorderThickness = 1;
            this.bunifuButtonLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonLogin.IdleIconLeftImage = null;
            this.bunifuButtonLogin.IdleIconRightImage = null;
            this.bunifuButtonLogin.IndicateFocus = false;
            this.bunifuButtonLogin.Location = new System.Drawing.Point(61, 112);
            this.bunifuButtonLogin.Name = "bunifuButtonLogin";
            this.bunifuButtonLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonLogin.OnDisabledState.BorderRadius = 1;
            this.bunifuButtonLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonLogin.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonLogin.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonLogin.OnDisabledState.IconRightImage = null;
            this.bunifuButtonLogin.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.bunifuButtonLogin.onHoverState.BorderRadius = 1;
            this.bunifuButtonLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonLogin.onHoverState.BorderThickness = 1;
            this.bunifuButtonLogin.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.bunifuButtonLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonLogin.onHoverState.IconLeftImage = null;
            this.bunifuButtonLogin.onHoverState.IconRightImage = null;
            this.bunifuButtonLogin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonLogin.OnIdleState.BorderRadius = 1;
            this.bunifuButtonLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonLogin.OnIdleState.BorderThickness = 1;
            this.bunifuButtonLogin.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonLogin.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuButtonLogin.OnIdleState.IconLeftImage = null;
            this.bunifuButtonLogin.OnIdleState.IconRightImage = null;
            this.bunifuButtonLogin.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.bunifuButtonLogin.OnPressedState.BorderRadius = 1;
            this.bunifuButtonLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonLogin.OnPressedState.BorderThickness = 1;
            this.bunifuButtonLogin.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.bunifuButtonLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonLogin.OnPressedState.IconLeftImage = null;
            this.bunifuButtonLogin.OnPressedState.IconRightImage = null;
            this.bunifuButtonLogin.Size = new System.Drawing.Size(154, 39);
            this.bunifuButtonLogin.TabIndex = 1;
            this.bunifuButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonLogin.TextMarginLeft = 0;
            this.bunifuButtonLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonLogin.UseDefaultRadiusAndThickness = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 512);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonLogin;
    }
}

