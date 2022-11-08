namespace exAREA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTittulo = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblhp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTittulo
            // 
            this.lblTittulo.AutoSize = true;
            this.lblTittulo.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTittulo.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTittulo.Location = new System.Drawing.Point(95, 23);
            this.lblTittulo.Name = "lblTittulo";
            this.lblTittulo.Size = new System.Drawing.Size(244, 24);
            this.lblTittulo.TabIndex = 0;
            this.lblTittulo.Text = "Calculadora de IMC";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.BackColor = System.Drawing.Color.GhostWhite;
            this.lblN1.Location = new System.Drawing.Point(74, 107);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(31, 13);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Peso";
            this.lblN1.Click += new System.EventHandler(this.lblN1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(74, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Lavender;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(300, 107);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 34);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.GhostWhite;
            this.lblResultado.Font = new System.Drawing.Font("PanRoman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblResultado.Location = new System.Drawing.Point(74, 179);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 15);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "IMC";
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(121, 177);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(100, 20);
            this.txbResultado.TabIndex = 7;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(121, 104);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 8;
            this.txbPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(121, 136);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 9;
            this.txbAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblhp
            // 
            this.lblhp.AutoSize = true;
            this.lblhp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblhp.Location = new System.Drawing.Point(141, 212);
            this.lblhp.Name = "lblhp";
            this.lblhp.Size = new System.Drawing.Size(0, 21);
            this.lblhp.TabIndex = 10;
            this.lblhp.Click += new System.EventHandler(this.lblhp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.lblhp);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblTittulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cslculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittulo;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label lblhp;
    }
}

