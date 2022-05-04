
namespace Decorator_pattern_Demo
{
    partial class BubbleTea
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BubbleTea));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbBubble = new System.Windows.Forms.CheckBox();
            this.cbBlackSugar = new System.Windows.Forms.CheckBox();
            this.cbJelly = new System.Windows.Forms.CheckBox();
            this.cbFruitPudding = new System.Windows.Forms.CheckBox();
            this.cbFlanCake = new System.Windows.Forms.CheckBox();
            this.lbtotalCost = new System.Windows.Forms.Label();
            this.bubbleee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleee)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbBubble
            // 
            this.cbBubble.AutoSize = true;
            this.cbBubble.BackColor = System.Drawing.Color.Transparent;
            this.cbBubble.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBubble.ForeColor = System.Drawing.Color.White;
            this.cbBubble.Location = new System.Drawing.Point(311, 710);
            this.cbBubble.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBubble.Name = "cbBubble";
            this.cbBubble.Size = new System.Drawing.Size(111, 31);
            this.cbBubble.TabIndex = 2;
            this.cbBubble.Text = "Bubble";
            this.cbBubble.UseVisualStyleBackColor = false;
            // 
            // cbBlackSugar
            // 
            this.cbBlackSugar.AutoSize = true;
            this.cbBlackSugar.BackColor = System.Drawing.Color.Transparent;
            this.cbBlackSugar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlackSugar.ForeColor = System.Drawing.Color.White;
            this.cbBlackSugar.Location = new System.Drawing.Point(372, 536);
            this.cbBlackSugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBlackSugar.Name = "cbBlackSugar";
            this.cbBlackSugar.Size = new System.Drawing.Size(167, 31);
            this.cbBlackSugar.TabIndex = 3;
            this.cbBlackSugar.Text = "Black sugar";
            this.cbBlackSugar.UseVisualStyleBackColor = false;
            // 
            // cbJelly
            // 
            this.cbJelly.AutoSize = true;
            this.cbJelly.BackColor = System.Drawing.Color.Transparent;
            this.cbJelly.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJelly.ForeColor = System.Drawing.Color.White;
            this.cbJelly.Location = new System.Drawing.Point(112, 710);
            this.cbJelly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbJelly.Name = "cbJelly";
            this.cbJelly.Size = new System.Drawing.Size(90, 31);
            this.cbJelly.TabIndex = 4;
            this.cbJelly.Text = "Jelly";
            this.cbJelly.UseVisualStyleBackColor = false;
            // 
            // cbFruitPudding
            // 
            this.cbFruitPudding.AutoSize = true;
            this.cbFruitPudding.BackColor = System.Drawing.Color.Transparent;
            this.cbFruitPudding.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFruitPudding.ForeColor = System.Drawing.Color.White;
            this.cbFruitPudding.Location = new System.Drawing.Point(27, 522);
            this.cbFruitPudding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFruitPudding.Name = "cbFruitPudding";
            this.cbFruitPudding.Size = new System.Drawing.Size(124, 58);
            this.cbFruitPudding.TabIndex = 5;
            this.cbFruitPudding.Text = "Fruit  \r\nPudding";
            this.cbFruitPudding.UseVisualStyleBackColor = false;
            // 
            // cbFlanCake
            // 
            this.cbFlanCake.AutoSize = true;
            this.cbFlanCake.BackColor = System.Drawing.Color.Transparent;
            this.cbFlanCake.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlanCake.ForeColor = System.Drawing.Color.White;
            this.cbFlanCake.Location = new System.Drawing.Point(206, 536);
            this.cbFlanCake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFlanCake.Name = "cbFlanCake";
            this.cbFlanCake.Size = new System.Drawing.Size(135, 31);
            this.cbFlanCake.TabIndex = 6;
            this.cbFlanCake.Text = "Flan cake";
            this.cbFlanCake.UseVisualStyleBackColor = false;
            // 
            // lbtotalCost
            // 
            this.lbtotalCost.AutoSize = true;
            this.lbtotalCost.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalCost.Location = new System.Drawing.Point(910, 122);
            this.lbtotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtotalCost.Name = "lbtotalCost";
            this.lbtotalCost.Size = new System.Drawing.Size(105, 23);
            this.lbtotalCost.TabIndex = 9;
            this.lbtotalCost.Text = "20000 VND";
            // 
            // bubbleee
            // 
            this.bubbleee.BackColor = System.Drawing.Color.Transparent;
            this.bubbleee.Image = ((System.Drawing.Image)(resources.GetObject("bubbleee.Image")));
            this.bubbleee.Location = new System.Drawing.Point(821, 12);
            this.bubbleee.Name = "bubbleee";
            this.bubbleee.Size = new System.Drawing.Size(279, 294);
            this.bubbleee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bubbleee.TabIndex = 10;
            this.bubbleee.TabStop = false;
            this.bubbleee.Click += new System.EventHandler(this.bubbleee_Click);
            // 
            // BubbleTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.lbtotalCost);
            this.Controls.Add(this.cbFlanCake);
            this.Controls.Add(this.cbFruitPudding);
            this.Controls.Add(this.cbJelly);
            this.Controls.Add(this.cbBlackSugar);
            this.Controls.Add(this.cbBubble);
            this.Controls.Add(this.bubbleee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BubbleTea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milk Tea";
            ((System.ComponentModel.ISupportInitialize)(this.bubbleee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox cbBubble;
        private System.Windows.Forms.CheckBox cbBlackSugar;
        private System.Windows.Forms.CheckBox cbJelly;
        private System.Windows.Forms.CheckBox cbFruitPudding;
        private System.Windows.Forms.CheckBox cbFlanCake;
        private System.Windows.Forms.Label lbtotalCost;
        private System.Windows.Forms.PictureBox bubbleee;
    }
}

