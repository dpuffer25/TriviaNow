namespace TriviaNow
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.questionLabel = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctScoreLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.questionsLeftLabel = new System.Windows.Forms.Label();
            this.questionsLeftNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(21, 124);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(57, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA.ForeColor = System.Drawing.Color.White;
            this.radioButtonA.Location = new System.Drawing.Point(25, 152);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(33, 17);
            this.radioButtonA.TabIndex = 1;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = false;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonB.ForeColor = System.Drawing.Color.White;
            this.radioButtonB.Location = new System.Drawing.Point(24, 190);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(33, 17);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = false;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonC.ForeColor = System.Drawing.Color.White;
            this.radioButtonC.Location = new System.Drawing.Point(24, 228);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(33, 17);
            this.radioButtonC.TabIndex = 3;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = false;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonD.ForeColor = System.Drawing.Color.White;
            this.radioButtonD.Location = new System.Drawing.Point(24, 271);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(34, 17);
            this.radioButtonD.TabIndex = 4;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(464, 289);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctScoreLabel
            // 
            this.correctScoreLabel.AutoSize = true;
            this.correctScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.correctScoreLabel.ForeColor = System.Drawing.Color.White;
            this.correctScoreLabel.Location = new System.Drawing.Point(526, 322);
            this.correctScoreLabel.Name = "correctScoreLabel";
            this.correctScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.correctScoreLabel.TabIndex = 7;
            this.correctScoreLabel.Text = "0";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.BackColor = System.Drawing.Color.Transparent;
            this.correctLabel.ForeColor = System.Drawing.Color.White;
            this.correctLabel.Location = new System.Drawing.Point(486, 322);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(44, 13);
            this.correctLabel.TabIndex = 8;
            this.correctLabel.Text = "Correct:";
            // 
            // questionsLeftLabel
            // 
            this.questionsLeftLabel.AutoSize = true;
            this.questionsLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionsLeftLabel.ForeColor = System.Drawing.Color.White;
            this.questionsLeftLabel.Location = new System.Drawing.Point(21, 322);
            this.questionsLeftLabel.Name = "questionsLeftLabel";
            this.questionsLeftLabel.Size = new System.Drawing.Size(52, 13);
            this.questionsLeftLabel.TabIndex = 9;
            this.questionsLeftLabel.Text = "Question:";
            // 
            // questionsLeftNum
            // 
            this.questionsLeftNum.AutoSize = true;
            this.questionsLeftNum.BackColor = System.Drawing.Color.Transparent;
            this.questionsLeftNum.ForeColor = System.Drawing.Color.Transparent;
            this.questionsLeftNum.Location = new System.Drawing.Point(70, 322);
            this.questionsLeftNum.Name = "questionsLeftNum";
            this.questionsLeftNum.Size = new System.Drawing.Size(13, 13);
            this.questionsLeftNum.TabIndex = 10;
            this.questionsLeftNum.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "/3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionsLeftNum);
            this.Controls.Add(this.questionsLeftLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.correctScoreLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.questionLabel);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label correctScoreLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label questionsLeftLabel;
        private System.Windows.Forms.Label questionsLeftNum;
        private System.Windows.Forms.Label label1;
    }
}