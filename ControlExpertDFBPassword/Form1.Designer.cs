namespace ControlExpertDFBPassword
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            PCB_Schneider = new PictureBox();
            label1 = new Label();
            TxtBPassword = new TextBox();
            BtnFind = new Button();
            TxtBResult = new TextBox();
            GrpResearch = new GroupBox();
            GrpResult = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PCB_Schneider).BeginInit();
            GrpResearch.SuspendLayout();
            GrpResult.SuspendLayout();
            SuspendLayout();
            // 
            // PCB_Schneider
            // 
            PCB_Schneider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PCB_Schneider.BorderStyle = BorderStyle.FixedSingle;
            PCB_Schneider.Image = (Image)resources.GetObject("PCB_Schneider.Image");
            PCB_Schneider.Location = new Point(40, 12);
            PCB_Schneider.Name = "PCB_Schneider";
            PCB_Schneider.Size = new Size(362, 182);
            PCB_Schneider.SizeMode = PictureBoxSizeMode.AutoSize;
            PCB_Schneider.TabIndex = 0;
            PCB_Schneider.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(383, 15);
            label1.TabIndex = 1;
            label1.Text = "Veuillez renseigner le mot de passe trouvé dans le fichier \"PathBase.db\":";
            // 
            // TxtBPassword
            // 
            TxtBPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBPassword.Location = new Point(6, 37);
            TxtBPassword.Name = "TxtBPassword";
            TxtBPassword.Size = new Size(404, 23);
            TxtBPassword.TabIndex = 2;
            TxtBPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnFind
            // 
            BtnFind.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFind.Location = new Point(7, 66);
            BtnFind.Name = "BtnFind";
            BtnFind.Size = new Size(403, 23);
            BtnFind.TabIndex = 4;
            BtnFind.Text = "Rechercher le mot de passe";
            BtnFind.UseVisualStyleBackColor = true;
            BtnFind.Click += BtnFind_Click;
            // 
            // TxtBResult
            // 
            TxtBResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBResult.Location = new Point(6, 22);
            TxtBResult.Name = "TxtBResult";
            TxtBResult.Size = new Size(404, 23);
            TxtBResult.TabIndex = 5;
            TxtBResult.TextAlign = HorizontalAlignment.Center;
            // 
            // GrpResearch
            // 
            GrpResearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrpResearch.Controls.Add(TxtBPassword);
            GrpResearch.Controls.Add(label1);
            GrpResearch.Controls.Add(BtnFind);
            GrpResearch.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            GrpResearch.Location = new Point(12, 204);
            GrpResearch.Name = "GrpResearch";
            GrpResearch.Size = new Size(416, 100);
            GrpResearch.TabIndex = 7;
            GrpResearch.TabStop = false;
            GrpResearch.Text = "Recherche: ";
            // 
            // GrpResult
            // 
            GrpResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrpResult.Controls.Add(label2);
            GrpResult.Controls.Add(TxtBResult);
            GrpResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            GrpResult.Location = new Point(12, 310);
            GrpResult.Name = "GrpResult";
            GrpResult.Size = new Size(416, 76);
            GrpResult.TabIndex = 8;
            GrpResult.TabStop = false;
            GrpResult.Text = "Résultat: ";
            GrpResult.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 48);
            label2.Name = "label2";
            label2.Size = new Size(287, 15);
            label2.TabIndex = 5;
            label2.Text = "Le mot de passe a été copié dans votre presse-papier!";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 391);
            Controls.Add(GrpResult);
            Controls.Add(GrpResearch);
            Controls.Add(PCB_Schneider);
            MaximizeBox = false;
            Name = "Main";
            Text = "Recupération du mot de passe d'un DFB";
            ((System.ComponentModel.ISupportInitialize)PCB_Schneider).EndInit();
            GrpResearch.ResumeLayout(false);
            GrpResearch.PerformLayout();
            GrpResult.ResumeLayout(false);
            GrpResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PCB_Schneider;
        private Label label1;
        private TextBox TxtBPassword;
        private Button BtnFind;
        private TextBox TxtBResult;
        private GroupBox GrpResearch;
        private GroupBox GrpResult;
        private Label label2;
    }
}
