
namespace ShopGestor
{
    partial class FormBuscar
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PbxArticulo = new System.Windows.Forms.PictureBox();
            this.DgvResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(252, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(159, 26);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar Artículo";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Location = new System.Drawing.Point(35, 62);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.CbxCriterio.TabIndex = 1;
            this.CbxCriterio.SelectionChangeCommitted += new System.EventHandler(this.CbxCriterio_SelectionChangeCommitted);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(191, 63);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(175, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Text = "buscar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(429, 63);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(552, 63);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // PbxArticulo
            // 
            this.PbxArticulo.Location = new System.Drawing.Point(429, 104);
            this.PbxArticulo.Name = "PbxArticulo";
            this.PbxArticulo.Size = new System.Drawing.Size(198, 198);
            this.PbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxArticulo.TabIndex = 8;
            this.PbxArticulo.TabStop = false;
            // 
            // DgvResultado
            // 
            this.DgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResultado.Location = new System.Drawing.Point(35, 104);
            this.DgvResultado.Name = "DgvResultado";
            this.DgvResultado.Size = new System.Drawing.Size(376, 198);
            this.DgvResultado.TabIndex = 9;
            this.DgvResultado.SelectionChanged += new System.EventHandler(this.DgvResultado_SelectionChanged);
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(652, 324);
            this.Controls.Add(this.DgvResultado);
            this.Controls.Add(this.PbxArticulo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.CbxCriterio);
            this.Controls.Add(this.lblBuscar);
            this.Name = "FormBuscar";
            this.Text = "Buscar Artículo";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.PictureBox PbxArticulo;
        private System.Windows.Forms.DataGridView DgvResultado;
    }
}