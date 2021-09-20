
namespace ShopGestor
{
    partial class Form8
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(419, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 22);
            this.txtID.TabIndex = 0;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(611, 105);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(89, 39);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "BUSCAR";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 175);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(984, 193);
            this.dgvDetalle.TabIndex = 2;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(1002, 175);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(196, 193);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(411, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 44);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Mostrar Detalle";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.txtID);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblTitle;
    }
}