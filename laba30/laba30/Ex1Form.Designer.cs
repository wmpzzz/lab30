namespace laba30
{
    partial class Ex1Form
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
            WassupBroButton = new Button();
            CloseFormButton = new Button();
            SuspendLayout();
            // 
            // WassupBroButton
            // 
            WassupBroButton.Location = new Point(264, 99);
            WassupBroButton.Name = "WassupBroButton";
            WassupBroButton.Size = new Size(234, 82);
            WassupBroButton.TabIndex = 0;
            WassupBroButton.Text = "ПРИВЕТ БРАТИШКА";
            WassupBroButton.UseVisualStyleBackColor = true;
            WassupBroButton.Click += WassupBroButton_Click;
            WassupBroButton.KeyPress += WassupBroButton_KeyPress;
            // 
            // CloseFormButton
            // 
            CloseFormButton.Location = new Point(264, 236);
            CloseFormButton.Name = "CloseFormButton";
            CloseFormButton.Size = new Size(234, 95);
            CloseFormButton.TabIndex = 1;
            CloseFormButton.Text = "ЗАКРЫТЬ";
            CloseFormButton.UseVisualStyleBackColor = true;
            CloseFormButton.Click += CloseFormButton_Click;
            CloseFormButton.KeyPress += CloseFormButton_KeyPress;
            // 
            // Ex1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseFormButton);
            Controls.Add(WassupBroButton);
            Name = "Ex1Form";
            Text = "ПРИВЕТ ПОКА";
            ResumeLayout(false);
        }

        #endregion

        private Button WassupBroButton;
        private Button CloseFormButton;
    }
}