
namespace Hello_World_2._0
{
    partial class hello_world
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
            this.hello_world_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.red_rbtn = new System.Windows.Forms.RadioButton();
            this.blue_rbtn = new System.Windows.Forms.RadioButton();
            this.food_cbox = new System.Windows.Forms.ComboBox();
            this.question_lbl = new System.Windows.Forms.Label();
            this.other_cbx = new System.Windows.Forms.CheckBox();
            this.dog_cbx = new System.Windows.Forms.CheckBox();
            this.cat_cbx = new System.Windows.Forms.CheckBox();
            this.other_lbl = new System.Windows.Forms.Label();
            this.other_answer_tbx = new System.Windows.Forms.TextBox();
            this.color_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hello_world_lbl
            // 
            this.hello_world_lbl.AutoSize = true;
            this.hello_world_lbl.Font = new System.Drawing.Font("Papyrus", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello_world_lbl.Location = new System.Drawing.Point(120, 0);
            this.hello_world_lbl.Name = "hello_world_lbl";
            this.hello_world_lbl.Size = new System.Drawing.Size(594, 151);
            this.hello_world_lbl.TabIndex = 0;
            this.hello_world_lbl.Text = "Hello world!!";
            this.hello_world_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(392, 416);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 1;
            this.submit_btn.Text = "submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // red_rbtn
            // 
            this.red_rbtn.AutoSize = true;
            this.red_rbtn.Location = new System.Drawing.Point(112, 192);
            this.red_rbtn.Name = "red_rbtn";
            this.red_rbtn.Size = new System.Drawing.Size(45, 17);
            this.red_rbtn.TabIndex = 4;
            this.red_rbtn.TabStop = true;
            this.red_rbtn.Text = "Red";
            this.red_rbtn.UseVisualStyleBackColor = true;
            // 
            // blue_rbtn
            // 
            this.blue_rbtn.AutoSize = true;
            this.blue_rbtn.Location = new System.Drawing.Point(112, 176);
            this.blue_rbtn.Name = "blue_rbtn";
            this.blue_rbtn.Size = new System.Drawing.Size(45, 17);
            this.blue_rbtn.TabIndex = 5;
            this.blue_rbtn.TabStop = true;
            this.blue_rbtn.Text = "blue";
            this.blue_rbtn.UseVisualStyleBackColor = true;
            // 
            // food_cbox
            // 
            this.food_cbox.FormattingEnabled = true;
            this.food_cbox.Items.AddRange(new object[] {
            "apple",
            "orange",
            "pear",
            "bannana"});
            this.food_cbox.Location = new System.Drawing.Point(336, 176);
            this.food_cbox.Name = "food_cbox";
            this.food_cbox.Size = new System.Drawing.Size(121, 21);
            this.food_cbox.TabIndex = 8;
            this.food_cbox.Text = "choose one";
            this.food_cbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // question_lbl
            // 
            this.question_lbl.AutoSize = true;
            this.question_lbl.Location = new System.Drawing.Point(648, 176);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(99, 13);
            this.question_lbl.TabIndex = 9;
            this.question_lbl.Text = "Select all that apply";
            // 
            // other_cbx
            // 
            this.other_cbx.AutoSize = true;
            this.other_cbx.Location = new System.Drawing.Point(648, 224);
            this.other_cbx.Name = "other_cbx";
            this.other_cbx.Size = new System.Drawing.Size(52, 17);
            this.other_cbx.TabIndex = 10;
            this.other_cbx.Text = "Other";
            this.other_cbx.UseVisualStyleBackColor = true;
            // 
            // dog_cbx
            // 
            this.dog_cbx.AutoSize = true;
            this.dog_cbx.Location = new System.Drawing.Point(648, 192);
            this.dog_cbx.Name = "dog_cbx";
            this.dog_cbx.Size = new System.Drawing.Size(80, 17);
            this.dog_cbx.TabIndex = 11;
            this.dog_cbx.Text = "have a dog";
            this.dog_cbx.UseVisualStyleBackColor = true;
            // 
            // cat_cbx
            // 
            this.cat_cbx.AutoSize = true;
            this.cat_cbx.Location = new System.Drawing.Point(648, 208);
            this.cat_cbx.Name = "cat_cbx";
            this.cat_cbx.Size = new System.Drawing.Size(77, 17);
            this.cat_cbx.TabIndex = 12;
            this.cat_cbx.Text = "have a cat";
            this.cat_cbx.UseVisualStyleBackColor = true;
            // 
            // other_lbl
            // 
            this.other_lbl.AutoSize = true;
            this.other_lbl.Location = new System.Drawing.Point(648, 240);
            this.other_lbl.Name = "other_lbl";
            this.other_lbl.Size = new System.Drawing.Size(107, 13);
            this.other_lbl.TabIndex = 13;
            this.other_lbl.Text = "If other explain below";
            // 
            // other_answer_tbx
            // 
            this.other_answer_tbx.Location = new System.Drawing.Point(640, 256);
            this.other_answer_tbx.Multiline = true;
            this.other_answer_tbx.Name = "other_answer_tbx";
            this.other_answer_tbx.Size = new System.Drawing.Size(136, 104);
            this.other_answer_tbx.TabIndex = 14;
            // 
            // color_lbl
            // 
            this.color_lbl.AutoSize = true;
            this.color_lbl.Location = new System.Drawing.Point(104, 160);
            this.color_lbl.Name = "color_lbl";
            this.color_lbl.Size = new System.Drawing.Size(57, 13);
            this.color_lbl.TabIndex = 15;
            this.color_lbl.Text = "red or blue";
            // 
            // hello_world
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.color_lbl);
            this.Controls.Add(this.other_answer_tbx);
            this.Controls.Add(this.other_lbl);
            this.Controls.Add(this.cat_cbx);
            this.Controls.Add(this.dog_cbx);
            this.Controls.Add(this.other_cbx);
            this.Controls.Add(this.question_lbl);
            this.Controls.Add(this.food_cbox);
            this.Controls.Add(this.blue_rbtn);
            this.Controls.Add(this.red_rbtn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.hello_world_lbl);
            this.Name = "hello_world";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.hello_world_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello_world_lbl;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.RadioButton red_rbtn;
        private System.Windows.Forms.RadioButton blue_rbtn;
        private System.Windows.Forms.ComboBox food_cbox;
        private System.Windows.Forms.Label question_lbl;
        private System.Windows.Forms.CheckBox other_cbx;
        private System.Windows.Forms.CheckBox dog_cbx;
        private System.Windows.Forms.CheckBox cat_cbx;
        private System.Windows.Forms.Label other_lbl;
        private System.Windows.Forms.TextBox other_answer_tbx;
        private System.Windows.Forms.Label color_lbl;
    }
}

