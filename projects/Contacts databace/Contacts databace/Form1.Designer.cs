
namespace Contacts_databace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label contact_IdLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleInitialLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label personalLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label jobTitleLabel;
            System.Windows.Forms.Label lastContactLabel;
            this.lbl_Logo_hp = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.da_databeseDataSet = new Contacts_databace.da_databeseDataSet();
            this.contactsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsInfoTableAdapter = new Contacts_databace.da_databeseDataSetTableAdapters.ContactsInfoTableAdapter();
            this.tableAdapterManager = new Contacts_databace.da_databeseDataSetTableAdapters.TableAdapterManager();
            this.contactsInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contactsInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contact_IdTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleInitialTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.personalCheckBox = new System.Windows.Forms.CheckBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.lastContactDateTimePicker = new System.Windows.Forms.DateTimePicker();
            contact_IdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleInitialLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            personalLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            jobTitleLabel = new System.Windows.Forms.Label();
            lastContactLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Logo_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da_databeseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingNavigator)).BeginInit();
            this.contactsInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Logo_hp
            // 
            this.lbl_Logo_hp.Image = global::Contacts_databace.Properties.Resources._1200px_HP_logo_2012_svg;
            this.lbl_Logo_hp.Location = new System.Drawing.Point(639, 343);
            this.lbl_Logo_hp.Name = "lbl_Logo_hp";
            this.lbl_Logo_hp.Size = new System.Drawing.Size(167, 110);
            this.lbl_Logo_hp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_Logo_hp.TabIndex = 18;
            this.lbl_Logo_hp.TabStop = false;
            this.lbl_Logo_hp.Click += new System.EventHandler(this.lbl_Logo_hp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Something";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // da_databeseDataSet
            // 
            this.da_databeseDataSet.DataSetName = "da_databeseDataSet";
            this.da_databeseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsInfoBindingSource
            // 
            this.contactsInfoBindingSource.DataMember = "ContactsInfo";
            this.contactsInfoBindingSource.DataSource = this.da_databeseDataSet;
            // 
            // contactsInfoTableAdapter
            // 
            this.contactsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactsInfoTableAdapter = this.contactsInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contacts_databace.da_databeseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactsInfoBindingNavigator
            // 
            this.contactsInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactsInfoBindingNavigator.BindingSource = this.contactsInfoBindingSource;
            this.contactsInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactsInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contactsInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactsInfoBindingNavigatorSaveItem});
            this.contactsInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contactsInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactsInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactsInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactsInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactsInfoBindingNavigator.Name = "contactsInfoBindingNavigator";
            this.contactsInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactsInfoBindingNavigator.Size = new System.Drawing.Size(850, 25);
            this.contactsInfoBindingNavigator.TabIndex = 20;
            this.contactsInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contactsInfoBindingNavigatorSaveItem
            // 
            this.contactsInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsInfoBindingNavigatorSaveItem.Image")));
            this.contactsInfoBindingNavigatorSaveItem.Name = "contactsInfoBindingNavigatorSaveItem";
            this.contactsInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.contactsInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.contactsInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsInfoBindingNavigatorSaveItem_Click);
            // 
            // contact_IdLabel
            // 
            contact_IdLabel.AutoSize = true;
            contact_IdLabel.Location = new System.Drawing.Point(15, 48);
            contact_IdLabel.Name = "contact_IdLabel";
            contact_IdLabel.Size = new System.Drawing.Size(58, 13);
            contact_IdLabel.TabIndex = 20;
            contact_IdLabel.Text = "contact Id:";
            // 
            // contact_IdTextBox
            // 
            this.contact_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "contact_Id", true));
            this.contact_IdTextBox.Location = new System.Drawing.Point(79, 45);
            this.contact_IdTextBox.Name = "contact_IdTextBox";
            this.contact_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_IdTextBox.TabIndex = 21;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(207, 48);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(57, 13);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "first Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(270, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(393, 48);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(57, 13);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(456, 45);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // middleInitialLabel
            // 
            middleInitialLabel.AutoSize = true;
            middleInitialLabel.Location = new System.Drawing.Point(582, 48);
            middleInitialLabel.Name = "middleInitialLabel";
            middleInitialLabel.Size = new System.Drawing.Size(67, 13);
            middleInitialLabel.TabIndex = 23;
            middleInitialLabel.Text = "middle Initial:";
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "middleInitial", true));
            this.middleInitialTextBox.Location = new System.Drawing.Point(655, 45);
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleInitialTextBox.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(39, 104);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(79, 101);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 25;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(205, 104);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(80, 13);
            phoneNumberLabel.TabIndex = 25;
            phoneNumberLabel.Text = "phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(291, 101);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 26;
            // 
            // personalLabel
            // 
            personalLabel.AutoSize = true;
            personalLabel.Location = new System.Drawing.Point(409, 104);
            personalLabel.Name = "personalLabel";
            personalLabel.Size = new System.Drawing.Size(88, 13);
            personalLabel.TabIndex = 27;
            personalLabel.Text = "personal number:";
            // 
            // personalCheckBox
            // 
            this.personalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contactsInfoBindingSource, "personal", true));
            this.personalCheckBox.Location = new System.Drawing.Point(503, 99);
            this.personalCheckBox.Name = "personalCheckBox";
            this.personalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.personalCheckBox.TabIndex = 28;
            this.personalCheckBox.Text = "checkBox1";
            this.personalCheckBox.UseVisualStyleBackColor = true;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(596, 104);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(53, 13);
            companyLabel.TabIndex = 28;
            companyLabel.Text = "company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "company", true));
            this.companyTextBox.Location = new System.Drawing.Point(655, 101);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 29;
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(40, 153);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 29;
            dOBLabel.Text = "DOB:";
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsInfoBindingSource, "DOB", true));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(79, 149);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dOBDateTimePicker.TabIndex = 30;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new System.Drawing.Point(306, 152);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new System.Drawing.Size(47, 13);
            jobTitleLabel.TabIndex = 30;
            jobTitleLabel.Text = "job Title:";
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "jobTitle", true));
            this.jobTitleTextBox.Location = new System.Drawing.Point(359, 149);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTitleTextBox.TabIndex = 31;
            // 
            // lastContactLabel
            // 
            lastContactLabel.AutoSize = true;
            lastContactLabel.Location = new System.Drawing.Point(483, 153);
            lastContactLabel.Name = "lastContactLabel";
            lastContactLabel.Size = new System.Drawing.Size(66, 13);
            lastContactLabel.TabIndex = 31;
            lastContactLabel.Text = "last Contact:";
            // 
            // lastContactDateTimePicker
            // 
            this.lastContactDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsInfoBindingSource, "lastContact", true));
            this.lastContactDateTimePicker.Location = new System.Drawing.Point(555, 149);
            this.lastContactDateTimePicker.Name = "lastContactDateTimePicker";
            this.lastContactDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastContactDateTimePicker.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 473);
            this.Controls.Add(lastContactLabel);
            this.Controls.Add(this.lastContactDateTimePicker);
            this.Controls.Add(jobTitleLabel);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(personalLabel);
            this.Controls.Add(this.personalCheckBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(middleInitialLabel);
            this.Controls.Add(this.middleInitialTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(contact_IdLabel);
            this.Controls.Add(this.contact_IdTextBox);
            this.Controls.Add(this.contactsInfoBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Logo_hp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Logo_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da_databeseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingNavigator)).EndInit();
            this.contactsInfoBindingNavigator.ResumeLayout(false);
            this.contactsInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox lbl_Logo_hp;
        private System.Windows.Forms.Button button1;
        private da_databeseDataSet da_databeseDataSet;
        private System.Windows.Forms.BindingSource contactsInfoBindingSource;
        private da_databeseDataSetTableAdapters.ContactsInfoTableAdapter contactsInfoTableAdapter;
        private da_databeseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contactsInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contactsInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contact_IdTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleInitialTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.CheckBox personalCheckBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.DateTimePicker lastContactDateTimePicker;
    }
}

