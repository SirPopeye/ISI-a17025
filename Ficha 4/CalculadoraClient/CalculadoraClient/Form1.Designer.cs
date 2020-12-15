
namespace CalculadoraClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.TextBox();
            this.yValue = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.adicaoButton = new System.Windows.Forms.Button();
            this.subtracaoButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.powButton = new System.Windows.Forms.Button();
            this.absButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.Location = new System.Drawing.Point(339, 82);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(0, 25);
            this.resultLable.TabIndex = 3;
            // 
            // xValue
            // 
            this.xValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValue.Location = new System.Drawing.Point(112, 57);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(100, 30);
            this.xValue.TabIndex = 4;
            // 
            // yValue
            // 
            this.yValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValue.Location = new System.Drawing.Point(112, 98);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(100, 30);
            this.yValue.TabIndex = 5;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(358, 79);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(100, 30);
            this.resultTextBox.TabIndex = 6;
            // 
            // adicaoButton
            // 
            this.adicaoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicaoButton.Location = new System.Drawing.Point(40, 175);
            this.adicaoButton.Name = "adicaoButton";
            this.adicaoButton.Size = new System.Drawing.Size(103, 33);
            this.adicaoButton.TabIndex = 7;
            this.adicaoButton.Text = "Adição";
            this.adicaoButton.UseVisualStyleBackColor = true;
            this.adicaoButton.Click += new System.EventHandler(this.adicaoButton_Click);
            // 
            // subtracaoButton
            // 
            this.subtracaoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracaoButton.Location = new System.Drawing.Point(171, 175);
            this.subtracaoButton.Name = "subtracaoButton";
            this.subtracaoButton.Size = new System.Drawing.Size(137, 33);
            this.subtracaoButton.TabIndex = 8;
            this.subtracaoButton.Text = "Subtração";
            this.subtracaoButton.UseVisualStyleBackColor = true;
            this.subtracaoButton.Click += new System.EventHandler(this.subtracaoButton_Click);
            // 
            // divButton
            // 
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButton.Location = new System.Drawing.Point(40, 233);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(103, 33);
            this.divButton.TabIndex = 9;
            this.divButton.Text = "Divisão";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // factButton
            // 
            this.factButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factButton.Location = new System.Drawing.Point(171, 233);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(137, 33);
            this.factButton.TabIndex = 10;
            this.factButton.Text = "Factorial";
            this.factButton.UseVisualStyleBackColor = true;
            this.factButton.Click += new System.EventHandler(this.factButton_Click);
            // 
            // powButton
            // 
            this.powButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powButton.Location = new System.Drawing.Point(333, 233);
            this.powButton.Name = "powButton";
            this.powButton.Size = new System.Drawing.Size(149, 33);
            this.powButton.TabIndex = 11;
            this.powButton.Text = "Potência";
            this.powButton.UseVisualStyleBackColor = true;
            this.powButton.Click += new System.EventHandler(this.powButton_Click);
            // 
            // absButton
            // 
            this.absButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absButton.Location = new System.Drawing.Point(153, 287);
            this.absButton.Name = "absButton";
            this.absButton.Size = new System.Drawing.Size(171, 33);
            this.absButton.TabIndex = 12;
            this.absButton.Text = "Valor Absoluto";
            this.absButton.UseVisualStyleBackColor = true;
            this.absButton.Click += new System.EventHandler(this.absButton_Click);
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multButton.Location = new System.Drawing.Point(333, 175);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(149, 33);
            this.multButton.TabIndex = 13;
            this.multButton.Text = "Multiplicação";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 343);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.absButton);
            this.Controls.Add(this.powButton);
            this.Controls.Add(this.factButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.subtracaoButton);
            this.Controls.Add(this.adicaoButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button adicaoButton;
        private System.Windows.Forms.Button subtracaoButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button factButton;
        private System.Windows.Forms.Button powButton;
        private System.Windows.Forms.Button absButton;
        private System.Windows.Forms.Button multButton;
    }
}

