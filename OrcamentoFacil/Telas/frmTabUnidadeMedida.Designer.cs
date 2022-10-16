
namespace OrcamentoFacil
{
    partial class frmTabUnidadeMedida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtGridUnidadeMedida = new System.Windows.Forms.DataGridView();
            this.IdUnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnidadeMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // txtSigla
            // 
            this.txtSigla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtSigla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSigla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.ForeColor = System.Drawing.Color.White;
            this.txtSigla.Location = new System.Drawing.Point(15, 38);
            this.txtSigla.MaxLength = 3;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(94, 19);
            this.txtSigla.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(159, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(695, 19);
            this.txtDescricao.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 458);
            this.dataGridView1.TabIndex = 6;
            // 
            // dtGridUnidadeMedida
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Olive;
            this.dtGridUnidadeMedida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridUnidadeMedida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtGridUnidadeMedida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtGridUnidadeMedida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.dtGridUnidadeMedida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridUnidadeMedida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridUnidadeMedida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridUnidadeMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUnidadeMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUnidadeMedida,
            this.descricao,
            this.sigla});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridUnidadeMedida.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridUnidadeMedida.Location = new System.Drawing.Point(14, 63);
            this.dtGridUnidadeMedida.MultiSelect = false;
            this.dtGridUnidadeMedida.Name = "dtGridUnidadeMedida";
            this.dtGridUnidadeMedida.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridUnidadeMedida.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dtGridUnidadeMedida.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGridUnidadeMedida.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.dtGridUnidadeMedida.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F);
            this.dtGridUnidadeMedida.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridUnidadeMedida.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dtGridUnidadeMedida.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtGridUnidadeMedida.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridUnidadeMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridUnidadeMedida.Size = new System.Drawing.Size(839, 458);
            this.dtGridUnidadeMedida.TabIndex = 7;
            this.dtGridUnidadeMedida.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUnidadeMedida_RowEnter);
            // 
            // IdUnidadeMedida
            // 
            this.IdUnidadeMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdUnidadeMedida.DataPropertyName = "IdUnidadeMedida";
            this.IdUnidadeMedida.FillWeight = 10F;
            this.IdUnidadeMedida.HeaderText = "Código";
            this.IdUnidadeMedida.MinimumWidth = 10;
            this.IdUnidadeMedida.Name = "IdUnidadeMedida";
            this.IdUnidadeMedida.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.FillWeight = 300F;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 500;
            // 
            // sigla
            // 
            this.sigla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sigla.DataPropertyName = "sigla";
            this.sigla.HeaderText = "Sigla";
            this.sigla.Name = "sigla";
            this.sigla.ReadOnly = true;
            this.sigla.Width = 200;
            // 
            // frmTabUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(866, 533);
            this.ControlBox = false;
            this.Controls.Add(this.dtGridUnidadeMedida);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTabUnidadeMedida";
            this.Text = "frmTabUnidadeMedida";
            this.Load += new System.EventHandler(this.frmTabUnidadeMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnidadeMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dtGridUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
    }
}