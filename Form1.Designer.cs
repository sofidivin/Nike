namespace Nike
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Home = new Guna.UI2.WinForms.Guna2Button();
            this.btn_precio = new Guna.UI2.WinForms.Guna2Button();
            this.btn_color = new Guna.UI2.WinForms.Guna2Button();
            this.btn_categoria = new Guna.UI2.WinForms.Guna2Button();
            this.btn_producto = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 69);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(826, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Administrador";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ErrorImage = global::Nike.Properties.Resources.pelado;
            this.guna2CirclePictureBox1.Image = global::Nike.Properties.Resources.pelado1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.InitialImage = global::Nike.Properties.Resources.pelado;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1017, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(68, 63);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "NIKE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nike.Properties.Resources.nike;
            this.pictureBox1.Location = new System.Drawing.Point(37, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Controls.Add(this.btn_precio);
            this.panel2.Controls.Add(this.btn_color);
            this.panel2.Controls.Add(this.btn_categoria);
            this.panel2.Controls.Add(this.btn_producto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 51);
            this.panel2.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.White;
            this.btn_Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Home.Checked = true;
            this.btn_Home.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_Home.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Home.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Home.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_Home.Location = new System.Drawing.Point(37, 6);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(167, 39);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_precio
            // 
            this.btn_precio.BackColor = System.Drawing.Color.White;
            this.btn_precio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_precio.Checked = true;
            this.btn_precio.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_precio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_precio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_precio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_precio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_precio.ForeColor = System.Drawing.Color.Black;
            this.btn_precio.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_precio.Location = new System.Drawing.Point(895, 6);
            this.btn_precio.Name = "btn_precio";
            this.btn_precio.Size = new System.Drawing.Size(167, 39);
            this.btn_precio.TabIndex = 1;
            this.btn_precio.Text = "Precio";
            this.btn_precio.Click += new System.EventHandler(this.btn_precio_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_color.Checked = true;
            this.btn_color.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_color.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_color.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_color.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_color.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_color.Location = new System.Drawing.Point(672, 6);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(167, 39);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_categoria
            // 
            this.btn_categoria.BackColor = System.Drawing.Color.White;
            this.btn_categoria.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_categoria.Checked = true;
            this.btn_categoria.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_categoria.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_categoria.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_categoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_categoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_categoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_categoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_categoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_categoria.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_categoria.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_categoria.Location = new System.Drawing.Point(455, 6);
            this.btn_categoria.Name = "btn_categoria";
            this.btn_categoria.Size = new System.Drawing.Size(167, 39);
            this.btn_categoria.TabIndex = 1;
            this.btn_categoria.Text = "Categoria";
            this.btn_categoria.Click += new System.EventHandler(this.btn_categoria_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.BackColor = System.Drawing.Color.White;
            this.btn_producto.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_producto.Checked = true;
            this.btn_producto.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_producto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_producto.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_producto.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_producto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_producto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_producto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_producto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_producto.ForeColor = System.Drawing.Color.Black;
            this.btn_producto.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_producto.Location = new System.Drawing.Point(252, 6);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(167, 39);
            this.btn_producto.TabIndex = 1;
            this.btn_producto.Text = "Producto";
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelContainer.ForeColor = System.Drawing.Color.Black;
            this.panelContainer.Location = new System.Drawing.Point(0, 120);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1119, 413);
            this.panelContainer.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 533);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btn_precio;
        private Guna.UI2.WinForms.Guna2Button btn_color;
        private Guna.UI2.WinForms.Guna2Button btn_categoria;
        private Guna.UI2.WinForms.Guna2Button btn_producto;
        private Guna.UI2.WinForms.Guna2Button btn_Home;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}