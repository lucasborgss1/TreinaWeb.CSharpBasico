namespace OperadoresAritmeticos
{
    partial class frmCalculadora
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
            btnSomar = new Button();
            btnMultiplicar = new Button();
            btnRestoDivisao = new Button();
            btnDividir = new Button();
            btnSubtrair = new Button();
            lblN1 = new Label();
            lblN2 = new Label();
            txbn1 = new TextBox();
            txbn2 = new TextBox();
            txbresult = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(200, 22);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 8;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(200, 51);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 9;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnRestoDivisao
            // 
            btnRestoDivisao.Location = new Point(240, 80);
            btnRestoDivisao.Name = "btnRestoDivisao";
            btnRestoDivisao.Size = new Size(83, 23);
            btnRestoDivisao.TabIndex = 10;
            btnRestoDivisao.Text = "RestoDivisao";
            btnRestoDivisao.UseVisualStyleBackColor = true;
            btnRestoDivisao.Click += btnRestoDivisao_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(281, 51);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 11;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(281, 22);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 12;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(12, 30);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(63, 15);
            lblN1.TabIndex = 13;
            lblN1.Text = "Número 1:";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(12, 59);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(63, 15);
            lblN2.TabIndex = 14;
            lblN2.Text = "Número 2:";
            // 
            // txbn1
            // 
            txbn1.Location = new Point(81, 27);
            txbn1.Name = "txbn1";
            txbn1.Size = new Size(100, 23);
            txbn1.TabIndex = 15;
            // 
            // txbn2
            // 
            txbn2.Location = new Point(81, 56);
            txbn2.Name = "txbn2";
            txbn2.Size = new Size(100, 23);
            txbn2.TabIndex = 16;
            // 
            // txbresult
            // 
            txbresult.Location = new Point(200, 117);
            txbresult.Name = "txbresult";
            txbresult.ReadOnly = true;
            txbresult.Size = new Size(100, 23);
            txbresult.TabIndex = 17;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(119, 120);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 18;
            lblResultado.Text = "Resultado:";
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 155);
            Controls.Add(lblResultado);
            Controls.Add(txbresult);
            Controls.Add(txbn2);
            Controls.Add(txbn1);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(btnSubtrair);
            Controls.Add(btnDividir);
            Controls.Add(btnRestoDivisao);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSomar);
            Name = "frmCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSomar;
        private Button btnMultiplicar;
        private Button btnRestoDivisao;
        private Button btnDividir;
        private Button btnSubtrair;
        private Label lblN1;
        private Label lblN2;
        private TextBox txbn1;
        private TextBox txbn2;
        private TextBox txbresult;
        private Label lblResultado;
    }
}
