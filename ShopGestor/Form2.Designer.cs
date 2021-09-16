
namespace ShopGestor
{
    partial class FormListar
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
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblListar = new System.Windows.Forms.Label();
            this.PbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(21, 135);
            this.DgvArticulos.Margin = new System.Windows.Forms.Padding(5);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.RowHeadersWidth = 51;
            this.DgvArticulos.Size = new System.Drawing.Size(635, 300);
            this.DgvArticulos.TabIndex = 0;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged_1);
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.Location = new System.Drawing.Point(287, 37);
            this.lblListar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(248, 31);
            this.lblListar.TabIndex = 1;
            this.lblListar.Text = "Listado de artículos";
            // 
            // PbxArticulo
            // 
            this.PbxArticulo.Location = new System.Drawing.Point(741, 135);
            this.PbxArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.PbxArticulo.Name = "PbxArticulo";
            this.PbxArticulo.Size = new System.Drawing.Size(352, 300);
            this.PbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxArticulo.TabIndex = 2;
            this.PbxArticulo.TabStop = false;
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 481);
            this.Controls.Add(this.PbxArticulo);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.DgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormListar";
            this.Text = "Listar artículos";
            this.Load += new System.EventHandler(this.FormListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.PictureBox PbxArticulo;
    }
}