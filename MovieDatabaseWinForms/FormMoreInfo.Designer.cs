namespace MovieDatabaseWinForms
{
    partial class FormMoreInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoreInfo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelPlot = new System.Windows.Forms.Label();
            this.labelActors = new System.Windows.Forms.Label();
            this.labelWriter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRated = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelReleased = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRuntime = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelRating, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelPlot, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelActors, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelWriter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDirector, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelRating, 2);
            this.labelRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRating.Location = new System.Drawing.Point(3, 487);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(564, 56);
            this.labelRating.TabIndex = 6;
            this.labelRating.Text = "Rating: ";
            // 
            // labelPlot
            // 
            this.labelPlot.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelPlot, 2);
            this.labelPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlot.Location = new System.Drawing.Point(3, 433);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(564, 54);
            this.labelPlot.TabIndex = 5;
            this.labelPlot.Text = "Plot: ";
            // 
            // labelActors
            // 
            this.labelActors.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelActors, 2);
            this.labelActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelActors.Location = new System.Drawing.Point(3, 379);
            this.labelActors.Name = "labelActors";
            this.labelActors.Size = new System.Drawing.Size(564, 54);
            this.labelActors.TabIndex = 4;
            this.labelActors.Text = "Actors: ";
            // 
            // labelWriter
            // 
            this.labelWriter.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelWriter, 2);
            this.labelWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWriter.Location = new System.Drawing.Point(3, 325);
            this.labelWriter.Name = "labelWriter";
            this.labelWriter.Size = new System.Drawing.Size(564, 54);
            this.labelWriter.TabIndex = 3;
            this.labelWriter.Text = "Writer: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelRated, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelReleased, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelRuntime, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelGenre, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(288, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 265);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(3, 26);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(273, 24);
            this.labelTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rated:";
            // 
            // labelRated
            // 
            this.labelRated.AutoSize = true;
            this.labelRated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRated.Location = new System.Drawing.Point(3, 76);
            this.labelRated.Name = "labelRated";
            this.labelRated.Size = new System.Drawing.Size(273, 30);
            this.labelRated.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Released:";
            // 
            // labelReleased
            // 
            this.labelReleased.AutoSize = true;
            this.labelReleased.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReleased.Location = new System.Drawing.Point(3, 129);
            this.labelReleased.Name = "labelReleased";
            this.labelReleased.Size = new System.Drawing.Size(273, 30);
            this.labelReleased.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Runtime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Genre:";
            // 
            // labelRuntime
            // 
            this.labelRuntime.AutoSize = true;
            this.labelRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRuntime.Location = new System.Drawing.Point(3, 182);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(273, 30);
            this.labelRuntime.TabIndex = 8;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGenre.Location = new System.Drawing.Point(3, 235);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(273, 30);
            this.labelGenre.TabIndex = 9;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelDirector, 2);
            this.labelDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDirector.Location = new System.Drawing.Point(3, 271);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(564, 54);
            this.labelDirector.TabIndex = 2;
            this.labelDirector.Text = "Director: ";
            // 
            // FormMoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMoreInfo";
            this.Text = "MoreInfo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Label labelActors;
        private System.Windows.Forms.Label labelWriter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelReleased;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRuntime;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDirector;
    }
}