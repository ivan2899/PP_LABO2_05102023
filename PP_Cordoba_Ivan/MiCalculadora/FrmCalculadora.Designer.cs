namespace MiCalculadora
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.grpSistema = new System.Windows.Forms.GroupBox();
            this.rdbBinario = new System.Windows.Forms.RadioButton();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.txtPrimerOperando = new System.Windows.Forms.TextBox();
            this.txtSegundoOperando = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPrimerOperador = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblSegundoOperador = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.grpSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.Black;
            this.btnOperar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOperar.Location = new System.Drawing.Point(42, 481);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(126, 37);
            this.btnOperar.TabIndex = 7;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(272, 481);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 37);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(493, 481);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(126, 37);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(271, 351);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(159, 23);
            this.cmbOperacion.TabIndex = 3;
            // 
            // grpSistema
            // 
            this.grpSistema.BackColor = System.Drawing.Color.Transparent;
            this.grpSistema.Controls.Add(this.rdbBinario);
            this.grpSistema.Controls.Add(this.rdbDecimal);
            this.grpSistema.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSistema.ForeColor = System.Drawing.SystemColors.Window;
            this.grpSistema.Location = new System.Drawing.Point(254, 128);
            this.grpSistema.Name = "grpSistema";
            this.grpSistema.Size = new System.Drawing.Size(289, 85);
            this.grpSistema.TabIndex = 0;
            this.grpSistema.TabStop = false;
            this.grpSistema.Text = "REPRESENTAR RESULTADO EN:";
            // 
            // rdbBinario
            // 
            this.rdbBinario.AutoSize = true;
            this.rdbBinario.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbBinario.ForeColor = System.Drawing.SystemColors.Window;
            this.rdbBinario.Location = new System.Drawing.Point(133, 37);
            this.rdbBinario.Name = "rdbBinario";
            this.rdbBinario.Size = new System.Drawing.Size(79, 24);
            this.rdbBinario.TabIndex = 6;
            this.rdbBinario.Text = "Binario";
            this.rdbBinario.UseVisualStyleBackColor = true;
            this.rdbBinario.CheckedChanged += new System.EventHandler(this.rdbBinario_CheckedChanged);
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.Checked = true;
            this.rdbDecimal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbDecimal.ForeColor = System.Drawing.SystemColors.Window;
            this.rdbDecimal.Location = new System.Drawing.Point(7, 37);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.Size = new System.Drawing.Size(85, 24);
            this.rdbDecimal.TabIndex = 5;
            this.rdbDecimal.TabStop = true;
            this.rdbDecimal.Text = "Decimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            this.rdbDecimal.CheckedChanged += new System.EventHandler(this.rdbDecimal_CheckedChanged);
            // 
            // txtPrimerOperando
            // 
            this.txtPrimerOperando.Location = new System.Drawing.Point(23, 351);
            this.txtPrimerOperando.Name = "txtPrimerOperando";
            this.txtPrimerOperando.PlaceholderText = "Ingrese un numero";
            this.txtPrimerOperando.Size = new System.Drawing.Size(159, 23);
            this.txtPrimerOperando.TabIndex = 2;
            // 
            // txtSegundoOperando
            // 
            this.txtSegundoOperando.Location = new System.Drawing.Point(493, 351);
            this.txtSegundoOperando.Name = "txtSegundoOperando";
            this.txtSegundoOperando.PlaceholderText = "Ingrese otro numero";
            this.txtSegundoOperando.Size = new System.Drawing.Size(159, 23);
            this.txtSegundoOperando.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(12, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(235, 41);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado: ";
            // 
            // lblPrimerOperador
            // 
            this.lblPrimerOperador.AutoSize = true;
            this.lblPrimerOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimerOperador.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrimerOperador.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrimerOperador.Location = new System.Drawing.Point(23, 313);
            this.lblPrimerOperador.Name = "lblPrimerOperador";
            this.lblPrimerOperador.Size = new System.Drawing.Size(172, 22);
            this.lblPrimerOperador.TabIndex = 0;
            this.lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacion.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperacion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOperacion.Location = new System.Drawing.Point(283, 313);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(115, 22);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            this.lblSegundoOperador.AutoSize = true;
            this.lblSegundoOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundoOperador.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoOperador.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSegundoOperador.Location = new System.Drawing.Point(493, 313);
            this.lblSegundoOperador.Name = "lblSegundoOperador";
            this.lblSegundoOperador.Size = new System.Drawing.Size(183, 22);
            this.lblSegundoOperador.TabIndex = 0;
            this.lblSegundoOperador.Text = "Segundo operador:";
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 15;
            this.lstHistorial.Location = new System.Drawing.Point(633, 42);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(251, 244);
            this.lstHistorial.TabIndex = 10;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorial.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.ForeColor = System.Drawing.Color.Black;
            this.lblHistorial.Location = new System.Drawing.Point(633, 9);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(99, 22);
            this.lblHistorial.TabIndex = 11;
            this.lblHistorial.Text = "Historial:";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblSegundoOperador);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblPrimerOperador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtSegundoOperando);
            this.Controls.Add(this.txtPrimerOperando);
            this.Controls.Add(this.grpSistema);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora Alumno: Ivan Cordoba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.grpSistema.ResumeLayout(false);
            this.grpSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ComboBox cmbOperacion;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}