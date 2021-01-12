
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuButtonLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonRegistration = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.updateProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(223, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.addProductToolStripMenuItem.Text = "Add product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.deleteProductToolStripMenuItem.Text = "Delete product";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.updateProductToolStripMenuItem.Text = "Update product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.updateProductToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.bunifuButtonLogin);
            this.panel2.Controls.Add(this.bunifuButtonRegistration);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 512);
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
            this.bunifuButtonLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonLogin.ForeColor = System.Drawing.Color.White;
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
            this.bunifuButtonLogin.Location = new System.Drawing.Point(34, 102);
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
            this.bunifuButtonLogin.OnIdleState.ForeColor = System.Drawing.Color.White;
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
            this.bunifuButtonLogin.TabIndex = 3;
            this.bunifuButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonLogin.TextMarginLeft = 0;
            this.bunifuButtonLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonLogin.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonLogin.Click += new System.EventHandler(this.bunifuButtonLogin_Click_1);
            // 
            // bunifuButtonRegistration
            // 
            this.bunifuButtonRegistration.AllowAnimations = true;
            this.bunifuButtonRegistration.AllowMouseEffects = true;
            this.bunifuButtonRegistration.AllowToggling = false;
            this.bunifuButtonRegistration.AnimationSpeed = 200;
            this.bunifuButtonRegistration.AutoGenerateColors = false;
            this.bunifuButtonRegistration.AutoRoundBorders = false;
            this.bunifuButtonRegistration.AutoSizeLeftIcon = true;
            this.bunifuButtonRegistration.AutoSizeRightIcon = true;
            this.bunifuButtonRegistration.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonRegistration.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonRegistration.BackgroundImage")));
            this.bunifuButtonRegistration.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRegistration.ButtonText = "Registration";
            this.bunifuButtonRegistration.ButtonTextMarginLeft = 0;
            this.bunifuButtonRegistration.ColorContrastOnClick = 45;
            this.bunifuButtonRegistration.ColorContrastOnHover = 45;
            this.bunifuButtonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButtonRegistration.CustomizableEdges = borderEdges2;
            this.bunifuButtonRegistration.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonRegistration.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonRegistration.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonRegistration.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonRegistration.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonRegistration.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRegistration.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonRegistration.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonRegistration.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonRegistration.IconMarginLeft = 11;
            this.bunifuButtonRegistration.IconPadding = 10;
            this.bunifuButtonRegistration.IconRightAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bunifuButtonRegistration.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonRegistration.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonRegistration.IconSize = 25;
            this.bunifuButtonRegistration.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonRegistration.IdleBorderRadius = 1;
            this.bunifuButtonRegistration.IdleBorderThickness = 1;
            this.bunifuButtonRegistration.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonRegistration.IdleIconLeftImage = null;
            this.bunifuButtonRegistration.IdleIconRightImage = null;
            this.bunifuButtonRegistration.IndicateFocus = false;
            this.bunifuButtonRegistration.Location = new System.Drawing.Point(34, 162);
            this.bunifuButtonRegistration.Name = "bunifuButtonRegistration";
            this.bunifuButtonRegistration.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonRegistration.OnDisabledState.BorderRadius = 1;
            this.bunifuButtonRegistration.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRegistration.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonRegistration.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonRegistration.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonRegistration.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonRegistration.OnDisabledState.IconRightImage = null;
            this.bunifuButtonRegistration.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.bunifuButtonRegistration.onHoverState.BorderRadius = 1;
            this.bunifuButtonRegistration.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRegistration.onHoverState.BorderThickness = 1;
            this.bunifuButtonRegistration.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.bunifuButtonRegistration.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRegistration.onHoverState.IconLeftImage = null;
            this.bunifuButtonRegistration.onHoverState.IconRightImage = null;
            this.bunifuButtonRegistration.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonRegistration.OnIdleState.BorderRadius = 1;
            this.bunifuButtonRegistration.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRegistration.OnIdleState.BorderThickness = 1;
            this.bunifuButtonRegistration.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.bunifuButtonRegistration.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRegistration.OnIdleState.IconLeftImage = null;
            this.bunifuButtonRegistration.OnIdleState.IconRightImage = null;
            this.bunifuButtonRegistration.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.bunifuButtonRegistration.OnPressedState.BorderRadius = 1;
            this.bunifuButtonRegistration.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonRegistration.OnPressedState.BorderThickness = 1;
            this.bunifuButtonRegistration.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.bunifuButtonRegistration.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonRegistration.OnPressedState.IconLeftImage = null;
            this.bunifuButtonRegistration.OnPressedState.IconRightImage = null;
            this.bunifuButtonRegistration.Size = new System.Drawing.Size(154, 39);
            this.bunifuButtonRegistration.TabIndex = 2;
            this.bunifuButtonRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonRegistration.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonRegistration.TextMarginLeft = 0;
            this.bunifuButtonRegistration.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonRegistration.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonRegistration.Click += new System.EventHandler(this.bunifuButtonRegistration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 512);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonRegistration;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonLogin;
    }
}

