
namespace Cliente_Chat
{
    partial class Form1
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtmjs = new System.Windows.Forms.TextBox();
            this.btnenviarmsj = new System.Windows.Forms.Button();
            this.btnconectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(476, 184);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(232, 20);
            this.txtUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 394);
            this.listBox1.TabIndex = 2;
            // 
            // txtmjs
            // 
            this.txtmjs.Location = new System.Drawing.Point(422, 276);
            this.txtmjs.Name = "txtmjs";
            this.txtmjs.Size = new System.Drawing.Size(331, 20);
            this.txtmjs.TabIndex = 3;
            // 
            // btnenviarmsj
            // 
            this.btnenviarmsj.Location = new System.Drawing.Point(532, 302);
            this.btnenviarmsj.Name = "btnenviarmsj";
            this.btnenviarmsj.Size = new System.Drawing.Size(100, 27);
            this.btnenviarmsj.TabIndex = 4;
            this.btnenviarmsj.Text = "Enviar";
            this.btnenviarmsj.UseVisualStyleBackColor = true;
            this.btnenviarmsj.Click += new System.EventHandler(this.btnenviarmsj_Click);
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(532, 210);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(100, 29);
            this.btnconectar.TabIndex = 5;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chat Multiusuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.btnenviarmsj);
            this.Controls.Add(this.txtmjs);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtmjs;
        private System.Windows.Forms.Button btnenviarmsj;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

