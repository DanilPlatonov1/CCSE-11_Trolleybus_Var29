namespace Project_Trolleybus
{
    partial class Form_Trolleybus
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
            pictureBoxTrolleybus = new PictureBox();
            buttonCreateTrolleybus = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            buttonDown = new Button();
            buttonUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrolleybus).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTrolleybus
            // 
            pictureBoxTrolleybus.Dock = DockStyle.Fill;
            pictureBoxTrolleybus.Location = new Point(0, 0);
            pictureBoxTrolleybus.Name = "pictureBoxTrolleybus";
            pictureBoxTrolleybus.Size = new Size(1027, 591);
            pictureBoxTrolleybus.TabIndex = 0;
            pictureBoxTrolleybus.TabStop = false;
            // 
            // buttonCreateTrolleybus
            // 
            buttonCreateTrolleybus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateTrolleybus.Location = new Point(27, 544);
            buttonCreateTrolleybus.Name = "buttonCreateTrolleybus";
            buttonCreateTrolleybus.Size = new Size(75, 23);
            buttonCreateTrolleybus.TabIndex = 1;
            buttonCreateTrolleybus.Text = "Создать";
            buttonCreateTrolleybus.UseVisualStyleBackColor = true;
            buttonCreateTrolleybus.Click += ButtonCreateTrolleybus_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = Properties.Resources.arrowLeft;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Location = new Point(884, 532);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(35, 35);
            buttonLeft.TabIndex = 2;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.BackgroundImage = Properties.Resources.arrowRight;
            buttonRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRight.Location = new Point(966, 532);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 35);
            buttonRight.TabIndex = 3;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = Properties.Resources.arrowDown;
            buttonDown.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDown.Location = new Point(925, 532);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 35);
            buttonDown.TabIndex = 4;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMove_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.BackgroundImage = Properties.Resources.arrowUp;
            buttonUp.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUp.Location = new Point(925, 493);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 5;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // Form_Trolleybus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 591);
            Controls.Add(buttonUp);
            Controls.Add(buttonDown);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(buttonCreateTrolleybus);
            Controls.Add(pictureBoxTrolleybus);
            Name = "Form_Trolleybus";
            Text = "Троллейбус";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrolleybus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxTrolleybus;
        private Button buttonCreateTrolleybus;
        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonDown;
        private Button buttonUp;
    }
}