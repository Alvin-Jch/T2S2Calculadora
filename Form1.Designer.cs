namespace T2S2Calculadora
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
            panel_pantalla = new Panel();
            panel_teclado = new Panel();
            panel_operadores = new Panel();
            txt_resultados = new TextBox();
            bt_eliminar = new Button();
            bt_dividir = new Button();
            bt_7 = new Button();
            bt_4 = new Button();
            bt_1 = new Button();
            bt_2 = new Button();
            bt_5 = new Button();
            bt_8 = new Button();
            bt_3 = new Button();
            bt_6 = new Button();
            bt_9 = new Button();
            bt_suma = new Button();
            bt_resta = new Button();
            bt_multiplicar = new Button();
            bt_punto = new Button();
            bt_igual = new Button();
            bt_0 = new Button();
            label_historial = new Label();
            panel_pantalla.SuspendLayout();
            panel_teclado.SuspendLayout();
            panel_operadores.SuspendLayout();
            SuspendLayout();
            // 
            // panel_pantalla
            // 
            panel_pantalla.Controls.Add(label_historial);
            panel_pantalla.Controls.Add(txt_resultados);
            panel_pantalla.Location = new Point(0, 0);
            panel_pantalla.Name = "panel_pantalla";
            panel_pantalla.Size = new Size(355, 177);
            panel_pantalla.TabIndex = 21;
            // 
            // panel_teclado
            // 
            panel_teclado.Controls.Add(bt_0);
            panel_teclado.Controls.Add(bt_punto);
            panel_teclado.Controls.Add(bt_3);
            panel_teclado.Controls.Add(bt_6);
            panel_teclado.Controls.Add(bt_9);
            panel_teclado.Controls.Add(bt_2);
            panel_teclado.Controls.Add(bt_5);
            panel_teclado.Controls.Add(bt_8);
            panel_teclado.Controls.Add(bt_1);
            panel_teclado.Controls.Add(bt_4);
            panel_teclado.Controls.Add(bt_7);
            panel_teclado.Controls.Add(bt_dividir);
            panel_teclado.Controls.Add(bt_eliminar);
            panel_teclado.Location = new Point(0, 177);
            panel_teclado.Name = "panel_teclado";
            panel_teclado.Size = new Size(261, 328);
            panel_teclado.TabIndex = 22;
            // 
            // panel_operadores
            // 
            panel_operadores.Controls.Add(bt_igual);
            panel_operadores.Controls.Add(bt_suma);
            panel_operadores.Controls.Add(bt_resta);
            panel_operadores.Controls.Add(bt_multiplicar);
            panel_operadores.Location = new Point(261, 177);
            panel_operadores.Name = "panel_operadores";
            panel_operadores.Size = new Size(94, 328);
            panel_operadores.TabIndex = 23;
            // 
            // txt_resultados
            // 
            txt_resultados.BackColor = Color.FromArgb(45, 45, 45);
            txt_resultados.BorderStyle = BorderStyle.FixedSingle;
            txt_resultados.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_resultados.ForeColor = SystemColors.Window;
            txt_resultados.Location = new Point(13, 85);
            txt_resultados.Name = "txt_resultados";
            txt_resultados.Size = new Size(330, 61);
            txt_resultados.TabIndex = 0;
            txt_resultados.TextChanged += txt_resultados_TextChanged;
            // 
            // bt_eliminar
            // 
            bt_eliminar.BackColor = Color.FromArgb(45, 45, 45);
            bt_eliminar.FlatStyle = FlatStyle.Popup;
            bt_eliminar.Font = new Font("Segoe UI", 18F);
            bt_eliminar.ForeColor = Color.FromArgb(192, 0, 0);
            bt_eliminar.Location = new Point(12, 0);
            bt_eliminar.Name = "bt_eliminar";
            bt_eliminar.Size = new Size(162, 56);
            bt_eliminar.TabIndex = 1;
            bt_eliminar.Text = "C";
            bt_eliminar.UseVisualStyleBackColor = false;
            bt_eliminar.Click += bt_eliminar_Click;
            // 
            // bt_dividir
            // 
            bt_dividir.BackColor = Color.FromArgb(45, 45, 45);
            bt_dividir.FlatStyle = FlatStyle.Popup;
            bt_dividir.Font = new Font("Segoe UI", 18F);
            bt_dividir.ForeColor = Color.FromArgb(115, 147, 179);
            bt_dividir.Location = new Point(180, 0);
            bt_dividir.Name = "bt_dividir";
            bt_dividir.Size = new Size(78, 56);
            bt_dividir.TabIndex = 3;
            bt_dividir.Text = "/";
            bt_dividir.UseVisualStyleBackColor = false;
            bt_dividir.Click += bt_dividir_Click;
            // 
            // bt_7
            // 
            bt_7.BackColor = Color.FromArgb(45, 45, 45);
            bt_7.FlatStyle = FlatStyle.Popup;
            bt_7.Font = new Font("Segoe UI", 18F);
            bt_7.ForeColor = Color.White;
            bt_7.Location = new Point(12, 62);
            bt_7.Name = "bt_7";
            bt_7.Size = new Size(78, 56);
            bt_7.TabIndex = 5;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = false;
            bt_7.Click += bt_7_Click;
            // 
            // bt_4
            // 
            bt_4.BackColor = Color.FromArgb(45, 45, 45);
            bt_4.FlatStyle = FlatStyle.Popup;
            bt_4.Font = new Font("Segoe UI", 18F);
            bt_4.ForeColor = Color.White;
            bt_4.Location = new Point(12, 124);
            bt_4.Name = "bt_4";
            bt_4.Size = new Size(78, 56);
            bt_4.TabIndex = 6;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = false;
            bt_4.Click += bt_4_Click;
            // 
            // bt_1
            // 
            bt_1.BackColor = Color.FromArgb(45, 45, 45);
            bt_1.FlatStyle = FlatStyle.Popup;
            bt_1.Font = new Font("Segoe UI", 18F);
            bt_1.ForeColor = Color.White;
            bt_1.Location = new Point(12, 186);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(78, 56);
            bt_1.TabIndex = 7;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = false;
            bt_1.Click += bt_1_Click;
            // 
            // bt_2
            // 
            bt_2.BackColor = Color.FromArgb(45, 45, 45);
            bt_2.FlatStyle = FlatStyle.Popup;
            bt_2.Font = new Font("Segoe UI", 18F);
            bt_2.ForeColor = Color.White;
            bt_2.Location = new Point(96, 186);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(78, 56);
            bt_2.TabIndex = 10;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = false;
            bt_2.Click += bt_2_Click;
            // 
            // bt_5
            // 
            bt_5.BackColor = Color.FromArgb(45, 45, 45);
            bt_5.FlatStyle = FlatStyle.Popup;
            bt_5.Font = new Font("Segoe UI", 18F);
            bt_5.ForeColor = Color.White;
            bt_5.Location = new Point(96, 124);
            bt_5.Name = "bt_5";
            bt_5.Size = new Size(78, 56);
            bt_5.TabIndex = 9;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = false;
            bt_5.Click += bt_5_Click;
            // 
            // bt_8
            // 
            bt_8.BackColor = Color.FromArgb(45, 45, 45);
            bt_8.FlatStyle = FlatStyle.Popup;
            bt_8.Font = new Font("Segoe UI", 18F);
            bt_8.ForeColor = Color.White;
            bt_8.Location = new Point(96, 62);
            bt_8.Name = "bt_8";
            bt_8.Size = new Size(78, 56);
            bt_8.TabIndex = 8;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = false;
            bt_8.Click += bt_8_Click;
            // 
            // bt_3
            // 
            bt_3.BackColor = Color.FromArgb(45, 45, 45);
            bt_3.FlatStyle = FlatStyle.Popup;
            bt_3.Font = new Font("Segoe UI", 18F);
            bt_3.ForeColor = Color.White;
            bt_3.Location = new Point(180, 186);
            bt_3.Name = "bt_3";
            bt_3.Size = new Size(78, 56);
            bt_3.TabIndex = 13;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = false;
            bt_3.Click += bt_3_Click;
            // 
            // bt_6
            // 
            bt_6.BackColor = Color.FromArgb(45, 45, 45);
            bt_6.FlatStyle = FlatStyle.Popup;
            bt_6.Font = new Font("Segoe UI", 18F);
            bt_6.ForeColor = Color.White;
            bt_6.Location = new Point(180, 124);
            bt_6.Name = "bt_6";
            bt_6.Size = new Size(78, 56);
            bt_6.TabIndex = 12;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = false;
            bt_6.Click += bt_6_Click;
            // 
            // bt_9
            // 
            bt_9.BackColor = Color.FromArgb(45, 45, 45);
            bt_9.FlatStyle = FlatStyle.Popup;
            bt_9.Font = new Font("Segoe UI", 18F);
            bt_9.ForeColor = Color.White;
            bt_9.Location = new Point(180, 62);
            bt_9.Name = "bt_9";
            bt_9.Size = new Size(78, 56);
            bt_9.TabIndex = 11;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = false;
            bt_9.Click += bt_9_Click;
            // 
            // bt_suma
            // 
            bt_suma.BackColor = Color.FromArgb(45, 45, 45);
            bt_suma.FlatStyle = FlatStyle.Popup;
            bt_suma.Font = new Font("Segoe UI", 18F);
            bt_suma.ForeColor = Color.FromArgb(115, 147, 179);
            bt_suma.Location = new Point(4, 124);
            bt_suma.Name = "bt_suma";
            bt_suma.Size = new Size(78, 56);
            bt_suma.TabIndex = 16;
            bt_suma.Text = "+";
            bt_suma.UseVisualStyleBackColor = false;
            bt_suma.Click += bt_suma_Click;
            // 
            // bt_resta
            // 
            bt_resta.BackColor = Color.FromArgb(45, 45, 45);
            bt_resta.FlatStyle = FlatStyle.Popup;
            bt_resta.Font = new Font("Segoe UI", 18F);
            bt_resta.ForeColor = Color.FromArgb(115, 147, 179);
            bt_resta.Location = new Point(4, 62);
            bt_resta.Name = "bt_resta";
            bt_resta.Size = new Size(78, 56);
            bt_resta.TabIndex = 15;
            bt_resta.Text = "-";
            bt_resta.UseVisualStyleBackColor = false;
            bt_resta.Click += bt_resta_Click;
            // 
            // bt_multiplicar
            // 
            bt_multiplicar.BackColor = Color.FromArgb(45, 45, 45);
            bt_multiplicar.FlatStyle = FlatStyle.Popup;
            bt_multiplicar.Font = new Font("Segoe UI", 18F);
            bt_multiplicar.ForeColor = Color.FromArgb(115, 147, 179);
            bt_multiplicar.Location = new Point(3, 0);
            bt_multiplicar.Name = "bt_multiplicar";
            bt_multiplicar.Size = new Size(78, 56);
            bt_multiplicar.TabIndex = 14;
            bt_multiplicar.Text = "*";
            bt_multiplicar.UseVisualStyleBackColor = false;
            bt_multiplicar.Click += bt_multiplicar_Click;
            // 
            // bt_punto
            // 
            bt_punto.BackColor = Color.FromArgb(45, 45, 45);
            bt_punto.FlatStyle = FlatStyle.Popup;
            bt_punto.Font = new Font("Segoe UI", 18F);
            bt_punto.ForeColor = Color.White;
            bt_punto.Location = new Point(180, 248);
            bt_punto.Name = "bt_punto";
            bt_punto.Size = new Size(78, 56);
            bt_punto.TabIndex = 17;
            bt_punto.Text = ".";
            bt_punto.UseVisualStyleBackColor = false;
            bt_punto.Click += bt_punto_Click;
            // 
            // bt_igual
            // 
            bt_igual.BackColor = Color.FromArgb(115, 147, 179);
            bt_igual.FlatStyle = FlatStyle.Popup;
            bt_igual.Font = new Font("Segoe UI", 18F);
            bt_igual.ForeColor = Color.White;
            bt_igual.Location = new Point(4, 186);
            bt_igual.Name = "bt_igual";
            bt_igual.Size = new Size(78, 118);
            bt_igual.TabIndex = 18;
            bt_igual.Text = "=";
            bt_igual.UseVisualStyleBackColor = false;
            bt_igual.Click += bt_igual_Click;
            // 
            // bt_0
            // 
            bt_0.BackColor = Color.FromArgb(45, 45, 45);
            bt_0.FlatStyle = FlatStyle.Popup;
            bt_0.Font = new Font("Segoe UI", 18F);
            bt_0.ForeColor = Color.White;
            bt_0.Location = new Point(12, 248);
            bt_0.Name = "bt_0";
            bt_0.Size = new Size(162, 56);
            bt_0.TabIndex = 19;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = false;
            bt_0.Click += bt_0_Click;
            // 
            // label_historial
            // 
            label_historial.AutoSize = true;
            label_historial.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_historial.ForeColor = Color.FromArgb(155, 155, 155);
            label_historial.Location = new Point(13, 41);
            label_historial.Name = "label_historial";
            label_historial.Size = new Size(26, 31);
            label_historial.TabIndex = 20;
            label_historial.Text = "0";
            label_historial.Click += label_historial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(355, 505);
            Controls.Add(panel_operadores);
            Controls.Add(panel_teclado);
            Controls.Add(panel_pantalla);
            ForeColor = Color.Snow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            panel_pantalla.ResumeLayout(false);
            panel_pantalla.PerformLayout();
            panel_teclado.ResumeLayout(false);
            panel_operadores.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_pantalla;
        private Panel panel_teclado;
        private Panel panel_operadores;
        private TextBox txt_resultados;
        private Button bt_eliminar;
        private Button bt_dividir;
        private Button bt_7;
        private Button bt_4;
        private Button bt_1;
        private Button bt_2;
        private Button bt_5;
        private Button bt_8;
        private Button bt_3;
        private Button bt_6;
        private Button bt_9;
        private Button bt_suma;
        private Button bt_resta;
        private Button bt_multiplicar;
        private Button bt_punto;
        private Button bt_igual;
        private Button bt_0;
        private Label label_historial;
    }
}