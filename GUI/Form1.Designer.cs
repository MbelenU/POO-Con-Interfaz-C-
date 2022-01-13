
namespace GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.agregarButton = new System.Windows.Forms.Button();
            this.pagarButton = new System.Windows.Forms.Button();
            this.asignarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteTextBox.Location = new System.Drawing.Point(70, 14);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(401, 23);
            this.clienteTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(44, 43);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionTextBox.Location = new System.Drawing.Point(228, 43);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(324, 23);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(70, 72);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 23);
            this.precioTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(250, 72);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 23);
            this.cantidadTextBox.TabIndex = 9;
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Location = new System.Drawing.Point(21, 108);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.RowTemplate.Height = 25;
            this.detalleDataGridView.Size = new System.Drawing.Size(535, 159);
            this.detalleDataGridView.TabIndex = 10;
            // 
            // agregarButton
            // 
            this.agregarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarButton.Location = new System.Drawing.Point(396, 72);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 11;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // pagarButton
            // 
            this.pagarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pagarButton.Location = new System.Drawing.Point(477, 72);
            this.pagarButton.Name = "pagarButton";
            this.pagarButton.Size = new System.Drawing.Size(75, 23);
            this.pagarButton.TabIndex = 12;
            this.pagarButton.Text = "Pagar";
            this.pagarButton.UseVisualStyleBackColor = true;
            this.pagarButton.Click += new System.EventHandler(this.pagarButton_Click);
            // 
            // asignarButton
            // 
            this.asignarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asignarButton.Location = new System.Drawing.Point(477, 12);
            this.asignarButton.Name = "asignarButton";
            this.asignarButton.Size = new System.Drawing.Size(75, 23);
            this.asignarButton.TabIndex = 13;
            this.asignarButton.Text = "Asignar";
            this.asignarButton.UseVisualStyleBackColor = true;
            this.asignarButton.Click += new System.EventHandler(this.asignarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 288);
            this.Controls.Add(this.asignarButton);
            this.Controls.Add(this.pagarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.detalleDataGridView);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button pagarButton;
        private System.Windows.Forms.Button asignarButton;
    }
}

