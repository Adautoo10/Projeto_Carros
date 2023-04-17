namespace Projeto_Carros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.chk_Venda = new System.Windows.Forms.CheckBox();
            this.chk_Aluguel = new System.Windows.Forms.CheckBox();
            this.chk_Roubo = new System.Windows.Forms.CheckBox();
            this.chk_sinistro = new System.Windows.Forms.CheckBox();
            this.chk_revisao = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.chk_Particular = new System.Windows.Forms.CheckBox();
            this.dgv_carros = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometragem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observações = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revisão = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sinistro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Roubo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Aluguel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Venda = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Particular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtKilometragem = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.cmb_combustivel = new System.Windows.Forms.ComboBox();
            this.cmb_Fabricante = new System.Windows.Forms.ComboBox();
            this.cmb_Cor = new System.Windows.Forms.ComboBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(997, 588);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(137, 41);
            this.btnFechar.TabIndex = 106;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(55, 588);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(137, 41);
            this.btnCadastrar.TabIndex = 105;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // chk_Venda
            // 
            this.chk_Venda.AutoSize = true;
            this.chk_Venda.Location = new System.Drawing.Point(780, 475);
            this.chk_Venda.Name = "chk_Venda";
            this.chk_Venda.Size = new System.Drawing.Size(15, 14);
            this.chk_Venda.TabIndex = 102;
            this.chk_Venda.UseCompatibleTextRendering = true;
            this.chk_Venda.UseVisualStyleBackColor = true;
            // 
            // chk_Aluguel
            // 
            this.chk_Aluguel.AutoSize = true;
            this.chk_Aluguel.Location = new System.Drawing.Point(780, 429);
            this.chk_Aluguel.Name = "chk_Aluguel";
            this.chk_Aluguel.Size = new System.Drawing.Size(15, 14);
            this.chk_Aluguel.TabIndex = 101;
            this.chk_Aluguel.UseCompatibleTextRendering = true;
            this.chk_Aluguel.UseVisualStyleBackColor = true;
            // 
            // chk_Roubo
            // 
            this.chk_Roubo.AutoSize = true;
            this.chk_Roubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Roubo.Location = new System.Drawing.Point(780, 381);
            this.chk_Roubo.Name = "chk_Roubo";
            this.chk_Roubo.Size = new System.Drawing.Size(15, 14);
            this.chk_Roubo.TabIndex = 100;
            this.chk_Roubo.UseCompatibleTextRendering = true;
            this.chk_Roubo.UseVisualStyleBackColor = true;
            // 
            // chk_sinistro
            // 
            this.chk_sinistro.AutoSize = true;
            this.chk_sinistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_sinistro.Location = new System.Drawing.Point(780, 336);
            this.chk_sinistro.Name = "chk_sinistro";
            this.chk_sinistro.Size = new System.Drawing.Size(15, 14);
            this.chk_sinistro.TabIndex = 99;
            this.chk_sinistro.UseCompatibleTextRendering = true;
            this.chk_sinistro.UseVisualStyleBackColor = true;
            // 
            // chk_revisao
            // 
            this.chk_revisao.AutoSize = true;
            this.chk_revisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_revisao.Location = new System.Drawing.Point(780, 288);
            this.chk_revisao.Name = "chk_revisao";
            this.chk_revisao.Size = new System.Drawing.Size(15, 14);
            this.chk_revisao.TabIndex = 98;
            this.chk_revisao.UseCompatibleTextRendering = true;
            this.chk_revisao.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(642, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 20);
            this.label17.TabIndex = 96;
            this.label17.Text = "Observações";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(656, 511);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 95;
            this.label16.Text = "Particular";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(656, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 94;
            this.label15.Text = "Venda";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(656, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 93;
            this.label14.Text = "Roubo/Furto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(656, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 92;
            this.label13.Text = "Aluguel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(656, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 91;
            this.label12.Text = "Sinistro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(656, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 90;
            this.label11.Text = "Revisão";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(636, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 89;
            this.label10.Text = "kilometragem";
            // 
            // txtChassi
            // 
            this.txtChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassi.Location = new System.Drawing.Point(232, 528);
            this.txtChassi.MaxLength = 17;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(376, 26);
            this.txtChassi.TabIndex = 88;
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(232, 392);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(376, 26);
            this.txtAno.TabIndex = 85;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(232, 250);
            this.txtModelo.MaxLength = 30;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(376, 26);
            this.txtModelo.TabIndex = 82;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(232, 165);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(103, 26);
            this.txtCodigo.TabIndex = 80;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Numero Do Chassi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Cor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Combustível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Código do Veículo";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(769, 225);
            this.txtObservacoes.MaxLength = 255;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(338, 26);
            this.txtObservacoes.TabIndex = 108;
            this.txtObservacoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacoes_KeyPress);
            // 
            // chk_Particular
            // 
            this.chk_Particular.AutoSize = true;
            this.chk_Particular.Location = new System.Drawing.Point(780, 516);
            this.chk_Particular.Name = "chk_Particular";
            this.chk_Particular.Size = new System.Drawing.Size(15, 14);
            this.chk_Particular.TabIndex = 109;
            this.chk_Particular.UseCompatibleTextRendering = true;
            this.chk_Particular.UseVisualStyleBackColor = true;
            // 
            // dgv_carros
            // 
            this.dgv_carros.AllowUserToOrderColumns = true;
            this.dgv_carros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Marca,
            this.Modelo,
            this.Fabricante,
            this.Tipo,
            this.Ano,
            this.Combustivel,
            this.Cor,
            this.Chassi,
            this.Kilometragem,
            this.Observações,
            this.Revisão,
            this.Sinistro,
            this.Roubo,
            this.Aluguel,
            this.Venda,
            this.Particular});
            this.dgv_carros.Location = new System.Drawing.Point(55, 649);
            this.dgv_carros.Name = "dgv_carros";
            this.dgv_carros.ReadOnly = true;
            this.dgv_carros.Size = new System.Drawing.Size(740, 262);
            this.dgv_carros.TabIndex = 110;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // Combustivel
            // 
            this.Combustivel.HeaderText = "Combustivel";
            this.Combustivel.Name = "Combustivel";
            this.Combustivel.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Chassi
            // 
            this.Chassi.HeaderText = "Chassi";
            this.Chassi.Name = "Chassi";
            this.Chassi.ReadOnly = true;
            // 
            // Kilometragem
            // 
            this.Kilometragem.HeaderText = "Km";
            this.Kilometragem.Name = "Kilometragem";
            this.Kilometragem.ReadOnly = true;
            // 
            // Observações
            // 
            this.Observações.HeaderText = "Observações";
            this.Observações.Name = "Observações";
            this.Observações.ReadOnly = true;
            // 
            // Revisão
            // 
            this.Revisão.HeaderText = "Revisão";
            this.Revisão.Name = "Revisão";
            this.Revisão.ReadOnly = true;
            // 
            // Sinistro
            // 
            this.Sinistro.HeaderText = "Sinistro";
            this.Sinistro.Name = "Sinistro";
            this.Sinistro.ReadOnly = true;
            // 
            // Roubo
            // 
            this.Roubo.HeaderText = "Roubo/Furto";
            this.Roubo.Name = "Roubo";
            this.Roubo.ReadOnly = true;
            // 
            // Aluguel
            // 
            this.Aluguel.HeaderText = "Aluguel";
            this.Aluguel.Name = "Aluguel";
            this.Aluguel.ReadOnly = true;
            // 
            // Venda
            // 
            this.Venda.HeaderText = "Venda";
            this.Venda.Name = "Venda";
            this.Venda.ReadOnly = true;
            // 
            // Particular
            // 
            this.Particular.HeaderText = "Particular";
            this.Particular.Name = "Particular";
            this.Particular.ReadOnly = true;
            // 
            // txtKilometragem
            // 
            this.txtKilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometragem.Location = new System.Drawing.Point(769, 165);
            this.txtKilometragem.MaxLength = 9;
            this.txtKilometragem.Name = "txtKilometragem";
            this.txtKilometragem.Size = new System.Drawing.Size(338, 26);
            this.txtKilometragem.TabIndex = 97;
            this.txtKilometragem.TextChanged += new System.EventHandler(this.txtKilometragem_TextChanged);
            this.txtKilometragem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilometragem_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label18.Location = new System.Drawing.Point(209, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(858, 75);
            this.label18.TabIndex = 111;
            this.label18.Text = "CADASTRO DE VEÍCULOS";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(817, 588);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(137, 41);
            this.btnRemover.TabIndex = 112;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExportar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(198, 588);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(137, 41);
            this.btnExportar.TabIndex = 113;
            this.btnExportar.Text = "Exportar Dados";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cmb_combustivel
            // 
            this.cmb_combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_combustivel.FormattingEnabled = true;
            this.cmb_combustivel.Items.AddRange(new object[] {
            "Gasolina comum.",
            "Gasolina aditivada.",
            "Gasolina premium.",
            "Gasolina formulada.",
            "Etanol.",
            "Etanol aditivado.",
            "Diesel."});
            this.cmb_combustivel.Location = new System.Drawing.Point(232, 439);
            this.cmb_combustivel.Name = "cmb_combustivel";
            this.cmb_combustivel.Size = new System.Drawing.Size(376, 24);
            this.cmb_combustivel.TabIndex = 115;
            // 
            // cmb_Fabricante
            // 
            this.cmb_Fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Fabricante.FormattingEnabled = true;
            this.cmb_Fabricante.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Chevrolet",
            "Citroen",
            "Fiat",
            "Ferrari",
            "Ford",
            "Honda",
            "Hyundai",
            "Jaguar",
            "Jeep",
            "Lamborghini",
            "Land Rover",
            "Mercedes-Benz",
            "Nissan",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagem"});
            this.cmb_Fabricante.Location = new System.Drawing.Point(232, 301);
            this.cmb_Fabricante.Name = "cmb_Fabricante";
            this.cmb_Fabricante.Size = new System.Drawing.Size(376, 24);
            this.cmb_Fabricante.TabIndex = 116;
            // 
            // cmb_Cor
            // 
            this.cmb_Cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cor.FormattingEnabled = true;
            this.cmb_Cor.Items.AddRange(new object[] {
            "Branco.",
            "Cinza.",
            "Preto.",
            "Prata.",
            "Azul.",
            "Vermelho.",
            "Marrom/Bege.",
            "Verde.",
            "Amarelo."});
            this.cmb_Cor.Location = new System.Drawing.Point(232, 482);
            this.cmb_Cor.MaxLength = 255;
            this.cmb_Cor.Name = "cmb_Cor";
            this.cmb_Cor.Size = new System.Drawing.Size(376, 24);
            this.cmb_Cor.TabIndex = 117;
            // 
            // txt_marca
            // 
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(232, 210);
            this.txt_marca.MaxLength = 30;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(376, 26);
            this.txt_marca.TabIndex = 119;
            this.txt_marca.TextChanged += new System.EventHandler(this.txt_marca_TextChanged);
            this.txt_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_marca_KeyPress);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "------Veículo por tração------",
            "Automotor;",
            "Elétrico;",
            "De propulsão humana;",
            "De tração animal;",
            "Reboque ou semi-reboque;",
            " ",
            "------Veículo de passageiros------",
            "Bicicleta;",
            "Ciclomotor;",
            "Motoneta;",
            "Motocicleta;",
            "Triciclo;",
            "Quadriciclo;",
            "Automóvel;",
            "Microônibus;",
            "Ônibus;",
            "Bonde;",
            "Reboque ou semi-reboque;",
            "Charrete.",
            "",
            "------Veículo de carga------",
            "Motoneta;",
            "Motocicleta;",
            "Triciclo;",
            "Quadriciclo;",
            "Caminhonete;",
            "Caminhão;",
            "Reboque ou semi-reboque;",
            " ",
            "------Veículo Misto------",
            "Camioneta;",
            "Utilitário.",
            " ",
            "------Veículo de tração------",
            "Caminhão-trator;",
            "Trator de rodas;",
            "Trator de esteiras;",
            "Trator misto;",
            "Especial;",
            "De coleção."});
            this.cmbTipo.Location = new System.Drawing.Point(232, 346);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(376, 24);
            this.cmbTipo.TabIndex = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 923);
            this.ControlBox = false;
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.cmb_Cor);
            this.Controls.Add(this.cmb_Fabricante);
            this.Controls.Add(this.cmb_combustivel);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dgv_carros);
            this.Controls.Add(this.chk_Particular);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chk_Venda);
            this.Controls.Add(this.chk_Aluguel);
            this.Controls.Add(this.chk_Roubo);
            this.Controls.Add(this.chk_sinistro);
            this.Controls.Add(this.chk_revisao);
            this.Controls.Add(this.txtKilometragem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concessionária";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox chk_Venda;
        internal System.Windows.Forms.CheckBox chk_Aluguel;
        internal System.Windows.Forms.CheckBox chk_Roubo;
        internal System.Windows.Forms.CheckBox chk_sinistro;
        internal System.Windows.Forms.CheckBox chk_revisao;
        private System.Windows.Forms.TextBox txtObservacoes;
        internal System.Windows.Forms.CheckBox chk_Particular;
        private System.Windows.Forms.DataGridView dgv_carros;
        private System.Windows.Forms.TextBox txtKilometragem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometragem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observações;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Revisão;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sinistro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Roubo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aluguel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Venda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Particular;
        private System.Windows.Forms.ComboBox cmb_combustivel;
        private System.Windows.Forms.ComboBox cmb_Fabricante;
        private System.Windows.Forms.ComboBox cmb_Cor;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

