namespace WF_App
{
    partial class Cust_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cust_Info));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_lastname = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_createCoin = new System.Windows.Forms.Button();
            this.btn_updateCoin = new System.Windows.Forms.Button();
            this.txt_coinName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_idCoin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_searchACC = new System.Windows.Forms.Button();
            this.btn_updateAcc = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_uban = new System.Windows.Forms.TextBox();
            this.txt_custID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(173, 37);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(264, 20);
            this.txt_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.text_phone);
            this.groupBox1.Controls.Add(this.text_email);
            this.groupBox1.Controls.Add(this.text_lastname);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(489, 181);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(178, 45);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update Customer";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Firebrick;
            this.btn_save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.Location = new System.Drawing.Point(489, 35);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(178, 45);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Create Customer";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Tomato;
            this.btn_search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.Location = new System.Drawing.Point(489, 102);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(178, 45);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search Customer";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // text_phone
            // 
            this.text_phone.BackColor = System.Drawing.Color.White;
            this.text_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_phone.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_phone.ForeColor = System.Drawing.Color.Black;
            this.text_phone.Location = new System.Drawing.Point(173, 245);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(264, 20);
            this.text_phone.TabIndex = 12;
            this.text_phone.TextChanged += new System.EventHandler(this.text_phone_TextChanged);
            // 
            // text_email
            // 
            this.text_email.BackColor = System.Drawing.Color.White;
            this.text_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_email.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.ForeColor = System.Drawing.Color.Black;
            this.text_email.Location = new System.Drawing.Point(173, 194);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(264, 20);
            this.text_email.TabIndex = 11;
            this.text_email.TextChanged += new System.EventHandler(this.text_email_TextChanged);
            // 
            // text_lastname
            // 
            this.text_lastname.BackColor = System.Drawing.Color.White;
            this.text_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_lastname.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_lastname.ForeColor = System.Drawing.Color.Black;
            this.text_lastname.Location = new System.Drawing.Point(173, 142);
            this.text_lastname.Name = "text_lastname";
            this.text_lastname.Size = new System.Drawing.Size(264, 20);
            this.text_lastname.TabIndex = 10;
            this.text_lastname.TextChanged += new System.EventHandler(this.text_lastname_TextChanged);
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.White;
            this.text_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_name.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name.ForeColor = System.Drawing.Color.Black;
            this.text_name.Location = new System.Drawing.Point(173, 89);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(264, 20);
            this.text_name.TabIndex = 9;
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_createCoin);
            this.groupBox2.Controls.Add(this.btn_updateCoin);
            this.groupBox2.Controls.Add(this.txt_coinName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.text_idCoin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(712, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 214);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Money Information";
            // 
            // btn_createCoin
            // 
            this.btn_createCoin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_createCoin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_createCoin.Location = new System.Drawing.Point(9, 143);
            this.btn_createCoin.Name = "btn_createCoin";
            this.btn_createCoin.Size = new System.Drawing.Size(157, 45);
            this.btn_createCoin.TabIndex = 17;
            this.btn_createCoin.Text = "Create Coin";
            this.btn_createCoin.UseVisualStyleBackColor = false;
            this.btn_createCoin.Click += new System.EventHandler(this.btn_createCoin_Click);
            // 
            // btn_updateCoin
            // 
            this.btn_updateCoin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_updateCoin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_updateCoin.Location = new System.Drawing.Point(188, 143);
            this.btn_updateCoin.Name = "btn_updateCoin";
            this.btn_updateCoin.Size = new System.Drawing.Size(157, 45);
            this.btn_updateCoin.TabIndex = 16;
            this.btn_updateCoin.Text = "Update Coin";
            this.btn_updateCoin.UseVisualStyleBackColor = false;
            this.btn_updateCoin.Click += new System.EventHandler(this.btn_updateCoin_Click);
            // 
            // txt_coinName
            // 
            this.txt_coinName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_coinName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_coinName.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coinName.ForeColor = System.Drawing.Color.DimGray;
            this.txt_coinName.Location = new System.Drawing.Point(173, 90);
            this.txt_coinName.Name = "txt_coinName";
            this.txt_coinName.Size = new System.Drawing.Size(172, 20);
            this.txt_coinName.TabIndex = 3;
            this.txt_coinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Currency Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // text_idCoin
            // 
            this.text_idCoin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.text_idCoin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_idCoin.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_idCoin.ForeColor = System.Drawing.Color.DimGray;
            this.text_idCoin.Location = new System.Drawing.Point(173, 36);
            this.text_idCoin.Name = "text_idCoin";
            this.text_idCoin.Size = new System.Drawing.Size(172, 20);
            this.text_idCoin.TabIndex = 0;
            this.text_idCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_idCoin.TextChanged += new System.EventHandler(this.text_idCoin_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Currency Code";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.btn_searchACC);
            this.groupBox3.Controls.Add(this.btn_updateAcc);
            this.groupBox3.Controls.Add(this.txt_status);
            this.groupBox3.Controls.Add(this.txt_cod);
            this.groupBox3.Controls.Add(this.txt_descrip);
            this.groupBox3.Controls.Add(this.txt_uban);
            this.groupBox3.Controls.Add(this.txt_custID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(21, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1036, 228);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Information";
            // 
            // btn_searchACC
            // 
            this.btn_searchACC.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_searchACC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_searchACC.Location = new System.Drawing.Point(855, 70);
            this.btn_searchACC.Name = "btn_searchACC";
            this.btn_searchACC.Size = new System.Drawing.Size(157, 45);
            this.btn_searchACC.TabIndex = 24;
            this.btn_searchACC.Text = "Search Account";
            this.btn_searchACC.UseVisualStyleBackColor = false;
            this.btn_searchACC.Click += new System.EventHandler(this.btn_searchACC_Click);
            // 
            // btn_updateAcc
            // 
            this.btn_updateAcc.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_updateAcc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_updateAcc.Location = new System.Drawing.Point(855, 136);
            this.btn_updateAcc.Name = "btn_updateAcc";
            this.btn_updateAcc.Size = new System.Drawing.Size(157, 45);
            this.btn_updateAcc.TabIndex = 17;
            this.btn_updateAcc.Text = "Update Account";
            this.btn_updateAcc.UseVisualStyleBackColor = false;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.White;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_status.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ForeColor = System.Drawing.Color.Black;
            this.txt_status.Location = new System.Drawing.Point(659, 149);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(157, 20);
            this.txt_status.TabIndex = 23;
            // 
            // txt_cod
            // 
            this.txt_cod.BackColor = System.Drawing.Color.White;
            this.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cod.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.ForeColor = System.Drawing.Color.Black;
            this.txt_cod.Location = new System.Drawing.Point(449, 149);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(186, 20);
            this.txt_cod.TabIndex = 22;
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.White;
            this.txt_descrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descrip.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip.Location = new System.Drawing.Point(242, 149);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(186, 20);
            this.txt_descrip.TabIndex = 21;
            // 
            // txt_uban
            // 
            this.txt_uban.BackColor = System.Drawing.Color.CadetBlue;
            this.txt_uban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_uban.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uban.ForeColor = System.Drawing.Color.Black;
            this.txt_uban.Location = new System.Drawing.Point(33, 70);
            this.txt_uban.Name = "txt_uban";
            this.txt_uban.Size = new System.Drawing.Size(249, 20);
            this.txt_uban.TabIndex = 20;
            // 
            // txt_custID
            // 
            this.txt_custID.BackColor = System.Drawing.Color.White;
            this.txt_custID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_custID.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custID.ForeColor = System.Drawing.Color.Black;
            this.txt_custID.Location = new System.Drawing.Point(33, 149);
            this.txt_custID.Name = "txt_custID";
            this.txt_custID.Size = new System.Drawing.Size(186, 20);
            this.txt_custID.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(446, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Money Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(656, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(239, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Description";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "UBAN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personal ID";
            // 
            // Cust_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1180, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cust_Info";
            this.Text = "PaGO App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_lastname;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_idCoin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_coinName;
        private System.Windows.Forms.Button btn_updateCoin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_uban;
        private System.Windows.Forms.TextBox txt_custID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_searchACC;
        private System.Windows.Forms.Button btn_updateAcc;
        private System.Windows.Forms.Button btn_createCoin;
    }
}

