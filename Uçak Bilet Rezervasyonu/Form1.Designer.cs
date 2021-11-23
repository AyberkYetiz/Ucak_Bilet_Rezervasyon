
namespace Uçak_Bilet_Rezervasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Bilgileri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(35, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "UCUZ BİLET BUL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Uçuş Tipi:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Ekonomi",
            "Business"});
            this.comboBox3.Location = new System.Drawing.Point(278, 214);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yolcu:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Adana\tLTAF\tADA\tŞakirpaşa Havalimanı\tSivil\t36°58′56″K 35°16′49″D\t[1]",
            "Ankara\tLTAC\tESB\tAnkara Esenboğa Havalimanı\tSivil\t40°07′41″K 32°59′42″D\t[2]",
            "Antalya\tLTAI\tAYT\tAntalya Havalimanı\tSivil\t36°54′01″K 30°47′34″D\t[3]",
            "Alanya\tLTFG\tGZP\tGazipaşa Havalimanı\tSivil\t36°17′57″K 32°18′05″D\t[4]",
            "Balıkesir\tLTFD\tEDO\tBalıkesir Koca Seyit Havalimanı\tSivil\t39°33′09″K 27°00′37″D\t[5" +
                "]",
            "Bursa\tLTBR\tYEI\tBursa Yenişehir Havalimanı\tSivil/Askerî\t40°15′21″K 29°33′43″D\t[6]",
            "Çanakkale\tLTBH\tCKZ\tÇanakkale Havalimanı\tSivil/Askerî\t40°08′15″K 26°25′51″D\t[7]",
            "Denizli\tLTAY\tDNZ\tDenizli Çardak Havalimanı\tSivil/Askerî\t37°47′16″K 29°42′18″D\t[8]" +
                "",
            "Diyarbakır\tLTCC\tDIY\tDiyarbakır Havalimanı\tSivil/Askerî\t37°54′04″K 40°11′09″D\t[9]",
            "Elazığ\tLTCA\tEZS\tElazığ Havalimanı\tSivil/Askerî\t38°35′51″K 39°16′53″D\t[10]",
            "Erzurum\tLTCE\tERZ\tErzurum Havalimanı\tSivil/Askerî\t39°57′21″K 41°10′14″D\t[11]",
            "Eskişehir\tLTBY\tAOE\tHasan Polatkan Havalimanı\tSivil\t39°48′45″K 30°31′41″D\t[12]",
            "Gaziantep\tLTAJ\tGZT\tGaziantep Havalimanı\tSivil\t36°56′52″K 37°28′44″D\t[13]",
            "Hatay\tLTDA\tHTY\tHatay Havalimanı\tSivil\t36°22′20″K 36°17′55″D\t[14]",
            "Isparta\tLTFC\tISE\tIsparta Süleyman Demirel Havalimanı\tSivil\t37°51′21″K 30°22′01″D\t" +
                "[15]",
            "İstanbul\tLTBA\tISL\tAtatürk Havalimanı\tSivil\t40°58′34″K 28°48′50″D\t[16]",
            "İstanbul\tLTFM\tIST\tİstanbul Havalimanı\tSivil\t41°15′39″K 28°44′32″D\t[17]",
            "İstanbul\tLTFJ\tSAW\tSabiha Gökçen Havalimanı\tSivil\t40°53′39″K 29°18′30″D\t[18]",
            "İzmir\tLTBJ\tADB\tAdnan Menderes Havalimanı\tSivil\t38°17′21″K 27°09′18″D\t[19]",
            "Kars\tLTCF\tKSY\tKars Harakani Havalimanı\tSivil\t40°33′44″K 43°06′53″D\t[20]",
            "Kayseri\tLTAU\tASR\tErkilet Havalimanı\tSivil/Askerî\t38°46′13″K 35°29′43″D\t[21]",
            "Kocaeli\tLTBQ\tKCO\tCengiz Topel Havalimanı\tSivil/Askerî\t40°44′06″K 30°05′00″D\t[22]",
            "Konya\tLTAN\tKYA\tKonya Havalimanı\tSivil/Askerî\t37°58′50″K 32°33′45″D\t[23]",
            "Kütahya\tLTBZ\tKZR\tZafer Havalimanı\tSivil\t39°06′41″K 30°07′48″D\t[24]",
            "Malatya\tLTAT\tMLX\tMalatya Havalimanı\tSivil/Askerî\t38°25′56″K 38°04′59″D\t[25]",
            "Muğla\tLTBS\tDLM\tDalaman Havalimanı\tSivil/Askerî\t36°42′45″K 28°47′29″D\t[26]",
            "Muğla\tLTFE\tBJV\tMilas-Bodrum Havalimanı\tSivil\t37°14′58″K 27°39′53″D\t[27]",
            "Nevşehir\tLTAZ\tNAV\tNevşehir Kapadokya Havalimanı\tSivil\t38°46′31″K 34°31′36″D\t[28]",
            "Ordu-Giresun\tLTCB\tOGU\tOrdu-Giresun Havalimanı\tSivil\t40°58′02″K 38°04′55″D\t[29]",
            "Samsun\tLTFH\tSZF\tSamsun Çarşamba Havalimanı\tSivil\t41°15′56″K 36°32′55″D\t[30]",
            "Sinop\tLTCM\tNOP\tSinop Havalimanı\tSivil\t42°00′57″K 35°03′59″D\t[31]",
            "Sivas\tLTAR\tVAS\tSivas Nuri Demirağ Havalimanı\tSivil\t39°48′51″K 36°54′09″D\t[32]",
            "Şanlıurfa\tLTCS\tGNY\tŞanlıurfa GAP Havalimanı\tSivil\t37°27′24″K 38°54′30″D\t[33]",
            "Tekirdağ\tLTBU\tTEQ\tTekirdağ Çorlu Havalimanı\tSivil/Askerî\t41°07′46″K 27°54′23″D\t[3" +
                "4]",
            "Trabzon\tLTCG\tTZX\tTrabzon Havalimanı\tSivil\t40°59′45″K 39°47′07″D\t[35]",
            "Uşak\tLTBO\tUSQ\tUşak Havalimanı\tSivil/Askerî\t38°40′53″K 29°28′18″D\t[36]",
            "Van\tLTCI\tVAN\tVan Ferit Melen Havalimanı\tSivil\t38°28′07″K 43°19′51″D\t[37]",
            "Zonguldak\tLTAS\tONQ\tZonguldak Havalimanı\tSivil\t41°30′23″K 32°05′19″D\t[38]",
            "Yerel havalimanları",
            "Adıyaman\tLTCP\tADF\tAdıyaman Havalimanı\tSivil\t37°43′56″K 38°28′09″D\t[39]",
            "Ağrı\tLTCO\tAJI\tAğrı Ahmed-i Hani Havalimanı\tSivil\t39°38′51″K 43°01′43″D\t[40]",
            "Amasya\tLTAP\tMZH\tAmasya Merzifon Havalimanı\tSivil/Askerî\t40°49′46″K 35°31′20″D\t[41" +
                "]",
            "Aydın\tLTBD\tCII\tAydın Çıldır Havalimanı\tSivil\t37°48′58″K 27°53′20″D\t[42]",
            "Balıkesir\tLTBF\tBZI\tBalıkesir Merkez Havalimanı\tSivil/Askerî\t39°36′56″K 27°55′58″D" +
                "\t[43]",
            "Batman\tLTCJ\tBAL\tBatman Havalimanı\tSivil/Askerî\t37°55′56″K 41°06′59″D\t[44]",
            "Bingöl\tLTCU\tBGG\tBingöl Havalimanı\tSivil\t38°51′40″K 40°35′33″D\t[45]",
            "Bursa\tLTBE\tBTZ\tBursa Yunuseli Havalimanı\tSivil\t40°13′59″K 29°00′33″D\t[46]",
            "Çanakkale\tLTFK\tGKD\tGökçeada Havalimanı\tSivil\t40°12′00″K 25°52′54″D\t[47]",
            "Erzincan\tLTCD\tERC\tErzincan Yıldırım Akbulut Havalimanı\tSivil/Askerî\t39°42′47″K 39" +
                "°31′14″D\t[48]",
            "Eskişehir\tYok\tYok\tSivrihisar Havacılık Merkezi S.H.M.\tSivil\t39°17′59″K 31°29′38″D" +
                "\t[49]",
            "Hakkâri\tLTCW\tYKO\tHakkâri Yüksekova Selahaddin Eyyubi Havalimanı\tSivil\t37°32′59″K " +
                "44°14′15″D\t[50]",
            "Iğdır\tLTCT\tIGD\tIğdır Şehit Bülent Aydın Havalimanı\tSivil\t39°58′59″K 43°51′59″D\t[5" +
                "1]",
            "İstanbul\tLTBW\tYok\tİstanbul Hezarfen Havalimanı\tSivil\t41°06′16″K 28°33′00″D\t[52]",
            "İzmir\tLTFB\tIZM\tSelçuk-Efes Havalimanı\tSivil\t37°57′02″K 27°19′45″D\t[53]",
            "Kahramanmaraş\tLTCN\tKCM\tKahramanmaraş Havalimanı\tSivil\t37°32′18″K 36°57′07″D\t[54]",
            "Kastamonu\tLTAL\tKFS\tKastamonu Havalimanı\tSivil\t41°19′01″K 33°47′46″D\t[55]",
            "Mardin\tLTCR\tMQM\tMardin Havalimanı\tSivil\t37°13′58″K 40°38′26″D\t[56]",
            "Muş\tLTCK\tMSR\tMuş Havalimanı\tSivil/Askerî\t38°44′41″K 41°40′08″D\t[57]",
            "Siirt\tLTCL\tSXZ\tSiirt Havalimanı\tSivil\t37°58′41″K 41°50′21″D\t[58]",
            "Şırnak\tLTCV\tNKT\tŞırnak Şerafettin Elçi Havalimanı\tSivil\t37°21′50″K 42°03′36″D\t[59" +
                "]",
            "Tokat\tLTAW\tTJK\tTokat Havalimanı\tSivil\t40°18′42″K 36°22′25″D\t[60]",
            "Askerî havalimanları",
            "Adana\tLTAG\tUAB\tİncirlik Hava Üssü\tAskerî\t37°00′07″K 35°25′33″D\t",
            "Afyonkarahisar\tLTAH\tAFY\tAfyon Havalimanı\tAskerî\t38°43′35″K 30°36′04″D\t",
            "Ankara\tLTAB\tYok\tGüvercinlik Havalimanı\tAskerî\t39°56′05″K 32°44′26″D\t",
            "Ankara\tLTAE\tYok\tMürted Hava Üssü\tAskerî\t40°04′44″K 32°33′56″D\t",
            "Ankara\tLTAD\tANK\tEtimesgut Havalimanı\tAskerî\t39°56′59″K 32°41′19″D\t",
            "Balıkesir\tLTBG\tBDM\tBandırma Havalimanı\tAskerî\t40°19′04″K 27°58′39″D\t",
            "Edirne\tLTFL\tYok\tKeşan Hava Üssü\tAskerî\t40°47′14″K 26°36′24″D\t",
            "Eskişehir\tLTBI\tESK\tEskişehir Hava Üssü\tAskerî\t39°47′02″K 30°34′55″D\t",
            "Eskişehir\tLTAV\tYok\tSivrihisar Hava Üssü\tAskerî\t39°27′05″K 31°21′55″D\t",
            "İstanbul\tLTBX\tYok\tSamandıra Hava Üssü\tAskerî\t40°59′34″K 29°12′56″D\t",
            "İzmir\tLTBL\tIGL\tÇiğli Hava Üssü\tAskerî\t38°30′46″K 27°00′36″D\t",
            "İzmir\tLTBK\tYok\tGaziemir Hava Üssü\tAskerî\t38°19′08″K 27°09′33″D\t",
            "İzmir\tLTFA\tYok\tKaklıç Hava Üssü\tAskerî\t38°31′26″K 26°58′28″D\t",
            "Kütahya\tLTBN\tYok\tKütahya Hava Üssü\tAskerî\t39°25′36″K 30°01′00″D\t",
            "Malatya\tLTAO\tYok\tMalatya Tulga Havalimanı\tAskerî\t38°21′14″K 38°15′14″D\t",
            "Manisa\tLTBT\tYok\tAkhisar Hava Üssü\tAskerî\t38°48′34″K 27°50′06″D\t",
            "Muğla\tLTBV\tBXN\tImsık Havalimanı\tAskerî\t37°08′25″K 27°40′11″D\t",
            "Yalova\tLTBP\tYok\tYalova Hava Üssü\tAskerî\t40°41′02″K 29°22′34″D\t",
            "Planlanan havalimanları",
            "Antalya\t\t\tKaş-Demre Batı Antalya Havalimanı\tSivil\t\t",
            "Edirne\t\t\tEdirne-Kırklareli Havalimanı\tSivil\t\t",
            "Gümüşhane\t\t\tGümüşhane-Bayburt Havalimanı\tSivil\t\t",
            "İzmir\t\t\tEkrem Pakdemirli Havalimanı\tSivil\t38°14′29″K 26°25′27″D\t",
            "Karaman\t\t\tKaraman Havalimanı\tSivil\t\t",
            "Mersin\t\t\tÇukurova Bölgesel Havalimanı\tSivil\t36.8996°K 35.0628°D\t",
            "Niğde\t\t\tÖmer Halisdemir Havalimanı\tSivil\t\t",
            "Rize\t\t\tRize-Artvin Havalimanı\tSivil\t\t",
            "Yozgat\t\t\tYozgat Havalimanı\tSivil"});
            this.comboBox2.Location = new System.Drawing.Point(112, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adana\tLTAF\tADA\tŞakirpaşa Havalimanı\tSivil\t36°58′56″K 35°16′49″D\t[1]",
            "Ankara\tLTAC\tESB\tAnkara Esenboğa Havalimanı\tSivil\t40°07′41″K 32°59′42″D\t[2]",
            "Antalya\tLTAI\tAYT\tAntalya Havalimanı\tSivil\t36°54′01″K 30°47′34″D\t[3]",
            "Alanya\tLTFG\tGZP\tGazipaşa Havalimanı\tSivil\t36°17′57″K 32°18′05″D\t[4]",
            "Balıkesir\tLTFD\tEDO\tBalıkesir Koca Seyit Havalimanı\tSivil\t39°33′09″K 27°00′37″D\t[5" +
                "]",
            "Bursa\tLTBR\tYEI\tBursa Yenişehir Havalimanı\tSivil/Askerî\t40°15′21″K 29°33′43″D\t[6]",
            "Çanakkale\tLTBH\tCKZ\tÇanakkale Havalimanı\tSivil/Askerî\t40°08′15″K 26°25′51″D\t[7]",
            "Denizli\tLTAY\tDNZ\tDenizli Çardak Havalimanı\tSivil/Askerî\t37°47′16″K 29°42′18″D\t[8]" +
                "",
            "Diyarbakır\tLTCC\tDIY\tDiyarbakır Havalimanı\tSivil/Askerî\t37°54′04″K 40°11′09″D\t[9]",
            "Elazığ\tLTCA\tEZS\tElazığ Havalimanı\tSivil/Askerî\t38°35′51″K 39°16′53″D\t[10]",
            "Erzurum\tLTCE\tERZ\tErzurum Havalimanı\tSivil/Askerî\t39°57′21″K 41°10′14″D\t[11]",
            "Eskişehir\tLTBY\tAOE\tHasan Polatkan Havalimanı\tSivil\t39°48′45″K 30°31′41″D\t[12]",
            "Gaziantep\tLTAJ\tGZT\tGaziantep Havalimanı\tSivil\t36°56′52″K 37°28′44″D\t[13]",
            "Hatay\tLTDA\tHTY\tHatay Havalimanı\tSivil\t36°22′20″K 36°17′55″D\t[14]",
            "Isparta\tLTFC\tISE\tIsparta Süleyman Demirel Havalimanı\tSivil\t37°51′21″K 30°22′01″D\t" +
                "[15]",
            "İstanbul\tLTBA\tISL\tAtatürk Havalimanı\tSivil\t40°58′34″K 28°48′50″D\t[16]",
            "İstanbul\tLTFM\tIST\tİstanbul Havalimanı\tSivil\t41°15′39″K 28°44′32″D\t[17]",
            "İstanbul\tLTFJ\tSAW\tSabiha Gökçen Havalimanı\tSivil\t40°53′39″K 29°18′30″D\t[18]",
            "İzmir\tLTBJ\tADB\tAdnan Menderes Havalimanı\tSivil\t38°17′21″K 27°09′18″D\t[19]",
            "Kars\tLTCF\tKSY\tKars Harakani Havalimanı\tSivil\t40°33′44″K 43°06′53″D\t[20]",
            "Kayseri\tLTAU\tASR\tErkilet Havalimanı\tSivil/Askerî\t38°46′13″K 35°29′43″D\t[21]",
            "Kocaeli\tLTBQ\tKCO\tCengiz Topel Havalimanı\tSivil/Askerî\t40°44′06″K 30°05′00″D\t[22]",
            "Konya\tLTAN\tKYA\tKonya Havalimanı\tSivil/Askerî\t37°58′50″K 32°33′45″D\t[23]",
            "Kütahya\tLTBZ\tKZR\tZafer Havalimanı\tSivil\t39°06′41″K 30°07′48″D\t[24]",
            "Malatya\tLTAT\tMLX\tMalatya Havalimanı\tSivil/Askerî\t38°25′56″K 38°04′59″D\t[25]",
            "Muğla\tLTBS\tDLM\tDalaman Havalimanı\tSivil/Askerî\t36°42′45″K 28°47′29″D\t[26]",
            "Muğla\tLTFE\tBJV\tMilas-Bodrum Havalimanı\tSivil\t37°14′58″K 27°39′53″D\t[27]",
            "Nevşehir\tLTAZ\tNAV\tNevşehir Kapadokya Havalimanı\tSivil\t38°46′31″K 34°31′36″D\t[28]",
            "Ordu-Giresun\tLTCB\tOGU\tOrdu-Giresun Havalimanı\tSivil\t40°58′02″K 38°04′55″D\t[29]",
            "Samsun\tLTFH\tSZF\tSamsun Çarşamba Havalimanı\tSivil\t41°15′56″K 36°32′55″D\t[30]",
            "Sinop\tLTCM\tNOP\tSinop Havalimanı\tSivil\t42°00′57″K 35°03′59″D\t[31]",
            "Sivas\tLTAR\tVAS\tSivas Nuri Demirağ Havalimanı\tSivil\t39°48′51″K 36°54′09″D\t[32]",
            "Şanlıurfa\tLTCS\tGNY\tŞanlıurfa GAP Havalimanı\tSivil\t37°27′24″K 38°54′30″D\t[33]",
            "Tekirdağ\tLTBU\tTEQ\tTekirdağ Çorlu Havalimanı\tSivil/Askerî\t41°07′46″K 27°54′23″D\t[3" +
                "4]",
            "Trabzon\tLTCG\tTZX\tTrabzon Havalimanı\tSivil\t40°59′45″K 39°47′07″D\t[35]",
            "Uşak\tLTBO\tUSQ\tUşak Havalimanı\tSivil/Askerî\t38°40′53″K 29°28′18″D\t[36]",
            "Van\tLTCI\tVAN\tVan Ferit Melen Havalimanı\tSivil\t38°28′07″K 43°19′51″D\t[37]",
            "Zonguldak\tLTAS\tONQ\tZonguldak Havalimanı\tSivil\t41°30′23″K 32°05′19″D\t[38]",
            "Yerel havalimanları",
            "Adıyaman\tLTCP\tADF\tAdıyaman Havalimanı\tSivil\t37°43′56″K 38°28′09″D\t[39]",
            "Ağrı\tLTCO\tAJI\tAğrı Ahmed-i Hani Havalimanı\tSivil\t39°38′51″K 43°01′43″D\t[40]",
            "Amasya\tLTAP\tMZH\tAmasya Merzifon Havalimanı\tSivil/Askerî\t40°49′46″K 35°31′20″D\t[41" +
                "]",
            "Aydın\tLTBD\tCII\tAydın Çıldır Havalimanı\tSivil\t37°48′58″K 27°53′20″D\t[42]",
            "Balıkesir\tLTBF\tBZI\tBalıkesir Merkez Havalimanı\tSivil/Askerî\t39°36′56″K 27°55′58″D" +
                "\t[43]",
            "Batman\tLTCJ\tBAL\tBatman Havalimanı\tSivil/Askerî\t37°55′56″K 41°06′59″D\t[44]",
            "Bingöl\tLTCU\tBGG\tBingöl Havalimanı\tSivil\t38°51′40″K 40°35′33″D\t[45]",
            "Bursa\tLTBE\tBTZ\tBursa Yunuseli Havalimanı\tSivil\t40°13′59″K 29°00′33″D\t[46]",
            "Çanakkale\tLTFK\tGKD\tGökçeada Havalimanı\tSivil\t40°12′00″K 25°52′54″D\t[47]",
            "Erzincan\tLTCD\tERC\tErzincan Yıldırım Akbulut Havalimanı\tSivil/Askerî\t39°42′47″K 39" +
                "°31′14″D\t[48]",
            "Eskişehir\tYok\tYok\tSivrihisar Havacılık Merkezi S.H.M.\tSivil\t39°17′59″K 31°29′38″D" +
                "\t[49]",
            "Hakkâri\tLTCW\tYKO\tHakkâri Yüksekova Selahaddin Eyyubi Havalimanı\tSivil\t37°32′59″K " +
                "44°14′15″D\t[50]",
            "Iğdır\tLTCT\tIGD\tIğdır Şehit Bülent Aydın Havalimanı\tSivil\t39°58′59″K 43°51′59″D\t[5" +
                "1]",
            "İstanbul\tLTBW\tYok\tİstanbul Hezarfen Havalimanı\tSivil\t41°06′16″K 28°33′00″D\t[52]",
            "İzmir\tLTFB\tIZM\tSelçuk-Efes Havalimanı\tSivil\t37°57′02″K 27°19′45″D\t[53]",
            "Kahramanmaraş\tLTCN\tKCM\tKahramanmaraş Havalimanı\tSivil\t37°32′18″K 36°57′07″D\t[54]",
            "Kastamonu\tLTAL\tKFS\tKastamonu Havalimanı\tSivil\t41°19′01″K 33°47′46″D\t[55]",
            "Mardin\tLTCR\tMQM\tMardin Havalimanı\tSivil\t37°13′58″K 40°38′26″D\t[56]",
            "Muş\tLTCK\tMSR\tMuş Havalimanı\tSivil/Askerî\t38°44′41″K 41°40′08″D\t[57]",
            "Siirt\tLTCL\tSXZ\tSiirt Havalimanı\tSivil\t37°58′41″K 41°50′21″D\t[58]",
            "Şırnak\tLTCV\tNKT\tŞırnak Şerafettin Elçi Havalimanı\tSivil\t37°21′50″K 42°03′36″D\t[59" +
                "]",
            "Tokat\tLTAW\tTJK\tTokat Havalimanı\tSivil\t40°18′42″K 36°22′25″D\t[60]",
            "Askerî havalimanları",
            "Adana\tLTAG\tUAB\tİncirlik Hava Üssü\tAskerî\t37°00′07″K 35°25′33″D\t",
            "Afyonkarahisar\tLTAH\tAFY\tAfyon Havalimanı\tAskerî\t38°43′35″K 30°36′04″D\t",
            "Ankara\tLTAB\tYok\tGüvercinlik Havalimanı\tAskerî\t39°56′05″K 32°44′26″D\t",
            "Ankara\tLTAE\tYok\tMürted Hava Üssü\tAskerî\t40°04′44″K 32°33′56″D\t",
            "Ankara\tLTAD\tANK\tEtimesgut Havalimanı\tAskerî\t39°56′59″K 32°41′19″D\t",
            "Balıkesir\tLTBG\tBDM\tBandırma Havalimanı\tAskerî\t40°19′04″K 27°58′39″D\t",
            "Edirne\tLTFL\tYok\tKeşan Hava Üssü\tAskerî\t40°47′14″K 26°36′24″D\t",
            "Eskişehir\tLTBI\tESK\tEskişehir Hava Üssü\tAskerî\t39°47′02″K 30°34′55″D\t",
            "Eskişehir\tLTAV\tYok\tSivrihisar Hava Üssü\tAskerî\t39°27′05″K 31°21′55″D\t",
            "İstanbul\tLTBX\tYok\tSamandıra Hava Üssü\tAskerî\t40°59′34″K 29°12′56″D\t",
            "İzmir\tLTBL\tIGL\tÇiğli Hava Üssü\tAskerî\t38°30′46″K 27°00′36″D\t",
            "İzmir\tLTBK\tYok\tGaziemir Hava Üssü\tAskerî\t38°19′08″K 27°09′33″D\t",
            "İzmir\tLTFA\tYok\tKaklıç Hava Üssü\tAskerî\t38°31′26″K 26°58′28″D\t",
            "Kütahya\tLTBN\tYok\tKütahya Hava Üssü\tAskerî\t39°25′36″K 30°01′00″D\t",
            "Malatya\tLTAO\tYok\tMalatya Tulga Havalimanı\tAskerî\t38°21′14″K 38°15′14″D\t",
            "Manisa\tLTBT\tYok\tAkhisar Hava Üssü\tAskerî\t38°48′34″K 27°50′06″D\t",
            "Muğla\tLTBV\tBXN\tImsık Havalimanı\tAskerî\t37°08′25″K 27°40′11″D\t",
            "Yalova\tLTBP\tYok\tYalova Hava Üssü\tAskerî\t40°41′02″K 29°22′34″D\t",
            "Planlanan havalimanları",
            "Antalya\t\t\tKaş-Demre Batı Antalya Havalimanı\tSivil\t\t",
            "Edirne\t\t\tEdirne-Kırklareli Havalimanı\tSivil\t\t",
            "Gümüşhane\t\t\tGümüşhane-Bayburt Havalimanı\tSivil\t\t",
            "İzmir\t\t\tEkrem Pakdemirli Havalimanı\tSivil\t38°14′29″K 26°25′27″D\t",
            "Karaman\t\t\tKaraman Havalimanı\tSivil\t\t",
            "Mersin\t\t\tÇukurova Bölgesel Havalimanı\tSivil\t36.8996°K 35.0628°D\t",
            "Niğde\t\t\tÖmer Halisdemir Havalimanı\tSivil\t\t",
            "Rize\t\t\tRize-Artvin Havalimanı\tSivil\t\t",
            "Yozgat\t\t\tYozgat Havalimanı\tSivil"});
            this.comboBox1.Location = new System.Drawing.Point(112, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(71, 174);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dönüş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gidiş:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nereye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nereden:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tek Yön";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gidiş-Dönüş";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.maskedTextBox5);
            this.groupBox2.Controls.Add(this.maskedTextBox4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(460, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 201);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uçuş Bilgisi Sorgulama";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(102, 43);
            this.maskedTextBox5.Mask = "00000000000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox5.TabIndex = 17;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(102, 89);
            this.maskedTextBox4.Mask = "00000000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Destek";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 15;
            this.button5.Text = "Şikayet Butonu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sorgula";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "PNR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(21, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 55);
            this.panel1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(629, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "5051335447";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "İletişim:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 35);
            this.label10.TabIndex = 13;
            this.label10.Text = "TÜRK HAVA YOLLARI";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.maskedTextBox2);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(750, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 206);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yolcu Bilgileri";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(65, 91);
            this.maskedTextBox2.Mask = "00000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 22;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(74, 49);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(65, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 41);
            this.button6.TabIndex = 21;
            this.button6.Text = "Bilgileri Kaydet";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "HES Kodu:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(74, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "TC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ad-Soyad:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(196, 387);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(613, 95);
            this.listBox1.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "↕";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(288, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Aracı";
            this.label16.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 533);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Uçak Rezervasyon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
    }
}

