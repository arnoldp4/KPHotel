namespace KPHotel
{
    partial class MasterForm
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnKamar = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(197, 122);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(222, 43);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "User Menu";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnKamar
            // 
            this.btnKamar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKamar.Location = new System.Drawing.Point(197, 171);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.Size = new System.Drawing.Size(222, 43);
            this.btnKamar.TabIndex = 8;
            this.btnKamar.Text = "Kamar Menu";
            this.btnKamar.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(197, 220);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(222, 43);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Booking Menu";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.Location = new System.Drawing.Point(197, 269);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(222, 43);
            this.btnTrans.TabIndex = 10;
            this.btnTrans.Text = "Transaksi Menu";
            this.btnTrans.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(523, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 43);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Logout";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KPHotel.Properties.Resources.bgimage;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnKamar);
            this.Controls.Add(this.btnUser);
            this.Name = "MasterForm";
            this.Text = "Master Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnKamar;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnExit;
    }
}