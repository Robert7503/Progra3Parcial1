﻿
namespace Ejercicio_1_Progra3Parcial1
{
    partial class Funciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox2 = new System.Windows.Forms.TextBox();
            this.SumaButton = new System.Windows.Forms.Button();
            this.RestaButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.DividirButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Numero2TextBox2);
            this.groupBox1.Controls.Add(this.Numero1TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarButton);
            this.groupBox2.Controls.Add(this.DividirButton);
            this.groupBox2.Controls.Add(this.MultiplicarButton);
            this.groupBox2.Controls.Add(this.RestaButton);
            this.groupBox2.Controls.Add(this.SumaButton);
            this.groupBox2.Location = new System.Drawing.Point(355, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultadoLabel);
            this.groupBox3.Location = new System.Drawing.Point(30, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 2:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(88, 31);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(214, 20);
            this.Numero1TextBox.TabIndex = 1;
            // 
            // Numero2TextBox2
            // 
            this.Numero2TextBox2.Location = new System.Drawing.Point(88, 86);
            this.Numero2TextBox2.Name = "Numero2TextBox2";
            this.Numero2TextBox2.Size = new System.Drawing.Size(214, 20);
            this.Numero2TextBox2.TabIndex = 1;
            // 
            // SumaButton
            // 
            this.SumaButton.Location = new System.Drawing.Point(19, 25);
            this.SumaButton.Name = "SumaButton";
            this.SumaButton.Size = new System.Drawing.Size(106, 26);
            this.SumaButton.TabIndex = 0;
            this.SumaButton.Text = "Suma";
            this.SumaButton.UseVisualStyleBackColor = true;
            this.SumaButton.Click += new System.EventHandler(this.SumaButton_Click);
            // 
            // RestaButton
            // 
            this.RestaButton.Location = new System.Drawing.Point(203, 25);
            this.RestaButton.Name = "RestaButton";
            this.RestaButton.Size = new System.Drawing.Size(106, 26);
            this.RestaButton.TabIndex = 0;
            this.RestaButton.Text = "Resta";
            this.RestaButton.UseVisualStyleBackColor = true;
            this.RestaButton.Click += new System.EventHandler(this.RestaButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Location = new System.Drawing.Point(19, 73);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(106, 26);
            this.MultiplicarButton.TabIndex = 0;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // DividirButton
            // 
            this.DividirButton.Location = new System.Drawing.Point(203, 73);
            this.DividirButton.Name = "DividirButton";
            this.DividirButton.Size = new System.Drawing.Size(106, 26);
            this.DividirButton.TabIndex = 0;
            this.DividirButton.Text = "Dividir";
            this.DividirButton.UseVisualStyleBackColor = true;
            this.DividirButton.Click += new System.EventHandler(this.DividirButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(115, 105);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(106, 26);
            this.LimpiarButton.TabIndex = 0;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(286, 50);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(79, 16);
            this.ResultadoLabel.TabIndex = 0;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Funciones";
            this.Text = "Funciones y Procedimientos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Numero2TextBox2;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button DividirButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.Button RestaButton;
        private System.Windows.Forms.Button SumaButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}

