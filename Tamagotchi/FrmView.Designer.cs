namespace Tamagotchi
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            BtnEat = new Button();
            BtnWalk = new Button();
            BtnPet = new Button();
            TbxTCharacteristics = new TextBox();
            PbxPet = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PbxPet).BeginInit();
            SuspendLayout();
            // 
            // BtnEat
            // 
            BtnEat.AutoSize = true;
            BtnEat.BackColor = Color.Ivory;
            BtnEat.Location = new Point(339, 75);
            BtnEat.MinimumSize = new Size(89, 52);
            BtnEat.Name = "BtnEat";
            BtnEat.Size = new Size(137, 57);
            BtnEat.TabIndex = 0;
            BtnEat.Text = "Покормить питомца";
            BtnEat.UseVisualStyleBackColor = false;
            BtnEat.Click += BtnEat_Click;
            // 
            // BtnWalk
            // 
            BtnWalk.AutoSize = true;
            BtnWalk.BackColor = Color.Ivory;
            BtnWalk.Location = new Point(339, 154);
            BtnWalk.Name = "BtnWalk";
            BtnWalk.Size = new Size(137, 57);
            BtnWalk.TabIndex = 1;
            BtnWalk.Text = "Погулять с питомцем";
            BtnWalk.UseVisualStyleBackColor = false;
            BtnWalk.Click += BtnWalk_Click;
            // 
            // BtnPet
            // 
            BtnPet.AutoSize = true;
            BtnPet.BackColor = Color.Ivory;
            BtnPet.Location = new Point(339, 236);
            BtnPet.Name = "BtnPet";
            BtnPet.Size = new Size(137, 57);
            BtnPet.TabIndex = 2;
            BtnPet.Text = "Погладить питомца";
            BtnPet.UseVisualStyleBackColor = false;
            BtnPet.Click += BtnPet_Click;
            // 
            // TbxTCharacteristics
            // 
            TbxTCharacteristics.Anchor = AnchorStyles.Right;
            TbxTCharacteristics.Location = new Point(505, 38);
            TbxTCharacteristics.Multiline = true;
            TbxTCharacteristics.Name = "TbxTCharacteristics";
            TbxTCharacteristics.ReadOnly = true;
            TbxTCharacteristics.Size = new Size(283, 347);
            TbxTCharacteristics.TabIndex = 3;
            // 
            // PbxPet
            // 
            PbxPet.Anchor = AnchorStyles.Left;
            PbxPet.Image = (Image)resources.GetObject("PbxPet.Image");
            PbxPet.Location = new Point(41, 66);
            PbxPet.MinimumSize = new Size(251, 264);
            PbxPet.Name = "PbxPet";
            PbxPet.Size = new Size(251, 264);
            PbxPet.SizeMode = PictureBoxSizeMode.Zoom;
            PbxPet.TabIndex = 4;
            PbxPet.TabStop = false;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(PbxPet);
            Controls.Add(TbxTCharacteristics);
            Controls.Add(BtnPet);
            Controls.Add(BtnWalk);
            Controls.Add(BtnEat);
            MinimumSize = new Size(816, 489);
            Name = "FrmView";
            Text = "Тамагочи";
            Load += FrmView_Load;
            Resize += FrmView_Resize;
            ((System.ComponentModel.ISupportInitialize)PbxPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEat;
        private Button BtnWalk;
        private Button BtnPet;
        private TextBox TbxTCharacteristics;
        private PictureBox PbxPet;
    }
}