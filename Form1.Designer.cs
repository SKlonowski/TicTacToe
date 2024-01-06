
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Obrazek = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pkt_o = new System.Windows.Forms.Label();
            this.pkt_x = new System.Windows.Forms.Label();
            this.Punktacja = new System.Windows.Forms.TextBox();
            this.gracz_o = new System.Windows.Forms.Label();
            this.gracz_x = new System.Windows.Forms.Label();
            this.Nowa_Gra = new System.Windows.Forms.Button();
            this.Zamknij_Gre = new System.Windows.Forms.Button();
            this.Informacje = new System.Windows.Forms.Button();
            this.Panel_Plansza = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pole1 = new System.Windows.Forms.Button();
            this.Pole4 = new System.Windows.Forms.Button();
            this.Pole9 = new System.Windows.Forms.Button();
            this.Pole7 = new System.Windows.Forms.Button();
            this.Pole6 = new System.Windows.Forms.Button();
            this.Pole3 = new System.Windows.Forms.Button();
            this.Pole2 = new System.Windows.Forms.Button();
            this.Pole8 = new System.Windows.Forms.Button();
            this.Pole5 = new System.Windows.Forms.Button();
            this.Gracz = new System.Windows.Forms.Label();
            this.Tura = new System.Windows.Forms.Label();
            this.Panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panel_Plansza.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.Controls.Add(this.Obrazek);
            this.Panel_Menu.Controls.Add(this.panel1);
            this.Panel_Menu.Controls.Add(this.Nowa_Gra);
            this.Panel_Menu.Controls.Add(this.Zamknij_Gre);
            this.Panel_Menu.Controls.Add(this.Informacje);
            this.Panel_Menu.Location = new System.Drawing.Point(429, 2);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(200, 438);
            this.Panel_Menu.TabIndex = 2;
            this.Panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Menu_Paint);
            // 
            // Obrazek
            // 
            this.Obrazek.Image = global::TicTacToe.Properties.Resources.defaultImage;
            this.Obrazek.Location = new System.Drawing.Point(37, 162);
            this.Obrazek.Name = "Obrazek";
            this.Obrazek.Size = new System.Drawing.Size(120, 125);
            this.Obrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obrazek.TabIndex = 6;
            this.Obrazek.TabStop = false;
            this.Obrazek.Click += new System.EventHandler(this.Obrazek_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pkt_o);
            this.panel1.Controls.Add(this.pkt_x);
            this.panel1.Controls.Add(this.Punktacja);
            this.panel1.Controls.Add(this.gracz_o);
            this.panel1.Controls.Add(this.gracz_x);
            this.panel1.Location = new System.Drawing.Point(3, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 72);
            this.panel1.TabIndex = 9;
            // 
            // pkt_o
            // 
            this.pkt_o.AutoSize = true;
            this.pkt_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pkt_o.Location = new System.Drawing.Point(175, 40);
            this.pkt_o.Name = "pkt_o";
            this.pkt_o.Size = new System.Drawing.Size(17, 17);
            this.pkt_o.TabIndex = 11;
            this.pkt_o.Text = "0";
            this.pkt_o.Click += new System.EventHandler(this.pkt_o_Click);
            // 
            // pkt_x
            // 
            this.pkt_x.AutoSize = true;
            this.pkt_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pkt_x.Location = new System.Drawing.Point(75, 40);
            this.pkt_x.Name = "pkt_x";
            this.pkt_x.Size = new System.Drawing.Size(17, 17);
            this.pkt_x.TabIndex = 10;
            this.pkt_x.Text = "0";
            this.pkt_x.Click += new System.EventHandler(this.pkt_x_Click);
            // 
            // Punktacja
            // 
            this.Punktacja.BackColor = System.Drawing.SystemColors.Control;
            this.Punktacja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Punktacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Punktacja.Location = new System.Drawing.Point(55, 5);
            this.Punktacja.Name = "Punktacja";
            this.Punktacja.Size = new System.Drawing.Size(80, 19);
            this.Punktacja.TabIndex = 9;
            this.Punktacja.Text = "Punktacja Brawo! Udało Ci się odnaleźć Easter Egga";
            // 
            // gracz_o
            // 
            this.gracz_o.AutoSize = true;
            this.gracz_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gracz_o.Location = new System.Drawing.Point(100, 40);
            this.gracz_o.Name = "gracz_o";
            this.gracz_o.Size = new System.Drawing.Size(65, 17);
            this.gracz_o.TabIndex = 8;
            this.gracz_o.Text = "Gracz O:";
            // 
            // gracz_x
            // 
            this.gracz_x.AutoSize = true;
            this.gracz_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gracz_x.Location = new System.Drawing.Point(5, 40);
            this.gracz_x.Name = "gracz_x";
            this.gracz_x.Size = new System.Drawing.Size(63, 17);
            this.gracz_x.TabIndex = 7;
            this.gracz_x.Text = "Gracz X:";
            // 
            // Nowa_Gra
            // 
            this.Nowa_Gra.Location = new System.Drawing.Point(3, 16);
            this.Nowa_Gra.Name = "Nowa_Gra";
            this.Nowa_Gra.Size = new System.Drawing.Size(194, 67);
            this.Nowa_Gra.TabIndex = 5;
            this.Nowa_Gra.Text = "Nowa Gra";
            this.Nowa_Gra.UseVisualStyleBackColor = true;
            this.Nowa_Gra.Click += new System.EventHandler(this.Nowa_Gra_Click);
            // 
            // Zamknij_Gre
            // 
            this.Zamknij_Gre.Location = new System.Drawing.Point(3, 365);
            this.Zamknij_Gre.Name = "Zamknij_Gre";
            this.Zamknij_Gre.Size = new System.Drawing.Size(194, 66);
            this.Zamknij_Gre.TabIndex = 3;
            this.Zamknij_Gre.Text = "Wyjście z gry";
            this.Zamknij_Gre.UseVisualStyleBackColor = true;
            this.Zamknij_Gre.Click += new System.EventHandler(this.Zamknij_Gre_Click);
            // 
            // Informacje
            // 
            this.Informacje.Location = new System.Drawing.Point(3, 293);
            this.Informacje.Name = "Informacje";
            this.Informacje.Size = new System.Drawing.Size(194, 66);
            this.Informacje.TabIndex = 2;
            this.Informacje.Text = "Informacje";
            this.Informacje.UseVisualStyleBackColor = true;
            this.Informacje.Click += new System.EventHandler(this.Informacje_Click);
            // 
            // Panel_Plansza
            // 
            this.Panel_Plansza.Controls.Add(this.panel2);
            this.Panel_Plansza.Controls.Add(this.Gracz);
            this.Panel_Plansza.Controls.Add(this.Tura);
            this.Panel_Plansza.Location = new System.Drawing.Point(12, 2);
            this.Panel_Plansza.Name = "Panel_Plansza";
            this.Panel_Plansza.Size = new System.Drawing.Size(411, 438);
            this.Panel_Plansza.TabIndex = 3;
            this.Panel_Plansza.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Plansza_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Pole1);
            this.panel2.Controls.Add(this.Pole4);
            this.panel2.Controls.Add(this.Pole9);
            this.panel2.Controls.Add(this.Pole7);
            this.panel2.Controls.Add(this.Pole6);
            this.panel2.Controls.Add(this.Pole3);
            this.panel2.Controls.Add(this.Pole2);
            this.panel2.Controls.Add(this.Pole8);
            this.panel2.Controls.Add(this.Pole5);
            this.panel2.Location = new System.Drawing.Point(13, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 394);
            this.panel2.TabIndex = 11;
            // 
            // Pole1
            // 
            this.Pole1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole1.Location = new System.Drawing.Point(2, 2);
            this.Pole1.Margin = new System.Windows.Forms.Padding(0);
            this.Pole1.Name = "Pole1";
            this.Pole1.Size = new System.Drawing.Size(120, 120);
            this.Pole1.TabIndex = 0;
            this.Pole1.UseVisualStyleBackColor = true;
            this.Pole1.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole4
            // 
            this.Pole4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole4.Location = new System.Drawing.Point(2, 134);
            this.Pole4.Margin = new System.Windows.Forms.Padding(0);
            this.Pole4.Name = "Pole4";
            this.Pole4.Size = new System.Drawing.Size(120, 120);
            this.Pole4.TabIndex = 3;
            this.Pole4.UseVisualStyleBackColor = true;
            this.Pole4.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole9
            // 
            this.Pole9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole9.Location = new System.Drawing.Point(266, 266);
            this.Pole9.Margin = new System.Windows.Forms.Padding(0);
            this.Pole9.Name = "Pole9";
            this.Pole9.Size = new System.Drawing.Size(120, 120);
            this.Pole9.TabIndex = 8;
            this.Pole9.UseVisualStyleBackColor = true;
            this.Pole9.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole7
            // 
            this.Pole7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole7.Location = new System.Drawing.Point(2, 268);
            this.Pole7.Margin = new System.Windows.Forms.Padding(0);
            this.Pole7.Name = "Pole7";
            this.Pole7.Size = new System.Drawing.Size(120, 119);
            this.Pole7.TabIndex = 6;
            this.Pole7.UseVisualStyleBackColor = true;
            this.Pole7.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole6
            // 
            this.Pole6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole6.Location = new System.Drawing.Point(266, 134);
            this.Pole6.Margin = new System.Windows.Forms.Padding(0);
            this.Pole6.Name = "Pole6";
            this.Pole6.Size = new System.Drawing.Size(120, 120);
            this.Pole6.TabIndex = 5;
            this.Pole6.UseVisualStyleBackColor = true;
            this.Pole6.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole3
            // 
            this.Pole3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole3.Location = new System.Drawing.Point(266, 2);
            this.Pole3.Margin = new System.Windows.Forms.Padding(0);
            this.Pole3.Name = "Pole3";
            this.Pole3.Size = new System.Drawing.Size(120, 120);
            this.Pole3.TabIndex = 2;
            this.Pole3.UseVisualStyleBackColor = true;
            this.Pole3.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole2
            // 
            this.Pole2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole2.Location = new System.Drawing.Point(134, 2);
            this.Pole2.Margin = new System.Windows.Forms.Padding(0);
            this.Pole2.Name = "Pole2";
            this.Pole2.Size = new System.Drawing.Size(120, 120);
            this.Pole2.TabIndex = 1;
            this.Pole2.UseVisualStyleBackColor = true;
            this.Pole2.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole8
            // 
            this.Pole8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole8.Location = new System.Drawing.Point(134, 267);
            this.Pole8.Margin = new System.Windows.Forms.Padding(0);
            this.Pole8.Name = "Pole8";
            this.Pole8.Size = new System.Drawing.Size(120, 119);
            this.Pole8.TabIndex = 7;
            this.Pole8.UseVisualStyleBackColor = true;
            this.Pole8.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Pole5
            // 
            this.Pole5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole5.Location = new System.Drawing.Point(134, 134);
            this.Pole5.Margin = new System.Windows.Forms.Padding(0);
            this.Pole5.Name = "Pole5";
            this.Pole5.Size = new System.Drawing.Size(120, 120);
            this.Pole5.TabIndex = 4;
            this.Pole5.UseVisualStyleBackColor = true;
            this.Pole5.Click += new System.EventHandler(this.Pole_Click);
            // 
            // Gracz
            // 
            this.Gracz.AutoSize = true;
            this.Gracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gracz.Location = new System.Drawing.Point(323, 2);
            this.Gracz.Name = "Gracz";
            this.Gracz.Size = new System.Drawing.Size(40, 39);
            this.Gracz.TabIndex = 10;
            this.Gracz.Text = "X";
            this.Gracz.Click += new System.EventHandler(this.Gracz_Click);
            // 
            // Tura
            // 
            this.Tura.AutoSize = true;
            this.Tura.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tura.Location = new System.Drawing.Point(60, 2);
            this.Tura.Name = "Tura";
            this.Tura.Size = new System.Drawing.Size(207, 39);
            this.Tura.TabIndex = 9;
            this.Tura.Text = "Tura gracza:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 446);
            this.Controls.Add(this.Panel_Plansza);
            this.Controls.Add(this.Panel_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TicTacToe (Kółko i krzyżyk)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Plansza.ResumeLayout(false);
            this.Panel_Plansza.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Button Informacje;
        private System.Windows.Forms.Button Zamknij_Gre;
        private System.Windows.Forms.Button Nowa_Gra;
        private System.Windows.Forms.Panel Panel_Plansza;
        private System.Windows.Forms.PictureBox Obrazek;
        private System.Windows.Forms.Button Pole9;
        private System.Windows.Forms.Button Pole8;
        private System.Windows.Forms.Button Pole7;
        private System.Windows.Forms.Button Pole6;
        private System.Windows.Forms.Button Pole5;
        private System.Windows.Forms.Button Pole4;
        private System.Windows.Forms.Button Pole3;
        private System.Windows.Forms.Button Pole2;
        private System.Windows.Forms.Button Pole1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Punktacja;
        private System.Windows.Forms.Label gracz_o;
        private System.Windows.Forms.Label gracz_x;
        private System.Windows.Forms.Label pkt_o;
        private System.Windows.Forms.Label pkt_x;
        private System.Windows.Forms.Label Gracz;
        private System.Windows.Forms.Label Tura;
        private System.Windows.Forms.Panel panel2;
    }
}

