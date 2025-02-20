namespace ChessClient
{
    partial class FormChooseMode
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
            ChessMode = new Button();
            Chess960Mode = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ChessMode
            // 
            ChessMode.Anchor = AnchorStyles.Top;
            ChessMode.BackColor = Color.DodgerBlue;
            ChessMode.FlatStyle = FlatStyle.Flat;
            ChessMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChessMode.Location = new Point(241, 204);
            ChessMode.Name = "ChessMode";
            ChessMode.Size = new Size(250, 50);
            ChessMode.TabIndex = 0;
            ChessMode.Text = "Chess";
            ChessMode.UseVisualStyleBackColor = false;
            ChessMode.Click += ChessMode_Click;
            // 
            // Chess960Mode
            // 
            Chess960Mode.Anchor = AnchorStyles.Top;
            Chess960Mode.BackColor = Color.DodgerBlue;
            Chess960Mode.FlatStyle = FlatStyle.Flat;
            Chess960Mode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Chess960Mode.Location = new Point(241, 311);
            Chess960Mode.Name = "Chess960Mode";
            Chess960Mode.Size = new Size(250, 50);
            Chess960Mode.TabIndex = 1;
            Chess960Mode.Text = "Chess960";
            Chess960Mode.UseVisualStyleBackColor = false;
            Chess960Mode.Click += Chess960Mode_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 90);
            label1.Name = "label1";
            label1.Size = new Size(424, 52);
            label1.TabIndex = 2;
            label1.Text = "Choose Game Mode";
            // 
            // FormChooseMode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 529);
            Controls.Add(label1);
            Controls.Add(Chess960Mode);
            Controls.Add(ChessMode);
            Name = "FormChooseMode";
            Text = "Choose Game Mode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChessMode;
        private Button Chess960Mode;
        private Label label1;
    }
}