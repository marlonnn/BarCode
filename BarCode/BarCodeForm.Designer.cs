namespace BarCode
{
    partial class BarCodeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCodeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDecodeBarCode = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEncodeBarCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnDecodeBarCode);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEncodeBarCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbEncodeType);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 431);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(138, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 46);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(16, 23);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(35, 21);
            this.txtWidth.TabIndex = 43;
            this.txtWidth.Text = "300";
            this.txtWidth.TextChanged += new System.EventHandler(this.BarWidth_TectChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 41;
            this.label7.Text = "宽度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "高度";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(59, 23);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(35, 21);
            this.txtHeight.TabIndex = 44;
            this.txtHeight.Text = "150";
            this.txtHeight.TextChanged += new System.EventHandler(this.BarHeight_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "x";
            // 
            // btnDecodeBarCode
            // 
            this.btnDecodeBarCode.Location = new System.Drawing.Point(138, 150);
            this.btnDecodeBarCode.Name = "btnDecodeBarCode";
            this.btnDecodeBarCode.Size = new System.Drawing.Size(114, 34);
            this.btnDecodeBarCode.TabIndex = 70;
            this.btnDecodeBarCode.Text = "解析编码";
            this.btnDecodeBarCode.UseVisualStyleBackColor = true;
            this.btnDecodeBarCode.Click += new System.EventHandler(this.btnDecodeBarCode_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(247, 33);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "保存为图像";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEncodeBarCode
            // 
            this.btnEncodeBarCode.Location = new System.Drawing.Point(5, 150);
            this.btnEncodeBarCode.Name = "btnEncodeBarCode";
            this.btnEncodeBarCode.Size = new System.Drawing.Size(114, 34);
            this.btnEncodeBarCode.TabIndex = 68;
            this.btnEncodeBarCode.Text = "生成编码";
            this.btnEncodeBarCode.UseVisualStyleBackColor = true;
            this.btnEncodeBarCode.Click += new System.EventHandler(this.btnEncodeBarCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 67;
            this.label3.Text = "编码格式：";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.ItemHeight = 12;
            this.cbEncodeType.Location = new System.Drawing.Point(7, 67);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(108, 20);
            this.cbEncodeType.TabIndex = 66;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(5, 23);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(247, 21);
            this.txtData.TabIndex = 59;
            this.txtData.Text = "038000356216";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编码值：";
            // 
            // barcode
            // 
            this.barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.barcode.Location = new System.Drawing.Point(281, 5);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(477, 431);
            this.barcode.TabIndex = 37;
            this.barcode.TabStop = false;
            this.barcode.Text = "条形码/二维码：";
            // 
            // BarCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 439);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarCodeForm";
            this.Text = "BarCode";
            this.Load += new System.EventHandler(this.BarCodeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEncodeBarCode;
        private System.Windows.Forms.GroupBox barcode;
        private System.Windows.Forms.Button btnDecodeBarCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label9;
    }
}

