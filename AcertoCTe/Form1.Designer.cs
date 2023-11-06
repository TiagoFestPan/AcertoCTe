namespace AcertoCTe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarregamento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTransf = new System.Windows.Forms.RadioButton();
            this.rbCancel = new System.Windows.Forms.RadioButton();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.viewNotas = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carregamento:";
            // 
            // txtCarregamento
            // 
            this.txtCarregamento.Location = new System.Drawing.Point(144, 29);
            this.txtCarregamento.Name = "txtCarregamento";
            this.txtCarregamento.Size = new System.Drawing.Size(155, 20);
            this.txtCarregamento.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTransf);
            this.groupBox1.Controls.Add(this.rbCancel);
            this.groupBox1.Location = new System.Drawing.Point(314, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbTransf
            // 
            this.rbTransf.AutoSize = true;
            this.rbTransf.Location = new System.Drawing.Point(132, 20);
            this.rbTransf.Name = "rbTransf";
            this.rbTransf.Size = new System.Drawing.Size(90, 17);
            this.rbTransf.TabIndex = 1;
            this.rbTransf.TabStop = true;
            this.rbTransf.Text = "Transferência";
            this.rbTransf.UseVisualStyleBackColor = true;
            // 
            // rbCancel
            // 
            this.rbCancel.AutoSize = true;
            this.rbCancel.Location = new System.Drawing.Point(21, 20);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(93, 17);
            this.rbCancel.TabIndex = 0;
            this.rbCancel.TabStop = true;
            this.rbCancel.Text = "Cancelamento";
            this.rbCancel.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(563, 27);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(105, 23);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // viewNotas
            // 
            this.viewNotas.AllowUserToAddRows = false;
            this.viewNotas.AllowUserToDeleteRows = false;
            this.viewNotas.BackgroundColor = System.Drawing.Color.White;
            this.viewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewNotas.Location = new System.Drawing.Point(13, 80);
            this.viewNotas.Name = "viewNotas";
            this.viewNotas.ReadOnly = true;
            this.viewNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewNotas.Size = new System.Drawing.Size(696, 357);
            this.viewNotas.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(572, 443);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Confirmar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 478);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.viewNotas);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCarregamento);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9869 - Validação de CT-e (Rich\'s)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarregamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTransf;
        private System.Windows.Forms.RadioButton rbCancel;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView viewNotas;
        private System.Windows.Forms.Button btnSalvar;
    }
}

