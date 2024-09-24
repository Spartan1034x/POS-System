namespace OOPProject
{
    partial class OrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dgvSnowboard = new System.Windows.Forms.DataGridView();
            this.snowButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.snowDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.snowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snowDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snowGoofy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.snowLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snowInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snowSale = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGolf = new System.Windows.Forms.DataGridView();
            this.golfAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.golfDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.golfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golfPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golfDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golfFlex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golfRightHanded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.golfStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golfOnSale = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnowboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.grpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1220, 648);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(140, 51);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dgvSnowboard
            // 
            this.dgvSnowboard.AllowUserToAddRows = false;
            this.dgvSnowboard.AllowUserToDeleteRows = false;
            this.dgvSnowboard.AllowUserToResizeColumns = false;
            this.dgvSnowboard.AllowUserToResizeRows = false;
            this.dgvSnowboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSnowboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snowButton,
            this.snowDelete,
            this.snowName,
            this.snowPrice,
            this.snowDescription,
            this.snowGoofy,
            this.snowLength,
            this.snowInStock,
            this.snowSale});
            this.dgvSnowboard.Location = new System.Drawing.Point(12, 74);
            this.dgvSnowboard.Name = "dgvSnowboard";
            this.dgvSnowboard.RowHeadersVisible = false;
            this.dgvSnowboard.RowHeadersWidth = 51;
            this.dgvSnowboard.RowTemplate.Height = 24;
            this.dgvSnowboard.Size = new System.Drawing.Size(1140, 264);
            this.dgvSnowboard.TabIndex = 1;
            this.dgvSnowboard.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSnowboard_CellMouseClick);
            this.dgvSnowboard.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSnowboard_CellValueChanged);
            // 
            // snowButton
            // 
            this.snowButton.HeaderText = "Add To Cart";
            this.snowButton.MinimumWidth = 6;
            this.snowButton.Name = "snowButton";
            this.snowButton.Width = 90;
            // 
            // snowDelete
            // 
            this.snowDelete.HeaderText = "Delete";
            this.snowDelete.MinimumWidth = 6;
            this.snowDelete.Name = "snowDelete";
            this.snowDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.snowDelete.Width = 60;
            // 
            // snowName
            // 
            this.snowName.HeaderText = "Name";
            this.snowName.MinimumWidth = 6;
            this.snowName.Name = "snowName";
            this.snowName.Width = 125;
            // 
            // snowPrice
            // 
            this.snowPrice.HeaderText = "Price";
            this.snowPrice.MinimumWidth = 6;
            this.snowPrice.Name = "snowPrice";
            this.snowPrice.Width = 65;
            // 
            // snowDescription
            // 
            this.snowDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.snowDescription.HeaderText = "Description";
            this.snowDescription.MinimumWidth = 6;
            this.snowDescription.Name = "snowDescription";
            // 
            // snowGoofy
            // 
            this.snowGoofy.HeaderText = "Goofy";
            this.snowGoofy.MinimumWidth = 6;
            this.snowGoofy.Name = "snowGoofy";
            this.snowGoofy.ReadOnly = true;
            this.snowGoofy.Width = 65;
            // 
            // snowLength
            // 
            this.snowLength.HeaderText = "Length";
            this.snowLength.MinimumWidth = 6;
            this.snowLength.Name = "snowLength";
            this.snowLength.ReadOnly = true;
            this.snowLength.Width = 125;
            // 
            // snowInStock
            // 
            this.snowInStock.HeaderText = "Stock";
            this.snowInStock.MinimumWidth = 6;
            this.snowInStock.Name = "snowInStock";
            this.snowInStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.snowInStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.snowInStock.Width = 65;
            // 
            // snowSale
            // 
            this.snowSale.HeaderText = "25% Off";
            this.snowSale.MinimumWidth = 6;
            this.snowSale.Name = "snowSale";
            this.snowSale.Width = 65;
            // 
            // dgvGolf
            // 
            this.dgvGolf.AllowUserToAddRows = false;
            this.dgvGolf.AllowUserToDeleteRows = false;
            this.dgvGolf.AllowUserToResizeColumns = false;
            this.dgvGolf.AllowUserToResizeRows = false;
            this.dgvGolf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGolf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.golfAdd,
            this.golfDelete,
            this.golfName,
            this.golfPrice,
            this.golfDescription,
            this.golfFlex,
            this.golfRightHanded,
            this.golfStock,
            this.golfOnSale});
            this.dgvGolf.Location = new System.Drawing.Point(12, 435);
            this.dgvGolf.Name = "dgvGolf";
            this.dgvGolf.RowHeadersVisible = false;
            this.dgvGolf.RowHeadersWidth = 51;
            this.dgvGolf.RowTemplate.Height = 24;
            this.dgvGolf.Size = new System.Drawing.Size(1140, 264);
            this.dgvGolf.TabIndex = 2;
            this.dgvGolf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGolf_CellContentClick);
            this.dgvGolf.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGolf_CellValueChanged);
            // 
            // golfAdd
            // 
            this.golfAdd.HeaderText = "Add To Cart";
            this.golfAdd.MinimumWidth = 6;
            this.golfAdd.Name = "golfAdd";
            this.golfAdd.Width = 90;
            // 
            // golfDelete
            // 
            this.golfDelete.HeaderText = "Delete";
            this.golfDelete.MinimumWidth = 6;
            this.golfDelete.Name = "golfDelete";
            this.golfDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.golfDelete.Width = 60;
            // 
            // golfName
            // 
            this.golfName.HeaderText = "Name";
            this.golfName.MinimumWidth = 6;
            this.golfName.Name = "golfName";
            this.golfName.Width = 125;
            // 
            // golfPrice
            // 
            this.golfPrice.HeaderText = "Price";
            this.golfPrice.MinimumWidth = 6;
            this.golfPrice.Name = "golfPrice";
            this.golfPrice.Width = 65;
            // 
            // golfDescription
            // 
            this.golfDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.golfDescription.HeaderText = "Description";
            this.golfDescription.MinimumWidth = 6;
            this.golfDescription.Name = "golfDescription";
            // 
            // golfFlex
            // 
            this.golfFlex.HeaderText = "Flex";
            this.golfFlex.MinimumWidth = 6;
            this.golfFlex.Name = "golfFlex";
            this.golfFlex.ReadOnly = true;
            this.golfFlex.Width = 125;
            // 
            // golfRightHanded
            // 
            this.golfRightHanded.HeaderText = "Right";
            this.golfRightHanded.MinimumWidth = 6;
            this.golfRightHanded.Name = "golfRightHanded";
            this.golfRightHanded.ReadOnly = true;
            this.golfRightHanded.Width = 65;
            // 
            // golfStock
            // 
            this.golfStock.HeaderText = "Stock";
            this.golfStock.MinimumWidth = 6;
            this.golfStock.Name = "golfStock";
            this.golfStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.golfStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.golfStock.Width = 65;
            // 
            // golfOnSale
            // 
            this.golfOnSale.HeaderText = "25% Off";
            this.golfOnSale.MinimumWidth = 6;
            this.golfOnSale.Name = "golfOnSale";
            this.golfOnSale.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1340, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cart";
            // 
            // btnCheck
            // 
            this.btnCheck.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(1415, 648);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(140, 51);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "&Check Out";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Snowboards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Golf Clubs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1216, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Items:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1370, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sub Total:";
            // 
            // txtItemCount
            // 
            this.txtItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCount.Location = new System.Drawing.Point(1280, 400);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.ReadOnly = true;
            this.txtItemCount.Size = new System.Drawing.Size(71, 28);
            this.txtItemCount.TabIndex = 10;
            this.txtItemCount.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1469, 400);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 28);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "$0.00";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartName,
            this.cartPrice,
            this.cartQuantity});
            this.dgvCart.Location = new System.Drawing.Point(1192, 45);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(388, 340);
            this.dgvCart.TabIndex = 12;
            // 
            // cartName
            // 
            this.cartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartName.HeaderText = "Name";
            this.cartName.MinimumWidth = 6;
            this.cartName.Name = "cartName";
            this.cartName.ReadOnly = true;
            // 
            // cartPrice
            // 
            this.cartPrice.HeaderText = "Price";
            this.cartPrice.MinimumWidth = 6;
            this.cartPrice.Name = "cartPrice";
            this.cartPrice.ReadOnly = true;
            this.cartPrice.Width = 75;
            // 
            // cartQuantity
            // 
            this.cartQuantity.HeaderText = "Quantity";
            this.cartQuantity.MinimumWidth = 6;
            this.cartQuantity.Name = "cartQuantity";
            this.cartQuantity.ReadOnly = true;
            this.cartQuantity.Width = 60;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 46);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add Items";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(250, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 46);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "L&oad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.btnClearAll);
            this.grpAdmin.Controls.Add(this.btnSave);
            this.grpAdmin.Controls.Add(this.btnAdd);
            this.grpAdmin.Controls.Add(this.btnLoad);
            this.grpAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdmin.Location = new System.Drawing.Point(1172, 482);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(408, 148);
            this.grpAdmin.TabIndex = 15;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin Tools";
            // 
            // btnClearAll
            // 
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(20, 85);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(133, 46);
            this.btnClearAll.TabIndex = 16;
            this.btnClearAll.Text = "Clea&r All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Visible = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(250, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 46);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdLoad
            // 
            this.ofdLoad.FileName = "products.xml";
            this.ofdLoad.Filter = "XML Files (*.xml)|*.xml";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1314, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 41);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Cl&ear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // sfd
            // 
            this.sfd.Filter = "XML Files (*.xml)|*.xml";
            // 
            // OrderScreen
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGolf);
            this.Controls.Add(this.dgvSnowboard);
            this.Controls.Add(this.btnLogOut);
            this.MinimumSize = new System.Drawing.Size(1610, 760);
            this.Name = "OrderScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderScreen by Rafe,Carter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderScreen_FormClosing);
            this.Load += new System.EventHandler(this.OrderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnowboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.grpAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvSnowboard;
        private System.Windows.Forms.DataGridView dgvGolf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemCount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn snowButton;
        private System.Windows.Forms.DataGridViewButtonColumn snowDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn snowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn snowPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn snowDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn snowGoofy;
        private System.Windows.Forms.DataGridViewTextBoxColumn snowLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn snowInStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn snowSale;
        private System.Windows.Forms.DataGridViewButtonColumn golfAdd;
        private System.Windows.Forms.DataGridViewButtonColumn golfDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn golfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn golfPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn golfDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn golfFlex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn golfRightHanded;
        private System.Windows.Forms.DataGridViewTextBoxColumn golfStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn golfOnSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnClearAll;
    }
}