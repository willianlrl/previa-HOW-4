namespace Agenda_Light
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_compromisso = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.fdsf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.MaskedTextBox();
            this.txt_hora = new System.Windows.Forms.MaskedTextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(160, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compromisso";
            // 
            // txt_compromisso
            // 
            this.txt_compromisso.Location = new System.Drawing.Point(237, 130);
            this.txt_compromisso.Name = "txt_compromisso";
            this.txt_compromisso.Size = new System.Drawing.Size(284, 20);
            this.txt_compromisso.TabIndex = 1;
            this.txt_compromisso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(163, 72);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // fdsf
            // 
            this.fdsf.AutoSize = true;
            this.fdsf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fdsf.Location = new System.Drawing.Point(199, 156);
            this.fdsf.Name = "fdsf";
            this.fdsf.Size = new System.Drawing.Size(32, 15);
            this.fdsf.TabIndex = 3;
            this.fdsf.Text = "Data";
            this.fdsf.Click += new System.EventHandler(this.Data_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(196, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local";
            // 
            // txt_local
            // 
            this.txt_local.Location = new System.Drawing.Point(237, 182);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(284, 20);
            this.txt_local.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(440, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horário";
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(237, 156);
            this.txt_dia.Mask = "00/00/0000";
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(72, 20);
            this.txt_dia.TabIndex = 8;
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(489, 156);
            this.txt_hora.Mask = "00:00";
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(33, 20);
            this.txt_hora.TabIndex = 9;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(245, 72);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 10;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(326, 72);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(408, 72);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 12;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(490, 72);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 13;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(185, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contato";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_contato
            // 
            this.txt_contato.Location = new System.Drawing.Point(237, 208);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(284, 20);
            this.txt_contato.TabIndex = 15;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_local);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fdsf);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_compromisso);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.addfuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_compromisso;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label fdsf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_dia;
        private System.Windows.Forms.MaskedTextBox txt_hora;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_contato;
    }
}