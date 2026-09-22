namespace SisPadoca
{
    partial class FrmProduto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            LblNCM = new Label();
            TbxNCM = new TextBox();
            BtnExcluir = new Button();
            CbxMedida = new ComboBox();
            PbxImagem = new PictureBox();
            TbxDescricao = new TextBox();
            LblDescricao = new Label();
            LblCodigoBarras = new Label();
            TbxCodigoBarra = new TextBox();
            LblMedida = new Label();
            LblLote = new Label();
            TbxLote = new TextBox();
            BtnEditar = new Button();
            BtnNovo = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ImgLista = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)PbxImagem).BeginInit();
            SuspendLayout();
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(253, 25);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 0;
            LblNCM.Text = "NCM";
            // 
            // TbxNCM
            // 
            TbxNCM.Location = new Point(253, 53);
            TbxNCM.Name = "TbxNCM";
            TbxNCM.Size = new Size(150, 31);
            TbxNCM.TabIndex = 1;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(317, 284);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(112, 34);
            BtnExcluir.TabIndex = 2;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // CbxMedida
            // 
            CbxMedida.FormattingEnabled = true;
            CbxMedida.Items.AddRange(new object[] { "unitário", "kilo", "dúzia" });
            CbxMedida.Location = new Point(444, 100);
            CbxMedida.Name = "CbxMedida";
            CbxMedida.Size = new Size(182, 33);
            CbxMedida.TabIndex = 3;
            // 
            // PbxImagem
            // 
            PbxImagem.Image = (Image)resources.GetObject("PbxImagem.Image");
            PbxImagem.Location = new Point(12, 12);
            PbxImagem.Name = "PbxImagem";
            PbxImagem.Size = new Size(235, 252);
            PbxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImagem.TabIndex = 4;
            PbxImagem.TabStop = false;
            // 
            // TbxDescricao
            // 
            TbxDescricao.Location = new Point(253, 124);
            TbxDescricao.Name = "TbxDescricao";
            TbxDescricao.Size = new Size(150, 31);
            TbxDescricao.TabIndex = 6;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(253, 96);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 5;
            LblDescricao.Text = "Descrição";
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(253, 163);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 7;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // TbxCodigoBarra
            // 
            TbxCodigoBarra.Location = new Point(253, 191);
            TbxCodigoBarra.Name = "TbxCodigoBarra";
            TbxCodigoBarra.Size = new Size(150, 31);
            TbxCodigoBarra.TabIndex = 8;
            // 
            // LblMedida
            // 
            LblMedida.AutoSize = true;
            LblMedida.Location = new Point(444, 74);
            LblMedida.Name = "LblMedida";
            LblMedida.Size = new Size(168, 25);
            LblMedida.TabIndex = 9;
            LblMedida.Text = "Unidade de medida";
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(444, 143);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 11;
            LblLote.Text = "Lote";
            // 
            // TbxLote
            // 
            TbxLote.Location = new Point(444, 171);
            TbxLote.Name = "TbxLote";
            TbxLote.Size = new Size(150, 31);
            TbxLote.TabIndex = 12;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(195, 284);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(112, 34);
            BtnEditar.TabIndex = 13;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(77, 284);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(112, 34);
            BtnNovo.TabIndex = 14;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(444, 284);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(112, 34);
            BtnLimpar.TabIndex = 15;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(562, 284);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(112, 34);
            BtnFechar.TabIndex = 16;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(710, 344);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnNovo);
            Controls.Add(BtnEditar);
            Controls.Add(TbxLote);
            Controls.Add(LblLote);
            Controls.Add(LblMedida);
            Controls.Add(TbxCodigoBarra);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TbxDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(PbxImagem);
            Controls.Add(CbxMedida);
            Controls.Add(BtnExcluir);
            Controls.Add(TbxNCM);
            Controls.Add(LblNCM);
            DoubleBuffered = true;
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)PbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNCM;
        private TextBox TbxNCM;
        private Button BtnExcluir;
        private ComboBox CbxMedida;
        private PictureBox PbxImagem;
        private TextBox TbxDescricao;
        private Label LblDescricao;
        private Label LblCodigoBarras;
        private TextBox TbxCodigoBarra;
        private Label LblMedida;
        private Label LblLote;
        private TextBox TbxLote;
        private Button BtnEditar;
        private Button BtnNovo;
        private Button BtnLimpar;
        private Button BtnFechar;
        private ImageList ImgLista;
    }
}