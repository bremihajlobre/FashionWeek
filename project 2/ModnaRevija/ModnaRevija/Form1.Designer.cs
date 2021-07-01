namespace ModnaRevija
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
            this.btnDodajCasopis = new System.Windows.Forms.Button();
            this.btnLoadCasopis = new System.Windows.Forms.Button();
            this.btnDeleteCasopis = new System.Windows.Forms.Button();
            this.btnLoadInternacionlna = new System.Windows.Forms.Button();
            this.btnDelInternacionalna = new System.Windows.Forms.Button();
            this.btnAddKuce = new System.Windows.Forms.Button();
            this.btnLoadKuce = new System.Windows.Forms.Button();
            this.btnDelKuce = new System.Windows.Forms.Button();
            this.btnManyToOneSGostMRevija = new System.Windows.Forms.Button();
            this.btnOneToManyMRevijaToSGost = new System.Windows.Forms.Button();
            this.btnManyToOneZemljeToMAgencija = new System.Windows.Forms.Button();
            this.btnOneToManyInterToZemlje = new System.Windows.Forms.Button();
            this.btnManyToOneKuceToMKreator = new System.Windows.Forms.Button();
            this.btnOneToManyMKreatorToKuce = new System.Windows.Forms.Button();
            this.btnOneToManyManekenToCasopisi = new System.Windows.Forms.Button();
            this.btnManyToOneCasopisiToManeken = new System.Windows.Forms.Button();
            this.btnManyToManyManekenModnaRevija = new System.Windows.Forms.Button();
            this.btnManyToManyManekenModnaAgencija = new System.Windows.Forms.Button();
            this.btnAddManekenManyToMany = new System.Windows.Forms.Button();
            this.btnAddPredstavllja = new System.Windows.Forms.Button();
            this.btnAddManekenSpecijalizacija = new System.Windows.Forms.Button();
            this.btnAddInterModnaAgencija = new System.Windows.Forms.Button();
            this.btnUpdateCasopis = new System.Windows.Forms.Button();
            this.btnUpdateIntMAgencija = new System.Windows.Forms.Button();
            this.btnUpdateModnaKuca = new System.Windows.Forms.Button();
            this.btnUpdateManeken = new System.Windows.Forms.Button();
            this.brnLoadManeken = new System.Windows.Forms.Button();
            this.btnDelManeken = new System.Windows.Forms.Button();
            this.btnLoadModnaAgencija = new System.Windows.Forms.Button();
            this.btnDeleteModnaAgencija = new System.Windows.Forms.Button();
            this.btnUpdateModnaAgencija = new System.Windows.Forms.Button();
            this.btnAddModnaAgencija = new System.Windows.Forms.Button();
            this.btnDelModnaRevija = new System.Windows.Forms.Button();
            this.btnLoadModnaRevija = new System.Windows.Forms.Button();
            this.btnUpdateModnaRevija = new System.Windows.Forms.Button();
            this.btnAddModnaRevija = new System.Windows.Forms.Button();
            this.btnDelPredstavlja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdatePredstavlja = new System.Windows.Forms.Button();
            this.btnObrisiSpecijalnogGosta = new System.Windows.Forms.Button();
            this.btnLoadSpecijalniGost = new System.Windows.Forms.Button();
            this.btnUpdateSpecijalniGost = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDelZemlje = new System.Windows.Forms.Button();
            this.btnLoadZemlje = new System.Windows.Forms.Button();
            this.btnUpdateZemlje = new System.Windows.Forms.Button();
            this.btnAddZemlje = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateModniKreator = new System.Windows.Forms.Button();
            this.btnAddModniKreator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajCasopis
            // 
            this.btnDodajCasopis.Location = new System.Drawing.Point(43, 589);
            this.btnDodajCasopis.Name = "btnDodajCasopis";
            this.btnDodajCasopis.Size = new System.Drawing.Size(180, 23);
            this.btnDodajCasopis.TabIndex = 7;
            this.btnDodajCasopis.Text = "Dodaj casopis";
            this.btnDodajCasopis.UseVisualStyleBackColor = true;
            this.btnDodajCasopis.Click += new System.EventHandler(this.btnDodajCasopis_Click);
            // 
            // btnLoadCasopis
            // 
            this.btnLoadCasopis.Location = new System.Drawing.Point(43, 649);
            this.btnLoadCasopis.Name = "btnLoadCasopis";
            this.btnLoadCasopis.Size = new System.Drawing.Size(180, 23);
            this.btnLoadCasopis.TabIndex = 8;
            this.btnLoadCasopis.Text = "Ucitavanje casopisa";
            this.btnLoadCasopis.UseVisualStyleBackColor = true;
            this.btnLoadCasopis.Click += new System.EventHandler(this.btnLoadCasopis_Click);
            // 
            // btnDeleteCasopis
            // 
            this.btnDeleteCasopis.Location = new System.Drawing.Point(43, 678);
            this.btnDeleteCasopis.Name = "btnDeleteCasopis";
            this.btnDeleteCasopis.Size = new System.Drawing.Size(180, 23);
            this.btnDeleteCasopis.TabIndex = 9;
            this.btnDeleteCasopis.Text = "Brisanje casopisa";
            this.btnDeleteCasopis.UseVisualStyleBackColor = true;
            this.btnDeleteCasopis.Click += new System.EventHandler(this.btnDeleteCasopis_Click);
            // 
            // btnLoadInternacionlna
            // 
            this.btnLoadInternacionlna.Location = new System.Drawing.Point(256, 649);
            this.btnLoadInternacionlna.Name = "btnLoadInternacionlna";
            this.btnLoadInternacionlna.Size = new System.Drawing.Size(227, 23);
            this.btnLoadInternacionlna.TabIndex = 19;
            this.btnLoadInternacionlna.Text = "Ucitavanje internacionalne modne agencije";
            this.btnLoadInternacionlna.UseVisualStyleBackColor = true;
            this.btnLoadInternacionlna.Click += new System.EventHandler(this.btnLoadInternacionlna_Click);
            // 
            // btnDelInternacionalna
            // 
            this.btnDelInternacionalna.Location = new System.Drawing.Point(256, 678);
            this.btnDelInternacionalna.Name = "btnDelInternacionalna";
            this.btnDelInternacionalna.Size = new System.Drawing.Size(227, 23);
            this.btnDelInternacionalna.TabIndex = 21;
            this.btnDelInternacionalna.Text = "Brisanje internacionlne modne agencije";
            this.btnDelInternacionalna.UseVisualStyleBackColor = true;
            this.btnDelInternacionalna.Click += new System.EventHandler(this.btnDelInternacionalna_Click);
            // 
            // btnAddKuce
            // 
            this.btnAddKuce.Location = new System.Drawing.Point(509, 589);
            this.btnAddKuce.Name = "btnAddKuce";
            this.btnAddKuce.Size = new System.Drawing.Size(180, 23);
            this.btnAddKuce.TabIndex = 22;
            this.btnAddKuce.Text = "Dodaj modnu kucu kreatoru";
            this.btnAddKuce.UseVisualStyleBackColor = true;
            this.btnAddKuce.Click += new System.EventHandler(this.btnAddKuce_Click);
            // 
            // btnLoadKuce
            // 
            this.btnLoadKuce.Location = new System.Drawing.Point(509, 649);
            this.btnLoadKuce.Name = "btnLoadKuce";
            this.btnLoadKuce.Size = new System.Drawing.Size(180, 23);
            this.btnLoadKuce.TabIndex = 23;
            this.btnLoadKuce.Text = "Ucitaj modnu kucu kreatora";
            this.btnLoadKuce.UseVisualStyleBackColor = true;
            this.btnLoadKuce.Click += new System.EventHandler(this.btnLoadKuce_Click);
            // 
            // btnDelKuce
            // 
            this.btnDelKuce.Location = new System.Drawing.Point(509, 678);
            this.btnDelKuce.Name = "btnDelKuce";
            this.btnDelKuce.Size = new System.Drawing.Size(180, 23);
            this.btnDelKuce.TabIndex = 24;
            this.btnDelKuce.Text = "Brisanje modne kuce kreatora";
            this.btnDelKuce.UseVisualStyleBackColor = true;
            this.btnDelKuce.Click += new System.EventHandler(this.btnDelKuce_Click);
            // 
            // btnManyToOneSGostMRevija
            // 
            this.btnManyToOneSGostMRevija.Location = new System.Drawing.Point(38, 26);
            this.btnManyToOneSGostMRevija.Name = "btnManyToOneSGostMRevija";
            this.btnManyToOneSGostMRevija.Size = new System.Drawing.Size(179, 23);
            this.btnManyToOneSGostMRevija.TabIndex = 37;
            this.btnManyToOneSGostMRevija.Text = "ManyToOne SGost to MRevija";
            this.btnManyToOneSGostMRevija.UseVisualStyleBackColor = true;
            this.btnManyToOneSGostMRevija.Click += new System.EventHandler(this.btnManyToOneSGostMRevija_Click);
            // 
            // btnOneToManyMRevijaToSGost
            // 
            this.btnOneToManyMRevijaToSGost.Location = new System.Drawing.Point(344, 26);
            this.btnOneToManyMRevijaToSGost.Name = "btnOneToManyMRevijaToSGost";
            this.btnOneToManyMRevijaToSGost.Size = new System.Drawing.Size(260, 23);
            this.btnOneToManyMRevijaToSGost.TabIndex = 38;
            this.btnOneToManyMRevijaToSGost.Text = "OneToMany MRevija to SGost";
            this.btnOneToManyMRevijaToSGost.UseVisualStyleBackColor = true;
            this.btnOneToManyMRevijaToSGost.Click += new System.EventHandler(this.btnOneToManyMRevijaToSGost_Click);
            // 
            // btnManyToOneZemljeToMAgencija
            // 
            this.btnManyToOneZemljeToMAgencija.Location = new System.Drawing.Point(38, 84);
            this.btnManyToOneZemljeToMAgencija.Name = "btnManyToOneZemljeToMAgencija";
            this.btnManyToOneZemljeToMAgencija.Size = new System.Drawing.Size(180, 23);
            this.btnManyToOneZemljeToMAgencija.TabIndex = 42;
            this.btnManyToOneZemljeToMAgencija.Text = "ManyToOne ZemljeToMAgencija";
            this.btnManyToOneZemljeToMAgencija.UseVisualStyleBackColor = true;
            this.btnManyToOneZemljeToMAgencija.Click += new System.EventHandler(this.btnManyToOneZemljeToMAgencija_Click);
            // 
            // btnOneToManyInterToZemlje
            // 
            this.btnOneToManyInterToZemlje.Location = new System.Drawing.Point(344, 113);
            this.btnOneToManyInterToZemlje.Name = "btnOneToManyInterToZemlje";
            this.btnOneToManyInterToZemlje.Size = new System.Drawing.Size(227, 23);
            this.btnOneToManyInterToZemlje.TabIndex = 43;
            this.btnOneToManyInterToZemlje.Text = "OneToMany InternacionalnaToZemlje";
            this.btnOneToManyInterToZemlje.UseVisualStyleBackColor = true;
            this.btnOneToManyInterToZemlje.Click += new System.EventHandler(this.btnOneToManyInterToZemlje_Click);
            // 
            // btnManyToOneKuceToMKreator
            // 
            this.btnManyToOneKuceToMKreator.Location = new System.Drawing.Point(344, 142);
            this.btnManyToOneKuceToMKreator.Name = "btnManyToOneKuceToMKreator";
            this.btnManyToOneKuceToMKreator.Size = new System.Drawing.Size(180, 23);
            this.btnManyToOneKuceToMKreator.TabIndex = 44;
            this.btnManyToOneKuceToMKreator.Text = "ManyToOneKuceToMKreator";
            this.btnManyToOneKuceToMKreator.UseVisualStyleBackColor = true;
            this.btnManyToOneKuceToMKreator.Click += new System.EventHandler(this.btnManyToOneKuceToMKreator_Click);
            // 
            // btnOneToManyMKreatorToKuce
            // 
            this.btnOneToManyMKreatorToKuce.Location = new System.Drawing.Point(38, 55);
            this.btnOneToManyMKreatorToKuce.Name = "btnOneToManyMKreatorToKuce";
            this.btnOneToManyMKreatorToKuce.Size = new System.Drawing.Size(180, 23);
            this.btnOneToManyMKreatorToKuce.TabIndex = 45;
            this.btnOneToManyMKreatorToKuce.Text = "OneToManyMKreatorToKuce";
            this.btnOneToManyMKreatorToKuce.UseVisualStyleBackColor = true;
            this.btnOneToManyMKreatorToKuce.Click += new System.EventHandler(this.btnOneToManyMKreatorToKuce_Click);
            // 
            // btnOneToManyManekenToCasopisi
            // 
            this.btnOneToManyManekenToCasopisi.Location = new System.Drawing.Point(38, 142);
            this.btnOneToManyManekenToCasopisi.Name = "btnOneToManyManekenToCasopisi";
            this.btnOneToManyManekenToCasopisi.Size = new System.Drawing.Size(229, 23);
            this.btnOneToManyManekenToCasopisi.TabIndex = 46;
            this.btnOneToManyManekenToCasopisi.Text = "OneToManyManekenToCasopisi";
            this.btnOneToManyManekenToCasopisi.UseVisualStyleBackColor = true;
            this.btnOneToManyManekenToCasopisi.Click += new System.EventHandler(this.btnOneToManyManekenToCasopisi_Click);
            // 
            // btnManyToOneCasopisiToManeken
            // 
            this.btnManyToOneCasopisiToManeken.Location = new System.Drawing.Point(344, 84);
            this.btnManyToOneCasopisiToManeken.Name = "btnManyToOneCasopisiToManeken";
            this.btnManyToOneCasopisiToManeken.Size = new System.Drawing.Size(180, 23);
            this.btnManyToOneCasopisiToManeken.TabIndex = 47;
            this.btnManyToOneCasopisiToManeken.Text = "ManyToOne CasopisiToManeken";
            this.btnManyToOneCasopisiToManeken.UseVisualStyleBackColor = true;
            this.btnManyToOneCasopisiToManeken.Click += new System.EventHandler(this.btnManyToOneCasopisiToManeken_Click);
            // 
            // btnManyToManyManekenModnaRevija
            // 
            this.btnManyToManyManekenModnaRevija.Location = new System.Drawing.Point(344, 55);
            this.btnManyToManyManekenModnaRevija.Name = "btnManyToManyManekenModnaRevija";
            this.btnManyToManyManekenModnaRevija.Size = new System.Drawing.Size(260, 23);
            this.btnManyToManyManekenModnaRevija.TabIndex = 48;
            this.btnManyToManyManekenModnaRevija.Text = "ManyToManyManekenModnaRevija";
            this.btnManyToManyManekenModnaRevija.UseVisualStyleBackColor = true;
            this.btnManyToManyManekenModnaRevija.Click += new System.EventHandler(this.btnManyToManyManekenModnaRevija_Click);
            // 
            // btnManyToManyManekenModnaAgencija
            // 
            this.btnManyToManyManekenModnaAgencija.Location = new System.Drawing.Point(38, 113);
            this.btnManyToManyManekenModnaAgencija.Name = "btnManyToManyManekenModnaAgencija";
            this.btnManyToManyManekenModnaAgencija.Size = new System.Drawing.Size(274, 23);
            this.btnManyToManyManekenModnaAgencija.TabIndex = 49;
            this.btnManyToManyManekenModnaAgencija.Text = "ManyToManyManekenModnaAgencija";
            this.btnManyToManyManekenModnaAgencija.UseVisualStyleBackColor = true;
            this.btnManyToManyManekenModnaAgencija.Click += new System.EventHandler(this.btnManyToManyManekenModnaAgencija_Click);
            // 
            // btnAddManekenManyToMany
            // 
            this.btnAddManekenManyToMany.Location = new System.Drawing.Point(38, 520);
            this.btnAddManekenManyToMany.Name = "btnAddManekenManyToMany";
            this.btnAddManekenManyToMany.Size = new System.Drawing.Size(260, 23);
            this.btnAddManekenManyToMany.TabIndex = 50;
            this.btnAddManekenManyToMany.Text = "Dodavanje manekena na modnu reviju";
            this.btnAddManekenManyToMany.UseVisualStyleBackColor = true;
            this.btnAddManekenManyToMany.Click += new System.EventHandler(this.btnAddManekenManyToMany_Click);
            // 
            // btnAddPredstavllja
            // 
            this.btnAddPredstavllja.Location = new System.Drawing.Point(38, 224);
            this.btnAddPredstavllja.Name = "btnAddPredstavllja";
            this.btnAddPredstavllja.Size = new System.Drawing.Size(274, 23);
            this.btnAddPredstavllja.TabIndex = 51;
            this.btnAddPredstavllja.Text = "Dodavanje Predstavlja";
            this.btnAddPredstavllja.UseVisualStyleBackColor = true;
            this.btnAddPredstavllja.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddManekenSpecijalizacija
            // 
            this.btnAddManekenSpecijalizacija.Location = new System.Drawing.Point(344, 371);
            this.btnAddManekenSpecijalizacija.Name = "btnAddManekenSpecijalizacija";
            this.btnAddManekenSpecijalizacija.Size = new System.Drawing.Size(227, 23);
            this.btnAddManekenSpecijalizacija.TabIndex = 53;
            this.btnAddManekenSpecijalizacija.Text = "Dodavanje manekena";
            this.btnAddManekenSpecijalizacija.UseVisualStyleBackColor = true;
            this.btnAddManekenSpecijalizacija.Click += new System.EventHandler(this.btnAddManekenSpecijalizacija_Click);
            // 
            // btnAddInterModnaAgencija
            // 
            this.btnAddInterModnaAgencija.Location = new System.Drawing.Point(256, 589);
            this.btnAddInterModnaAgencija.Name = "btnAddInterModnaAgencija";
            this.btnAddInterModnaAgencija.Size = new System.Drawing.Size(227, 23);
            this.btnAddInterModnaAgencija.TabIndex = 55;
            this.btnAddInterModnaAgencija.Text = "Dodaj internacionalnu modnu agenciju";
            this.btnAddInterModnaAgencija.UseVisualStyleBackColor = true;
            this.btnAddInterModnaAgencija.Click += new System.EventHandler(this.btnAddInterModnaAgencija_Click);
            // 
            // btnUpdateCasopis
            // 
            this.btnUpdateCasopis.Location = new System.Drawing.Point(43, 620);
            this.btnUpdateCasopis.Name = "btnUpdateCasopis";
            this.btnUpdateCasopis.Size = new System.Drawing.Size(180, 23);
            this.btnUpdateCasopis.TabIndex = 56;
            this.btnUpdateCasopis.Text = "Update casopisa";
            this.btnUpdateCasopis.UseVisualStyleBackColor = true;
            this.btnUpdateCasopis.Click += new System.EventHandler(this.btnUpdateCasopis_Click);
            // 
            // btnUpdateIntMAgencija
            // 
            this.btnUpdateIntMAgencija.Location = new System.Drawing.Point(256, 619);
            this.btnUpdateIntMAgencija.Name = "btnUpdateIntMAgencija";
            this.btnUpdateIntMAgencija.Size = new System.Drawing.Size(227, 23);
            this.btnUpdateIntMAgencija.TabIndex = 57;
            this.btnUpdateIntMAgencija.Text = "Update internacionalnu modnu agenciju";
            this.btnUpdateIntMAgencija.UseVisualStyleBackColor = true;
            this.btnUpdateIntMAgencija.Click += new System.EventHandler(this.btnUpdateIntMAgencija_Click);
            // 
            // btnUpdateModnaKuca
            // 
            this.btnUpdateModnaKuca.Location = new System.Drawing.Point(509, 620);
            this.btnUpdateModnaKuca.Name = "btnUpdateModnaKuca";
            this.btnUpdateModnaKuca.Size = new System.Drawing.Size(180, 23);
            this.btnUpdateModnaKuca.TabIndex = 58;
            this.btnUpdateModnaKuca.Text = "Update modnu kucu kreatora";
            this.btnUpdateModnaKuca.UseVisualStyleBackColor = true;
            this.btnUpdateModnaKuca.Click += new System.EventHandler(this.btnUpdateModnaKuca_Click);
            // 
            // btnUpdateManeken
            // 
            this.btnUpdateManeken.Location = new System.Drawing.Point(344, 401);
            this.btnUpdateManeken.Name = "btnUpdateManeken";
            this.btnUpdateManeken.Size = new System.Drawing.Size(227, 23);
            this.btnUpdateManeken.TabIndex = 59;
            this.btnUpdateManeken.Text = "Update manekena";
            this.btnUpdateManeken.UseVisualStyleBackColor = true;
            this.btnUpdateManeken.Click += new System.EventHandler(this.btnUpdateManeken_Click);
            // 
            // brnLoadManeken
            // 
            this.brnLoadManeken.Location = new System.Drawing.Point(344, 431);
            this.brnLoadManeken.Name = "brnLoadManeken";
            this.brnLoadManeken.Size = new System.Drawing.Size(227, 23);
            this.brnLoadManeken.TabIndex = 60;
            this.brnLoadManeken.Text = "Ucitaj manekena";
            this.brnLoadManeken.UseVisualStyleBackColor = true;
            this.brnLoadManeken.Click += new System.EventHandler(this.brnLoadManeken_Click);
            // 
            // btnDelManeken
            // 
            this.btnDelManeken.Location = new System.Drawing.Point(344, 460);
            this.btnDelManeken.Name = "btnDelManeken";
            this.btnDelManeken.Size = new System.Drawing.Size(227, 23);
            this.btnDelManeken.TabIndex = 61;
            this.btnDelManeken.Text = "Brisanje manekena";
            this.btnDelManeken.UseVisualStyleBackColor = true;
            this.btnDelManeken.Click += new System.EventHandler(this.btnDelManeken_Click);
            // 
            // btnLoadModnaAgencija
            // 
            this.btnLoadModnaAgencija.Location = new System.Drawing.Point(38, 429);
            this.btnLoadModnaAgencija.Name = "btnLoadModnaAgencija";
            this.btnLoadModnaAgencija.Size = new System.Drawing.Size(274, 23);
            this.btnLoadModnaAgencija.TabIndex = 62;
            this.btnLoadModnaAgencija.Text = "Ucitavanje modne agencije";
            this.btnLoadModnaAgencija.UseVisualStyleBackColor = true;
            this.btnLoadModnaAgencija.Click += new System.EventHandler(this.btnLoadModnaAgencija_Click);
            // 
            // btnDeleteModnaAgencija
            // 
            this.btnDeleteModnaAgencija.Location = new System.Drawing.Point(38, 458);
            this.btnDeleteModnaAgencija.Name = "btnDeleteModnaAgencija";
            this.btnDeleteModnaAgencija.Size = new System.Drawing.Size(274, 23);
            this.btnDeleteModnaAgencija.TabIndex = 63;
            this.btnDeleteModnaAgencija.Text = "Brisanje modne agencije";
            this.btnDeleteModnaAgencija.UseVisualStyleBackColor = true;
            this.btnDeleteModnaAgencija.Click += new System.EventHandler(this.btnDeleteModnaAgencija_Click);
            // 
            // btnUpdateModnaAgencija
            // 
            this.btnUpdateModnaAgencija.Location = new System.Drawing.Point(38, 400);
            this.btnUpdateModnaAgencija.Name = "btnUpdateModnaAgencija";
            this.btnUpdateModnaAgencija.Size = new System.Drawing.Size(274, 23);
            this.btnUpdateModnaAgencija.TabIndex = 64;
            this.btnUpdateModnaAgencija.Text = "Update modne agencije";
            this.btnUpdateModnaAgencija.UseVisualStyleBackColor = true;
            this.btnUpdateModnaAgencija.Click += new System.EventHandler(this.btnUpdateModnaAgencija_Click);
            // 
            // btnAddModnaAgencija
            // 
            this.btnAddModnaAgencija.Location = new System.Drawing.Point(38, 371);
            this.btnAddModnaAgencija.Name = "btnAddModnaAgencija";
            this.btnAddModnaAgencija.Size = new System.Drawing.Size(274, 23);
            this.btnAddModnaAgencija.TabIndex = 65;
            this.btnAddModnaAgencija.Text = "Dodavanje modne agencije";
            this.btnAddModnaAgencija.UseVisualStyleBackColor = true;
            this.btnAddModnaAgencija.Click += new System.EventHandler(this.btnAddModnaAgencija_Click);
            // 
            // btnDelModnaRevija
            // 
            this.btnDelModnaRevija.Location = new System.Drawing.Point(617, 460);
            this.btnDelModnaRevija.Name = "btnDelModnaRevija";
            this.btnDelModnaRevija.Size = new System.Drawing.Size(260, 23);
            this.btnDelModnaRevija.TabIndex = 70;
            this.btnDelModnaRevija.Text = "Brisanje modne revije";
            this.btnDelModnaRevija.UseVisualStyleBackColor = true;
            this.btnDelModnaRevija.Click += new System.EventHandler(this.btnDelModnaRevija_Click);
            // 
            // btnLoadModnaRevija
            // 
            this.btnLoadModnaRevija.Location = new System.Drawing.Point(617, 431);
            this.btnLoadModnaRevija.Name = "btnLoadModnaRevija";
            this.btnLoadModnaRevija.Size = new System.Drawing.Size(260, 23);
            this.btnLoadModnaRevija.TabIndex = 69;
            this.btnLoadModnaRevija.Text = "Ucitaj modnu reviju";
            this.btnLoadModnaRevija.UseVisualStyleBackColor = true;
            this.btnLoadModnaRevija.Click += new System.EventHandler(this.btnLoadModnaRevija_Click_1);
            // 
            // btnUpdateModnaRevija
            // 
            this.btnUpdateModnaRevija.Location = new System.Drawing.Point(617, 401);
            this.btnUpdateModnaRevija.Name = "btnUpdateModnaRevija";
            this.btnUpdateModnaRevija.Size = new System.Drawing.Size(260, 23);
            this.btnUpdateModnaRevija.TabIndex = 68;
            this.btnUpdateModnaRevija.Text = "Update modnu reviju";
            this.btnUpdateModnaRevija.UseVisualStyleBackColor = true;
            this.btnUpdateModnaRevija.Click += new System.EventHandler(this.btnUpdateModnaRevija_Click);
            // 
            // btnAddModnaRevija
            // 
            this.btnAddModnaRevija.Location = new System.Drawing.Point(617, 371);
            this.btnAddModnaRevija.Name = "btnAddModnaRevija";
            this.btnAddModnaRevija.Size = new System.Drawing.Size(260, 23);
            this.btnAddModnaRevija.TabIndex = 67;
            this.btnAddModnaRevija.Text = "Dodavanje modne revije";
            this.btnAddModnaRevija.UseVisualStyleBackColor = true;
            this.btnAddModnaRevija.Click += new System.EventHandler(this.btnAddModnaRevija_Click_1);
            // 
            // btnDelPredstavlja
            // 
            this.btnDelPredstavlja.Location = new System.Drawing.Point(38, 313);
            this.btnDelPredstavlja.Name = "btnDelPredstavlja";
            this.btnDelPredstavlja.Size = new System.Drawing.Size(274, 23);
            this.btnDelPredstavlja.TabIndex = 73;
            this.btnDelPredstavlja.Text = "Brisanje predstavlja";
            this.btnDelPredstavlja.UseVisualStyleBackColor = true;
            this.btnDelPredstavlja.Click += new System.EventHandler(this.btnDelPredstavlja_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 23);
            this.button3.TabIndex = 72;
            this.button3.Text = "Ucitaj predstavlja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnUpdatePredstavlja
            // 
            this.btnUpdatePredstavlja.Location = new System.Drawing.Point(38, 254);
            this.btnUpdatePredstavlja.Name = "btnUpdatePredstavlja";
            this.btnUpdatePredstavlja.Size = new System.Drawing.Size(274, 23);
            this.btnUpdatePredstavlja.TabIndex = 71;
            this.btnUpdatePredstavlja.Text = "Update predstavlja";
            this.btnUpdatePredstavlja.UseVisualStyleBackColor = true;
            this.btnUpdatePredstavlja.Click += new System.EventHandler(this.btnUpdatePredstavlja_Click);
            // 
            // btnObrisiSpecijalnogGosta
            // 
            this.btnObrisiSpecijalnogGosta.Location = new System.Drawing.Point(328, 313);
            this.btnObrisiSpecijalnogGosta.Name = "btnObrisiSpecijalnogGosta";
            this.btnObrisiSpecijalnogGosta.Size = new System.Drawing.Size(274, 23);
            this.btnObrisiSpecijalnogGosta.TabIndex = 77;
            this.btnObrisiSpecijalnogGosta.Text = "Brisanje specijalnog gosta";
            this.btnObrisiSpecijalnogGosta.UseVisualStyleBackColor = true;
            this.btnObrisiSpecijalnogGosta.Click += new System.EventHandler(this.btnObrisiSpecijalnogGosta_Click);
            // 
            // btnLoadSpecijalniGost
            // 
            this.btnLoadSpecijalniGost.Location = new System.Drawing.Point(328, 284);
            this.btnLoadSpecijalniGost.Name = "btnLoadSpecijalniGost";
            this.btnLoadSpecijalniGost.Size = new System.Drawing.Size(274, 23);
            this.btnLoadSpecijalniGost.TabIndex = 76;
            this.btnLoadSpecijalniGost.Text = "Ucitaj specijalnog gosta";
            this.btnLoadSpecijalniGost.UseVisualStyleBackColor = true;
            this.btnLoadSpecijalniGost.Click += new System.EventHandler(this.btnLoadSpecijalniGost_Click);
            // 
            // btnUpdateSpecijalniGost
            // 
            this.btnUpdateSpecijalniGost.Location = new System.Drawing.Point(328, 254);
            this.btnUpdateSpecijalniGost.Name = "btnUpdateSpecijalniGost";
            this.btnUpdateSpecijalniGost.Size = new System.Drawing.Size(274, 23);
            this.btnUpdateSpecijalniGost.TabIndex = 75;
            this.btnUpdateSpecijalniGost.Text = "Update specijalnog gosta";
            this.btnUpdateSpecijalniGost.UseVisualStyleBackColor = true;
            this.btnUpdateSpecijalniGost.Click += new System.EventHandler(this.btnUpdateSpecijalniGost_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(328, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(274, 23);
            this.button5.TabIndex = 74;
            this.button5.Text = "Dodavanje specijalnog gosta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDelZemlje
            // 
            this.btnDelZemlje.Location = new System.Drawing.Point(617, 313);
            this.btnDelZemlje.Name = "btnDelZemlje";
            this.btnDelZemlje.Size = new System.Drawing.Size(274, 23);
            this.btnDelZemlje.TabIndex = 81;
            this.btnDelZemlje.Text = "Brisanje zemlje";
            this.btnDelZemlje.UseVisualStyleBackColor = true;
            this.btnDelZemlje.Click += new System.EventHandler(this.btnDelZemlje_Click);
            // 
            // btnLoadZemlje
            // 
            this.btnLoadZemlje.Location = new System.Drawing.Point(617, 284);
            this.btnLoadZemlje.Name = "btnLoadZemlje";
            this.btnLoadZemlje.Size = new System.Drawing.Size(274, 23);
            this.btnLoadZemlje.TabIndex = 80;
            this.btnLoadZemlje.Text = "Ucitaj zemlju";
            this.btnLoadZemlje.UseVisualStyleBackColor = true;
            this.btnLoadZemlje.Click += new System.EventHandler(this.btnLoadZemlje_Click);
            // 
            // btnUpdateZemlje
            // 
            this.btnUpdateZemlje.Location = new System.Drawing.Point(617, 254);
            this.btnUpdateZemlje.Name = "btnUpdateZemlje";
            this.btnUpdateZemlje.Size = new System.Drawing.Size(274, 23);
            this.btnUpdateZemlje.TabIndex = 79;
            this.btnUpdateZemlje.Text = "Update zemlju";
            this.btnUpdateZemlje.UseVisualStyleBackColor = true;
            this.btnUpdateZemlje.Click += new System.EventHandler(this.btnUpdateZemlje_Click);
            // 
            // btnAddZemlje
            // 
            this.btnAddZemlje.Location = new System.Drawing.Point(617, 224);
            this.btnAddZemlje.Name = "btnAddZemlje";
            this.btnAddZemlje.Size = new System.Drawing.Size(274, 23);
            this.btnAddZemlje.TabIndex = 78;
            this.btnAddZemlje.Text = "Dodavanje zemlje";
            this.btnAddZemlje.UseVisualStyleBackColor = true;
            this.btnAddZemlje.Click += new System.EventHandler(this.btnAddZemlje_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 23);
            this.button1.TabIndex = 85;
            this.button1.Text = "Brisanje modni kreator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 23);
            this.button2.TabIndex = 84;
            this.button2.Text = "Ucitaj modni kreator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnUpdateModniKreator
            // 
            this.btnUpdateModniKreator.Location = new System.Drawing.Point(645, 56);
            this.btnUpdateModniKreator.Name = "btnUpdateModniKreator";
            this.btnUpdateModniKreator.Size = new System.Drawing.Size(274, 23);
            this.btnUpdateModniKreator.TabIndex = 83;
            this.btnUpdateModniKreator.Text = "Update modni kreator";
            this.btnUpdateModniKreator.UseVisualStyleBackColor = true;
            this.btnUpdateModniKreator.Click += new System.EventHandler(this.btnUpdateModniKreator_Click);
            // 
            // btnAddModniKreator
            // 
            this.btnAddModniKreator.Location = new System.Drawing.Point(645, 26);
            this.btnAddModniKreator.Name = "btnAddModniKreator";
            this.btnAddModniKreator.Size = new System.Drawing.Size(274, 23);
            this.btnAddModniKreator.TabIndex = 82;
            this.btnAddModniKreator.Text = "Dodavanje modnog kreatora";
            this.btnAddModniKreator.UseVisualStyleBackColor = true;
            this.btnAddModniKreator.Click += new System.EventHandler(this.btnAddModniKreator_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdateModniKreator);
            this.Controls.Add(this.btnAddModniKreator);
            this.Controls.Add(this.btnDelZemlje);
            this.Controls.Add(this.btnLoadZemlje);
            this.Controls.Add(this.btnUpdateZemlje);
            this.Controls.Add(this.btnAddZemlje);
            this.Controls.Add(this.btnObrisiSpecijalnogGosta);
            this.Controls.Add(this.btnLoadSpecijalniGost);
            this.Controls.Add(this.btnUpdateSpecijalniGost);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDelPredstavlja);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdatePredstavlja);
            this.Controls.Add(this.btnDelModnaRevija);
            this.Controls.Add(this.btnLoadModnaRevija);
            this.Controls.Add(this.btnUpdateModnaRevija);
            this.Controls.Add(this.btnAddModnaRevija);
            this.Controls.Add(this.btnAddModnaAgencija);
            this.Controls.Add(this.btnUpdateModnaAgencija);
            this.Controls.Add(this.btnDeleteModnaAgencija);
            this.Controls.Add(this.btnLoadModnaAgencija);
            this.Controls.Add(this.btnDelManeken);
            this.Controls.Add(this.brnLoadManeken);
            this.Controls.Add(this.btnUpdateManeken);
            this.Controls.Add(this.btnUpdateModnaKuca);
            this.Controls.Add(this.btnUpdateIntMAgencija);
            this.Controls.Add(this.btnUpdateCasopis);
            this.Controls.Add(this.btnAddInterModnaAgencija);
            this.Controls.Add(this.btnAddManekenSpecijalizacija);
            this.Controls.Add(this.btnAddPredstavllja);
            this.Controls.Add(this.btnAddManekenManyToMany);
            this.Controls.Add(this.btnManyToManyManekenModnaAgencija);
            this.Controls.Add(this.btnManyToManyManekenModnaRevija);
            this.Controls.Add(this.btnManyToOneCasopisiToManeken);
            this.Controls.Add(this.btnOneToManyManekenToCasopisi);
            this.Controls.Add(this.btnOneToManyMKreatorToKuce);
            this.Controls.Add(this.btnManyToOneKuceToMKreator);
            this.Controls.Add(this.btnOneToManyInterToZemlje);
            this.Controls.Add(this.btnManyToOneZemljeToMAgencija);
            this.Controls.Add(this.btnOneToManyMRevijaToSGost);
            this.Controls.Add(this.btnManyToOneSGostMRevija);
            this.Controls.Add(this.btnDelKuce);
            this.Controls.Add(this.btnLoadKuce);
            this.Controls.Add(this.btnAddKuce);
            this.Controls.Add(this.btnDelInternacionalna);
            this.Controls.Add(this.btnLoadInternacionlna);
            this.Controls.Add(this.btnDeleteCasopis);
            this.Controls.Add(this.btnLoadCasopis);
            this.Controls.Add(this.btnDodajCasopis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajCasopis;
        private System.Windows.Forms.Button btnLoadCasopis;
        private System.Windows.Forms.Button btnDeleteCasopis;
        private System.Windows.Forms.Button btnLoadInternacionlna;
        private System.Windows.Forms.Button btnDelInternacionalna;
        private System.Windows.Forms.Button btnAddKuce;
        private System.Windows.Forms.Button btnLoadKuce;
        private System.Windows.Forms.Button btnDelKuce;
        private System.Windows.Forms.Button btnManyToOneSGostMRevija;
        private System.Windows.Forms.Button btnOneToManyMRevijaToSGost;
        private System.Windows.Forms.Button btnManyToOneZemljeToMAgencija;
        private System.Windows.Forms.Button btnOneToManyInterToZemlje;
        private System.Windows.Forms.Button btnManyToOneKuceToMKreator;
        private System.Windows.Forms.Button btnOneToManyMKreatorToKuce;
        private System.Windows.Forms.Button btnOneToManyManekenToCasopisi;
        private System.Windows.Forms.Button btnManyToOneCasopisiToManeken;
        private System.Windows.Forms.Button btnManyToManyManekenModnaRevija;
        private System.Windows.Forms.Button btnManyToManyManekenModnaAgencija;
        private System.Windows.Forms.Button btnAddManekenManyToMany;
        private System.Windows.Forms.Button btnAddPredstavllja;
        private System.Windows.Forms.Button btnAddManekenSpecijalizacija;
        private System.Windows.Forms.Button btnAddInterModnaAgencija;
        private System.Windows.Forms.Button btnUpdateCasopis;
        private System.Windows.Forms.Button btnUpdateIntMAgencija;
        private System.Windows.Forms.Button btnUpdateModnaKuca;
        private System.Windows.Forms.Button btnUpdateManeken;
        private System.Windows.Forms.Button brnLoadManeken;
        private System.Windows.Forms.Button btnDelManeken;
        private System.Windows.Forms.Button btnLoadModnaAgencija;
        private System.Windows.Forms.Button btnDeleteModnaAgencija;
        private System.Windows.Forms.Button btnUpdateModnaAgencija;
        private System.Windows.Forms.Button btnAddModnaAgencija;
        private System.Windows.Forms.Button btnDelModnaRevija;
        private System.Windows.Forms.Button btnLoadModnaRevija;
        private System.Windows.Forms.Button btnUpdateModnaRevija;
        private System.Windows.Forms.Button btnAddModnaRevija;
        private System.Windows.Forms.Button btnDelPredstavlja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdatePredstavlja;
        private System.Windows.Forms.Button btnObrisiSpecijalnogGosta;
        private System.Windows.Forms.Button btnLoadSpecijalniGost;
        private System.Windows.Forms.Button btnUpdateSpecijalniGost;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDelZemlje;
        private System.Windows.Forms.Button btnLoadZemlje;
        private System.Windows.Forms.Button btnUpdateZemlje;
        private System.Windows.Forms.Button btnAddZemlje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdateModniKreator;
        private System.Windows.Forms.Button btnAddModniKreator;
    }
}

