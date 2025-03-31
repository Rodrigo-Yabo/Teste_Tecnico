namespace Teste_tecnico.Viewers
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.BtnAdicionarCad = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.DtGridList = new System.Windows.Forms.DataGridView();
            this.iManipulaInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iManipulaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iManipulaInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iManipulaInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iManipulaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iManipulaInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdicionarCad
            // 
            this.BtnAdicionarCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarCad.Location = new System.Drawing.Point(598, 131);
            this.BtnAdicionarCad.Name = "BtnAdicionarCad";
            this.BtnAdicionarCad.Size = new System.Drawing.Size(131, 68);
            this.BtnAdicionarCad.TabIndex = 1;
            this.BtnAdicionarCad.Text = "Adicionar Novo Cadastro";
            this.BtnAdicionarCad.UseVisualStyleBackColor = true;
            this.BtnAdicionarCad.Click += new System.EventHandler(this.BtnAdicionarCad_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(598, 205);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(131, 68);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemover.Location = new System.Drawing.Point(598, 279);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(131, 68);
            this.BtnRemover.TabIndex = 3;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(598, 353);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(131, 68);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DtGridList
            // 
            this.DtGridList.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridList.Location = new System.Drawing.Point(12, 22);
            this.DtGridList.Name = "DtGridList";
            this.DtGridList.Size = new System.Drawing.Size(538, 399);
            this.DtGridList.TabIndex = 5;
            // 
            // iManipulaInfoBindingSource2
            // 
            this.iManipulaInfoBindingSource2.DataSource = typeof(Teste_tecnico.Controllers.Factory.IManipulaInfo);
            // 
            // iManipulaInfoBindingSource
            // 
            this.iManipulaInfoBindingSource.DataSource = typeof(Teste_tecnico.Controllers.Factory.IManipulaInfo);
            // 
            // iManipulaInfoBindingSource1
            // 
            this.iManipulaInfoBindingSource1.DataSource = typeof(Teste_tecnico.Controllers.Factory.IManipulaInfo);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtGridList);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAdicionarCad);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iManipulaInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iManipulaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iManipulaInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAdicionarCad;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.BindingSource iManipulaInfoBindingSource;
        private System.Windows.Forms.BindingSource iManipulaInfoBindingSource1;
        private System.Windows.Forms.BindingSource iManipulaInfoBindingSource2;
        private System.Windows.Forms.DataGridView DtGridList;
    }
}