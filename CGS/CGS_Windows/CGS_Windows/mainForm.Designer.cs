namespace CGS_Windows
{
    partial class mainForm
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addCuratorButton = new System.Windows.Forms.Button();
            this.saveCuratorButton = new System.Windows.Forms.Button();
            this.curatorViewButton = new System.Windows.Forms.Button();
            this.curatorIDBox = new System.Windows.Forms.TextBox();
            this.curatorFirstNameBox = new System.Windows.Forms.TextBox();
            this.curatorLastNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveArtistButton = new System.Windows.Forms.Button();
            this.viewArtistButton = new System.Windows.Forms.Button();
            this.addArtistButton = new System.Windows.Forms.Button();
            this.artistIDBox = new System.Windows.Forms.TextBox();
            this.artistLastNameBox = new System.Windows.Forms.TextBox();
            this.artistFirstNameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.artPieceSaveBox = new System.Windows.Forms.Button();
            this.btn_ListPieces = new System.Windows.Forms.Button();
            this.btn_SellArtPiece = new System.Windows.Forms.Button();
            this.btn_AddArtPiece = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CuratorIDTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ArtistIDTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(4, 9);
            this.tab.Margin = new System.Windows.Forms.Padding(2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(382, 275);
            this.tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.addCuratorButton);
            this.tabPage1.Controls.Add(this.saveCuratorButton);
            this.tabPage1.Controls.Add(this.curatorViewButton);
            this.tabPage1.Controls.Add(this.curatorIDBox);
            this.tabPage1.Controls.Add(this.curatorFirstNameBox);
            this.tabPage1.Controls.Add(this.curatorLastNameBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(374, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Curators";
            // 
            // addCuratorButton
            // 
            this.addCuratorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addCuratorButton.Location = new System.Drawing.Point(260, 128);
            this.addCuratorButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCuratorButton.Name = "addCuratorButton";
            this.addCuratorButton.Size = new System.Drawing.Size(105, 29);
            this.addCuratorButton.TabIndex = 4;
            this.addCuratorButton.Text = "Add Curator";
            this.addCuratorButton.UseVisualStyleBackColor = false;
            this.addCuratorButton.Click += new System.EventHandler(this.btn_AddCur_Click);
            // 
            // saveCuratorButton
            // 
            this.saveCuratorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveCuratorButton.Location = new System.Drawing.Point(260, 162);
            this.saveCuratorButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveCuratorButton.Name = "saveCuratorButton";
            this.saveCuratorButton.Size = new System.Drawing.Size(105, 29);
            this.saveCuratorButton.TabIndex = 5;
            this.saveCuratorButton.Text = "Save Curator";
            this.saveCuratorButton.UseVisualStyleBackColor = false;
            this.saveCuratorButton.Click += new System.EventHandler(this.btn_SaveCur_Click);
            // 
            // curatorViewButton
            // 
            this.curatorViewButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.curatorViewButton.Location = new System.Drawing.Point(260, 208);
            this.curatorViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.curatorViewButton.Name = "curatorViewButton";
            this.curatorViewButton.Size = new System.Drawing.Size(105, 29);
            this.curatorViewButton.TabIndex = 6;
            this.curatorViewButton.Text = "View Curators";
            this.curatorViewButton.UseVisualStyleBackColor = false;
            this.curatorViewButton.Click += new System.EventHandler(this.btn_ViewCur_Click);
            // 
            // curatorIDBox
            // 
            this.curatorIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curatorIDBox.Location = new System.Drawing.Point(105, 111);
            this.curatorIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.curatorIDBox.Name = "curatorIDBox";
            this.curatorIDBox.Size = new System.Drawing.Size(108, 23);
            this.curatorIDBox.TabIndex = 3;
            // 
            // curatorFirstNameBox
            // 
            this.curatorFirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curatorFirstNameBox.Location = new System.Drawing.Point(105, 50);
            this.curatorFirstNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.curatorFirstNameBox.Multiline = true;
            this.curatorFirstNameBox.Name = "curatorFirstNameBox";
            this.curatorFirstNameBox.Size = new System.Drawing.Size(108, 22);
            this.curatorFirstNameBox.TabIndex = 1;
            // 
            // curatorLastNameBox
            // 
            this.curatorLastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curatorLastNameBox.Location = new System.Drawing.Point(105, 81);
            this.curatorLastNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.curatorLastNameBox.Name = "curatorLastNameBox";
            this.curatorLastNameBox.Size = new System.Drawing.Size(108, 23);
            this.curatorLastNameBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Curator Information:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.saveArtistButton);
            this.tabPage2.Controls.Add(this.viewArtistButton);
            this.tabPage2.Controls.Add(this.addArtistButton);
            this.tabPage2.Controls.Add(this.artistIDBox);
            this.tabPage2.Controls.Add(this.artistLastNameBox);
            this.tabPage2.Controls.Add(this.artistFirstNameBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(374, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artists";
            // 
            // saveArtistButton
            // 
            this.saveArtistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveArtistButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveArtistButton.Location = new System.Drawing.Point(252, 176);
            this.saveArtistButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveArtistButton.Name = "saveArtistButton";
            this.saveArtistButton.Size = new System.Drawing.Size(92, 29);
            this.saveArtistButton.TabIndex = 8;
            this.saveArtistButton.Text = "Save Artist";
            this.saveArtistButton.UseVisualStyleBackColor = true;
            this.saveArtistButton.Click += new System.EventHandler(this.saveArtistButton_Click);
            // 
            // viewArtistButton
            // 
            this.viewArtistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewArtistButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewArtistButton.Location = new System.Drawing.Point(252, 210);
            this.viewArtistButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewArtistButton.Name = "viewArtistButton";
            this.viewArtistButton.Size = new System.Drawing.Size(92, 29);
            this.viewArtistButton.TabIndex = 5;
            this.viewArtistButton.Text = "View Artists";
            this.viewArtistButton.UseVisualStyleBackColor = true;
            this.viewArtistButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addArtistButton
            // 
            this.addArtistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArtistButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addArtistButton.Location = new System.Drawing.Point(252, 143);
            this.addArtistButton.Margin = new System.Windows.Forms.Padding(2);
            this.addArtistButton.Name = "addArtistButton";
            this.addArtistButton.Size = new System.Drawing.Size(92, 29);
            this.addArtistButton.TabIndex = 4;
            this.addArtistButton.Text = "Add Artist";
            this.addArtistButton.UseVisualStyleBackColor = true;
            this.addArtistButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // artistIDBox
            // 
            this.artistIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artistIDBox.Location = new System.Drawing.Point(105, 110);
            this.artistIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.artistIDBox.Multiline = true;
            this.artistIDBox.Name = "artistIDBox";
            this.artistIDBox.Size = new System.Drawing.Size(127, 23);
            this.artistIDBox.TabIndex = 3;
            // 
            // artistLastNameBox
            // 
            this.artistLastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artistLastNameBox.Location = new System.Drawing.Point(105, 81);
            this.artistLastNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.artistLastNameBox.Multiline = true;
            this.artistLastNameBox.Name = "artistLastNameBox";
            this.artistLastNameBox.Size = new System.Drawing.Size(127, 23);
            this.artistLastNameBox.TabIndex = 2;
            // 
            // artistFirstNameBox
            // 
            this.artistFirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artistFirstNameBox.Location = new System.Drawing.Point(105, 51);
            this.artistFirstNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.artistFirstNameBox.Multiline = true;
            this.artistFirstNameBox.Name = "artistFirstNameBox";
            this.artistFirstNameBox.Size = new System.Drawing.Size(127, 23);
            this.artistFirstNameBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(17, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(17, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Last name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(17, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "First name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(16, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Artist Information:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage3.Controls.Add(this.artPieceSaveBox);
            this.tabPage3.Controls.Add(this.btn_ListPieces);
            this.tabPage3.Controls.Add(this.btn_SellArtPiece);
            this.tabPage3.Controls.Add(this.btn_AddArtPiece);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.CuratorIDTextBox);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.ArtistIDTextBox);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.ValueTextBox);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.YearTextBox);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.TitleTextBox);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.IDTextBox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(374, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Art Pieces";
            // 
            // artPieceSaveBox
            // 
            this.artPieceSaveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artPieceSaveBox.Location = new System.Drawing.Point(239, 181);
            this.artPieceSaveBox.Margin = new System.Windows.Forms.Padding(2);
            this.artPieceSaveBox.Name = "artPieceSaveBox";
            this.artPieceSaveBox.Size = new System.Drawing.Size(106, 26);
            this.artPieceSaveBox.TabIndex = 16;
            this.artPieceSaveBox.Text = "Save Pieces";
            this.artPieceSaveBox.UseVisualStyleBackColor = true;
            this.artPieceSaveBox.Click += new System.EventHandler(this.artPieceSaveBox_Click);
            // 
            // btn_ListPieces
            // 
            this.btn_ListPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListPieces.Location = new System.Drawing.Point(239, 211);
            this.btn_ListPieces.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ListPieces.Name = "btn_ListPieces";
            this.btn_ListPieces.Size = new System.Drawing.Size(106, 26);
            this.btn_ListPieces.TabIndex = 15;
            this.btn_ListPieces.Text = "List Pieces";
            this.btn_ListPieces.UseVisualStyleBackColor = true;
            this.btn_ListPieces.Click += new System.EventHandler(this.btn_ListPieces_Click);
            // 
            // btn_SellArtPiece
            // 
            this.btn_SellArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SellArtPiece.Location = new System.Drawing.Point(240, 152);
            this.btn_SellArtPiece.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SellArtPiece.Name = "btn_SellArtPiece";
            this.btn_SellArtPiece.Size = new System.Drawing.Size(106, 26);
            this.btn_SellArtPiece.TabIndex = 14;
            this.btn_SellArtPiece.Text = "Sell Art Piece";
            this.btn_SellArtPiece.UseVisualStyleBackColor = true;
            this.btn_SellArtPiece.Click += new System.EventHandler(this.btn_SellArtPiece_Click);
            // 
            // btn_AddArtPiece
            // 
            this.btn_AddArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddArtPiece.Location = new System.Drawing.Point(240, 121);
            this.btn_AddArtPiece.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddArtPiece.Name = "btn_AddArtPiece";
            this.btn_AddArtPiece.Size = new System.Drawing.Size(106, 26);
            this.btn_AddArtPiece.TabIndex = 13;
            this.btn_AddArtPiece.Text = "Add Art Piece";
            this.btn_AddArtPiece.UseVisualStyleBackColor = true;
            this.btn_AddArtPiece.Click += new System.EventHandler(this.btn_AddArtPiece_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(223, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(124, 81);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 46);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "In Storage";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "On Display";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CuratorIDTextBox
            // 
            this.CuratorIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuratorIDTextBox.Location = new System.Drawing.Point(86, 184);
            this.CuratorIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CuratorIDTextBox.Multiline = true;
            this.CuratorIDTextBox.Name = "CuratorIDTextBox";
            this.CuratorIDTextBox.Size = new System.Drawing.Size(122, 23);
            this.CuratorIDTextBox.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 191);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "Curator ID:";
            // 
            // ArtistIDTextBox
            // 
            this.ArtistIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArtistIDTextBox.Location = new System.Drawing.Point(86, 157);
            this.ArtistIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ArtistIDTextBox.Multiline = true;
            this.ArtistIDTextBox.Name = "ArtistIDTextBox";
            this.ArtistIDTextBox.Size = new System.Drawing.Size(122, 23);
            this.ArtistIDTextBox.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 163);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 9;
            this.label18.Text = "Artist ID:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueTextBox.Location = new System.Drawing.Point(86, 129);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValueTextBox.Multiline = true;
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(122, 23);
            this.ValueTextBox.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 136);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Value:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearTextBox.Location = new System.Drawing.Point(86, 102);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YearTextBox.Multiline = true;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(122, 23);
            this.YearTextBox.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 108);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Year:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTextBox.Location = new System.Drawing.Point(86, 74);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(122, 23);
            this.TitleTextBox.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 80);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Title:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Location = new System.Drawing.Point(86, 46);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(122, 23);
            this.IDTextBox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 53);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Art Piece Information:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox);
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.tab);
            this.groupBox1.Location = new System.Drawing.Point(9, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(512, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox2.Location = new System.Drawing.Point(0, 443);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(472, 26);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "Curators";
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox.Location = new System.Drawing.Point(16, 288);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(470, 125);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(391, 251);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(95, 32);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(9, 10);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(496, 25);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "File";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(524, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox curatorIDBox;
        private System.Windows.Forms.TextBox curatorFirstNameBox;
        private System.Windows.Forms.TextBox curatorLastNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCuratorButton;
        private System.Windows.Forms.Button saveCuratorButton;
        private System.Windows.Forms.Button curatorViewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button viewArtistButton;
        private System.Windows.Forms.Button addArtistButton;
        private System.Windows.Forms.TextBox artistIDBox;
        private System.Windows.Forms.TextBox artistLastNameBox;
        private System.Windows.Forms.TextBox artistFirstNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuratorIDTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ArtistIDTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_ListPieces;
        private System.Windows.Forms.Button btn_SellArtPiece;
        private System.Windows.Forms.Button btn_AddArtPiece;
        private System.Windows.Forms.Button saveArtistButton;
        private System.Windows.Forms.Button artPieceSaveBox;
    }
}