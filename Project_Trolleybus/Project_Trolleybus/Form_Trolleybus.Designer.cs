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
            buttonCreateCar = new Button();
            comboBoxStrategy = new ComboBox();
            buttonStrategyStep = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrolleybus).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTrolleybus
            // 
            pictureBoxTrolleybus.Dock = DockStyle.Fill;
            pictureBoxTrolleybus.Location = new Point(0, 0);
            pictureBoxTrolleybus.Name = "pictureBoxTrolleybus";
            pictureBoxTrolleybus.Size = new Size(1044, 591);
            pictureBoxTrolleybus.TabIndex = 0;
            pictureBoxTrolleybus.TabStop = false;
            // 
            // buttonCreateTrolleybus
            // 
            buttonCreateTrolleybus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateTrolleybus.Location = new Point(27, 544);
            buttonCreateTrolleybus.Name = "buttonCreateTrolleybus";
            buttonCreateTrolleybus.Size = new Size(248, 23);
            buttonCreateTrolleybus.TabIndex = 1;
            buttonCreateTrolleybus.Text = "Создать троллейбус";
            buttonCreateTrolleybus.UseVisualStyleBackColor = true;
            buttonCreateTrolleybus.Click += ButtonCreateTrolleybus_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = Properties.Resources.arrowLeft;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Location = new Point(901, 532);
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
            buttonRight.Location = new Point(983, 532);
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
            buttonDown.Location = new Point(942, 532);
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
            buttonUp.Location = new Point(942, 493);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 5;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // buttonCreateCar
            // 
            buttonCreateCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateCar.Location = new Point(290, 544);
            buttonCreateCar.Name = "buttonCreateCar";
            buttonCreateCar.Size = new Size(248, 23);
            buttonCreateCar.TabIndex = 6;
            buttonCreateCar.Text = "Создать автобус";
            buttonCreateCar.UseVisualStyleBackColor = true;
            buttonCreateCar.Click += ButtonCreateCar_Click;
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Items.AddRange(new object[] { "К центру", "К краю" });
            comboBoxStrategy.Location = new Point(911, 12);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(121, 23);
            comboBoxStrategy.TabIndex = 7;
            // 
            // buttonStrategyStep
            // 
            buttonStrategyStep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStrategyStep.Location = new Point(957, 41);
            buttonStrategyStep.Name = "buttonStrategyStep";
            buttonStrategyStep.Size = new Size(75, 23);
            buttonStrategyStep.TabIndex = 8;
            buttonStrategyStep.Text = "Шаг";
            buttonStrategyStep.UseVisualStyleBackColor = true;
            buttonStrategyStep.Click += ButtonStrategyStep_Click;
            // 
            // Form_Trolleybus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 591);
            Controls.Add(buttonStrategyStep);
            Controls.Add(comboBoxStrategy);
            Controls.Add(buttonCreateCar);
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
        private Button buttonCreateCar;
        private ComboBox comboBoxStrategy;
        private Button buttonStrategyStep;
    }
}