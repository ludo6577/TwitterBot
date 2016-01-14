namespace TwitterBot
{
    partial class Form1
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
            this.ConsumerKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsumerSecret = new System.Windows.Forms.TextBox();
            this.TwitterAccessToken = new System.Windows.Forms.TextBox();
            this.TwitterAccessTokenSecret = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FollowingCount = new System.Windows.Forms.Label();
            this.FollowerCount = new System.Windows.Forms.Label();
            this.NotFollowingCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.StatusTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ConsumerKey
            // 
            this.ConsumerKey.Location = new System.Drawing.Point(167, 12);
            this.ConsumerKey.Name = "ConsumerKey";
            this.ConsumerKey.Size = new System.Drawing.Size(217, 20);
            this.ConsumerKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consumer Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consumer Secret ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Twitter Access Token ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Twitter Access Token Secret ";
            // 
            // ConsumerSecret
            // 
            this.ConsumerSecret.Location = new System.Drawing.Point(167, 38);
            this.ConsumerSecret.Name = "ConsumerSecret";
            this.ConsumerSecret.Size = new System.Drawing.Size(217, 20);
            this.ConsumerSecret.TabIndex = 5;
            // 
            // TwitterAccessToken
            // 
            this.TwitterAccessToken.Location = new System.Drawing.Point(167, 64);
            this.TwitterAccessToken.Name = "TwitterAccessToken";
            this.TwitterAccessToken.Size = new System.Drawing.Size(217, 20);
            this.TwitterAccessToken.TabIndex = 6;
            // 
            // TwitterAccessTokenSecret
            // 
            this.TwitterAccessTokenSecret.Location = new System.Drawing.Point(167, 90);
            this.TwitterAccessTokenSecret.Name = "TwitterAccessTokenSecret";
            this.TwitterAccessTokenSecret.Size = new System.Drawing.Size(217, 20);
            this.TwitterAccessTokenSecret.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Following:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Followers:";
            // 
            // FollowingCount
            // 
            this.FollowingCount.AutoSize = true;
            this.FollowingCount.Location = new System.Drawing.Point(72, 160);
            this.FollowingCount.Name = "FollowingCount";
            this.FollowingCount.Size = new System.Drawing.Size(27, 13);
            this.FollowingCount.TabIndex = 11;
            this.FollowingCount.Text = "N/C";
            // 
            // FollowerCount
            // 
            this.FollowerCount.AutoSize = true;
            this.FollowerCount.Location = new System.Drawing.Point(189, 160);
            this.FollowerCount.Name = "FollowerCount";
            this.FollowerCount.Size = new System.Drawing.Size(27, 13);
            this.FollowerCount.TabIndex = 12;
            this.FollowerCount.Text = "N/C";
            // 
            // NotFollowingCount
            // 
            this.NotFollowingCount.AutoSize = true;
            this.NotFollowingCount.Location = new System.Drawing.Point(356, 160);
            this.NotFollowingCount.Name = "NotFollowingCount";
            this.NotFollowingCount.Size = new System.Drawing.Size(27, 13);
            this.NotFollowingCount.TabIndex = 14;
            this.NotFollowingCount.Text = "N/C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Not Following back:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Auto Unfollow";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonUnfollow_Click);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Location = new System.Drawing.Point(12, 222);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(384, 221);
            this.StatusTextBox.TabIndex = 16;
            this.StatusTextBox.Text = "Status...\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 455);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NotFollowingCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FollowerCount);
            this.Controls.Add(this.FollowingCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TwitterAccessTokenSecret);
            this.Controls.Add(this.TwitterAccessToken);
            this.Controls.Add(this.ConsumerSecret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsumerKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsumerKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConsumerSecret;
        private System.Windows.Forms.TextBox TwitterAccessToken;
        private System.Windows.Forms.TextBox TwitterAccessTokenSecret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FollowingCount;
        private System.Windows.Forms.Label FollowerCount;
        private System.Windows.Forms.Label NotFollowingCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox StatusTextBox;
    }
}

