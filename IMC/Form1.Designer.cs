namespace IMC
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
            pesoValue = new TextBox();
            label1 = new Label();
            peso = new Label();
            altura = new Label();
            alturaValue = new TextBox();
            resultValue = new TextBox();
            imcValue = new Label();
            calculo = new Button();
            SuspendLayout();
            // 
            // pesoValue
            // 
            pesoValue.Location = new Point(49, 43);
            pesoValue.Name = "pesoValue";
            pesoValue.Size = new Size(72, 23);
            pesoValue.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Cálculo IMC";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // peso
            // 
            peso.AutoSize = true;
            peso.Location = new Point(8, 46);
            peso.Name = "peso";
            peso.Size = new Size(35, 15);
            peso.TabIndex = 1;
            peso.Text = "Peso:";
            // 
            // altura
            // 
            altura.AutoSize = true;
            altura.Location = new Point(1, 75);
            altura.Name = "altura";
            altura.Size = new Size(42, 15);
            altura.TabIndex = 2;
            altura.Text = "Altura:";
            // 
            // alturaValue
            // 
            alturaValue.Location = new Point(49, 72);
            alturaValue.Name = "alturaValue";
            alturaValue.Size = new Size(72, 23);
            alturaValue.TabIndex = 4;
            // 
            // resultValue
            // 
            resultValue.Location = new Point(81, 106);
            resultValue.Name = "resultValue";
            resultValue.ReadOnly = true;
            resultValue.Size = new Size(72, 23);
            resultValue.TabIndex = 5;
            // 
            // imcValue
            // 
            imcValue.AutoSize = true;
            imcValue.Location = new Point(49, 109);
            imcValue.Name = "imcValue";
            imcValue.Size = new Size(35, 15);
            imcValue.TabIndex = 6;
            imcValue.Text = "IMC: ";
            // 
            // calculo
            // 
            calculo.Location = new Point(128, 56);
            calculo.Name = "calculo";
            calculo.Size = new Size(72, 23);
            calculo.TabIndex = 7;
            calculo.Text = "Calcular";
            calculo.UseVisualStyleBackColor = true;
            calculo.Click += calculo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 153);
            Controls.Add(calculo);
            Controls.Add(imcValue);
            Controls.Add(resultValue);
            Controls.Add(alturaValue);
            Controls.Add(pesoValue);
            Controls.Add(altura);
            Controls.Add(peso);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label peso;
        private Label altura;
        private TextBox pesoValue;
        private TextBox alturaValue;
        private TextBox resultValue;
        private Label imcValue;
        private Button calculo;
    }
}
