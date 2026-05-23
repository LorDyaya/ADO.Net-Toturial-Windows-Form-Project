namespace Contacts_Project_WindowsForms
{
    partial class FrmAddEditContact
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
            this.MoodLbl = new System.Windows.Forms.Label();
            this.ContactIDLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.IDValue = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.PhoneValue = new System.Windows.Forms.TextBox();
            this.AddressValue = new System.Windows.Forms.TextBox();
            this.dateTimeValue = new System.Windows.Forms.DateTimePicker();
            this.CBCountries = new System.Windows.Forms.ComboBox();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // MoodLbl
            // 
            this.MoodLbl.AutoSize = true;
            this.MoodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoodLbl.Location = new System.Drawing.Point(198, 11);
            this.MoodLbl.Name = "MoodLbl";
            this.MoodLbl.Size = new System.Drawing.Size(27, 29);
            this.MoodLbl.TabIndex = 0;
            this.MoodLbl.Text = "..";
            // 
            // ContactIDLbl
            // 
            this.ContactIDLbl.AutoSize = true;
            this.ContactIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactIDLbl.Location = new System.Drawing.Point(24, 73);
            this.ContactIDLbl.Name = "ContactIDLbl";
            this.ContactIDLbl.Size = new System.Drawing.Size(99, 22);
            this.ContactIDLbl.TabIndex = 1;
            this.ContactIDLbl.Text = "ContactID :";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.Location = new System.Drawing.Point(24, 125);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(102, 22);
            this.FirstNameLbl.TabIndex = 2;
            this.FirstNameLbl.Text = "First Name:";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(25, 182);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(101, 22);
            this.LastNameLbl.TabIndex = 3;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(31, 239);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(59, 22);
            this.EmailLbl.TabIndex = 4;
            this.EmailLbl.Text = "Email:";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLbl.Location = new System.Drawing.Point(26, 297);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(67, 22);
            this.PhoneLbl.TabIndex = 5;
            this.PhoneLbl.Text = "Phone:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(23, 354);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(119, 22);
            this.DateLbl.TabIndex = 6;
            this.DateLbl.Text = "Date Of Birth:";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLbl.Location = new System.Drawing.Point(24, 412);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(78, 22);
            this.CountryLbl.TabIndex = 7;
            this.CountryLbl.Text = "Country:";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.Location = new System.Drawing.Point(24, 468);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(81, 22);
            this.AddressLbl.TabIndex = 8;
            this.AddressLbl.Text = "Address:";
            // 
            // IDValue
            // 
            this.IDValue.AutoSize = true;
            this.IDValue.Location = new System.Drawing.Point(163, 77);
            this.IDValue.Name = "IDValue";
            this.IDValue.Size = new System.Drawing.Size(45, 20);
            this.IDValue.TabIndex = 9;
            this.IDValue.Text = "????";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameValue.Location = new System.Drawing.Point(167, 124);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(173, 26);
            this.FirstNameValue.TabIndex = 10;
            // 
            // LastNameValue
            // 
            this.LastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameValue.Location = new System.Drawing.Point(167, 180);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(173, 26);
            this.LastNameValue.TabIndex = 11;
            // 
            // EmailValue
            // 
            this.EmailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailValue.Location = new System.Drawing.Point(167, 236);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(173, 26);
            this.EmailValue.TabIndex = 12;
            // 
            // PhoneValue
            // 
            this.PhoneValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneValue.Location = new System.Drawing.Point(167, 294);
            this.PhoneValue.Name = "PhoneValue";
            this.PhoneValue.Size = new System.Drawing.Size(173, 26);
            this.PhoneValue.TabIndex = 13;
            // 
            // AddressValue
            // 
            this.AddressValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressValue.Location = new System.Drawing.Point(167, 468);
            this.AddressValue.Multiline = true;
            this.AddressValue.Name = "AddressValue";
            this.AddressValue.Size = new System.Drawing.Size(173, 83);
            this.AddressValue.TabIndex = 15;
            // 
            // dateTimeValue
            // 
            this.dateTimeValue.Location = new System.Drawing.Point(167, 350);
            this.dateTimeValue.Name = "dateTimeValue";
            this.dateTimeValue.Size = new System.Drawing.Size(305, 26);
            this.dateTimeValue.TabIndex = 16;
            // 
            // CBCountries
            // 
            this.CBCountries.FormattingEnabled = true;
            this.CBCountries.Location = new System.Drawing.Point(167, 406);
            this.CBCountries.Name = "CBCountries";
            this.CBCountries.Size = new System.Drawing.Size(203, 28);
            this.CBCountries.TabIndex = 17;
            // 
            // Pb1
            // 
            this.Pb1.Location = new System.Drawing.Point(379, 130);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(196, 193);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb1.TabIndex = 18;
            this.Pb1.TabStop = false;
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(389, 77);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(83, 20);
            this.llSetImage.TabIndex = 19;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll1SetImage_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // llRemove
            // 
            this.llRemove.AutoSize = true;
            this.llRemove.Location = new System.Drawing.Point(507, 77);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(68, 20);
            this.llRemove.TabIndex = 20;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlRemove_LinkClicked);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Location = new System.Drawing.Point(179, 585);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(115, 54);
            this.Cancelbtn.TabIndex = 21;
            this.Cancelbtn.Text = "Close";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(357, 585);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(115, 54);
            this.Savebtn.TabIndex = 22;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // FrmAddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 651);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.llRemove);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.CBCountries);
            this.Controls.Add(this.dateTimeValue);
            this.Controls.Add(this.AddressValue);
            this.Controls.Add(this.PhoneValue);
            this.Controls.Add(this.EmailValue);
            this.Controls.Add(this.LastNameValue);
            this.Controls.Add(this.FirstNameValue);
            this.Controls.Add(this.IDValue);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.ContactIDLbl);
            this.Controls.Add(this.MoodLbl);
            this.Name = "FrmAddEditContact";
            this.Text = "Add/EditContact";
            this.Load += new System.EventHandler(this.FrmAddEditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoodLbl;
        private System.Windows.Forms.Label ContactIDLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label IDValue;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.TextBox PhoneValue;
        private System.Windows.Forms.TextBox AddressValue;
        private System.Windows.Forms.DateTimePicker dateTimeValue;
        private System.Windows.Forms.ComboBox CBCountries;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Savebtn;
    }
}