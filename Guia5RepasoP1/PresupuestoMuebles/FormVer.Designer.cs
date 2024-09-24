namespace PresupuestoMuebles
{
    partial class FormVer
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
            this.listBVer = new System.Windows.Forms.ListBox();
            this.btnCerrarVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBVer
            // 
            this.listBVer.FormattingEnabled = true;
            this.listBVer.Location = new System.Drawing.Point(12, 12);
            this.listBVer.Name = "listBVer";
            this.listBVer.Size = new System.Drawing.Size(363, 342);
            this.listBVer.TabIndex = 0;
            // 
            // btnCerrarVer
            // 
            this.btnCerrarVer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrarVer.Location = new System.Drawing.Point(152, 360);
            this.btnCerrarVer.Name = "btnCerrarVer";
            this.btnCerrarVer.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarVer.TabIndex = 1;
            this.btnCerrarVer.Text = "Cerrar";
            this.btnCerrarVer.UseVisualStyleBackColor = true;
            // 
            // FormVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 387);
            this.Controls.Add(this.btnCerrarVer);
            this.Controls.Add(this.listBVer);
            this.Name = "FormVer";
            this.Text = "FormVer";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBVer;
        public System.Windows.Forms.Button btnCerrarVer;
    }
}