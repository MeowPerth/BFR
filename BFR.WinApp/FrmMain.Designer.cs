namespace BFR.WinApp
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblMsg = new System.Windows.Forms.Label();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lnklblLastedVersion = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FilesList = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.setBox = new System.Windows.Forms.GroupBox();
            this.num_radioButton = new System.Windows.Forms.RadioButton();
            this.replace_radioButton = new System.Windows.Forms.RadioButton();
            this.creatinfo_checkBox = new System.Windows.Forms.CheckBox();
            this.ext_checkBox = new System.Windows.Forms.CheckBox();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.cbBak = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extBox = new System.Windows.Forms.GroupBox();
            this.rbtnLower = new System.Windows.Forms.RadioButton();
            this.rbtnUpper = new System.Windows.Forms.RadioButton();
            this.creatinfoBox = new System.Windows.Forms.GroupBox();
            this.tbModifiedTime = new System.Windows.Forms.TextBox();
            this.dtpModifiedTime = new System.Windows.Forms.DateTimePicker();
            this.tbCreateTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.GroupBox();
            this.retain_name_right = new System.Windows.Forms.RadioButton();
            this.retain_name_left = new System.Windows.Forms.RadioButton();
            this.retain_name = new System.Windows.Forms.CheckBox();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.nudBit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Right_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Left_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.replaceBox = new System.Windows.Forms.GroupBox();
            this.tbReplaceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReplacedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.setBox.SuspendLayout();
            this.extBox.SuspendLayout();
            this.creatinfoBox.SuspendLayout();
            this.numBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBit)).BeginInit();
            this.replaceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(3, 4);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(29, 12);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "就绪";
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkAbout.Location = new System.Drawing.Point(532, 4);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(31, 12);
            this.lnkAbout.TabIndex = 10;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "关于";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.Location = new System.Drawing.Point(571, 4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 12);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "v1.0.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.lnklblLastedVersion);
            this.panel1.Controls.Add(this.lnkAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 20);
            this.panel1.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(287, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            this.progressBar1.TabIndex = 12;
            // 
            // lnklblLastedVersion
            // 
            this.lnklblLastedVersion.AutoSize = true;
            this.lnklblLastedVersion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnklblLastedVersion.Location = new System.Drawing.Point(462, 4);
            this.lnklblLastedVersion.Name = "lnklblLastedVersion";
            this.lnklblLastedVersion.Size = new System.Drawing.Size(57, 12);
            this.lnklblLastedVersion.TabIndex = 10;
            this.lnklblLastedVersion.TabStop = true;
            this.lnklblLastedVersion.Text = "最新版本";
            this.lnklblLastedVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLastedVersion_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FilesList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 525);
            this.panel3.TabIndex = 14;
            // 
            // FilesList
            // 
            this.FilesList.BackColor = System.Drawing.SystemColors.Window;
            this.FilesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.FullName});
            this.FilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesList.FullRowSelect = true;
            this.FilesList.GridLines = true;
            this.FilesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FilesList.HideSelection = false;
            this.FilesList.Location = new System.Drawing.Point(0, 0);
            this.FilesList.Name = "FilesList";
            this.FilesList.ShowItemToolTips = true;
            this.FilesList.Size = new System.Drawing.Size(372, 525);
            this.FilesList.TabIndex = 4;
            this.FilesList.UseCompatibleStateImageBehavior = false;
            this.FilesList.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "序号";
            this.No.Width = 45;
            // 
            // FullName
            // 
            this.FullName.Text = "文件";
            this.FullName.Width = 310;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.setBox);
            this.panel2.Controls.Add(this.extBox);
            this.panel2.Controls.Add(this.creatinfoBox);
            this.panel2.Controls.Add(this.numBox);
            this.panel2.Controls.Add(this.replaceBox);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(372, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 525);
            this.panel2.TabIndex = 13;
            // 
            // setBox
            // 
            this.setBox.Controls.Add(this.num_radioButton);
            this.setBox.Controls.Add(this.replace_radioButton);
            this.setBox.Controls.Add(this.creatinfo_checkBox);
            this.setBox.Controls.Add(this.ext_checkBox);
            this.setBox.Controls.Add(this.btnSelectFiles);
            this.setBox.Controls.Add(this.cbBak);
            this.setBox.Controls.Add(this.label1);
            this.setBox.Location = new System.Drawing.Point(8, 10);
            this.setBox.Name = "setBox";
            this.setBox.Size = new System.Drawing.Size(239, 80);
            this.setBox.TabIndex = 8;
            this.setBox.TabStop = false;
            this.setBox.Text = "功能选择";
            // 
            // num_radioButton
            // 
            this.num_radioButton.AutoSize = true;
            this.num_radioButton.Location = new System.Drawing.Point(9, 57);
            this.num_radioButton.Name = "num_radioButton";
            this.num_radioButton.Size = new System.Drawing.Size(47, 16);
            this.num_radioButton.TabIndex = 10;
            this.num_radioButton.Text = "序号";
            this.num_radioButton.UseVisualStyleBackColor = true;
            // 
            // replace_radioButton
            // 
            this.replace_radioButton.AutoSize = true;
            this.replace_radioButton.Checked = true;
            this.replace_radioButton.Location = new System.Drawing.Point(9, 38);
            this.replace_radioButton.Name = "replace_radioButton";
            this.replace_radioButton.Size = new System.Drawing.Size(47, 16);
            this.replace_radioButton.TabIndex = 9;
            this.replace_radioButton.TabStop = true;
            this.replace_radioButton.Text = "替换";
            this.replace_radioButton.UseVisualStyleBackColor = true;
            this.replace_radioButton.CheckedChanged += new System.EventHandler(this.replace_radioButton_CheckedChanged);
            // 
            // creatinfo_checkBox
            // 
            this.creatinfo_checkBox.AutoSize = true;
            this.creatinfo_checkBox.Location = new System.Drawing.Point(149, 58);
            this.creatinfo_checkBox.Name = "creatinfo_checkBox";
            this.creatinfo_checkBox.Size = new System.Drawing.Size(72, 16);
            this.creatinfo_checkBox.TabIndex = 8;
            this.creatinfo_checkBox.Text = "创建信息";
            this.creatinfo_checkBox.UseVisualStyleBackColor = true;
            this.creatinfo_checkBox.CheckedChanged += new System.EventHandler(this.creatinfo_checkBox_CheckedChanged);
            // 
            // ext_checkBox
            // 
            this.ext_checkBox.AutoSize = true;
            this.ext_checkBox.Location = new System.Drawing.Point(149, 38);
            this.ext_checkBox.Name = "ext_checkBox";
            this.ext_checkBox.Size = new System.Drawing.Size(60, 16);
            this.ext_checkBox.TabIndex = 7;
            this.ext_checkBox.Text = "扩展名";
            this.ext_checkBox.UseVisualStyleBackColor = true;
            this.ext_checkBox.CheckedChanged += new System.EventHandler(this.ext_checkBox_CheckedChanged);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(68, 12);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(58, 23);
            this.btnSelectFiles.TabIndex = 5;
            this.btnSelectFiles.Text = "浏览";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            // 
            // cbBak
            // 
            this.cbBak.AutoSize = true;
            this.cbBak.Location = new System.Drawing.Point(149, 16);
            this.cbBak.Name = "cbBak";
            this.cbBak.Size = new System.Drawing.Size(84, 16);
            this.cbBak.TabIndex = 6;
            this.cbBak.Text = "备份原文件";
            this.cbBak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择文件:";
            // 
            // extBox
            // 
            this.extBox.Controls.Add(this.rbtnLower);
            this.extBox.Controls.Add(this.rbtnUpper);
            this.extBox.Enabled = false;
            this.extBox.Location = new System.Drawing.Point(8, 336);
            this.extBox.Name = "extBox";
            this.extBox.Size = new System.Drawing.Size(239, 47);
            this.extBox.TabIndex = 7;
            this.extBox.TabStop = false;
            this.extBox.Text = "扩展名";
            // 
            // rbtnLower
            // 
            this.rbtnLower.AutoSize = true;
            this.rbtnLower.Location = new System.Drawing.Point(134, 20);
            this.rbtnLower.Name = "rbtnLower";
            this.rbtnLower.Size = new System.Drawing.Size(95, 16);
            this.rbtnLower.TabIndex = 0;
            this.rbtnLower.Text = "字母变为小写";
            this.rbtnLower.UseVisualStyleBackColor = true;
            // 
            // rbtnUpper
            // 
            this.rbtnUpper.AutoSize = true;
            this.rbtnUpper.Location = new System.Drawing.Point(9, 20);
            this.rbtnUpper.Name = "rbtnUpper";
            this.rbtnUpper.Size = new System.Drawing.Size(95, 16);
            this.rbtnUpper.TabIndex = 0;
            this.rbtnUpper.Text = "字母变为大写";
            this.rbtnUpper.UseVisualStyleBackColor = true;
            // 
            // creatinfoBox
            // 
            this.creatinfoBox.Controls.Add(this.tbModifiedTime);
            this.creatinfoBox.Controls.Add(this.dtpModifiedTime);
            this.creatinfoBox.Controls.Add(this.tbCreateTime);
            this.creatinfoBox.Controls.Add(this.label10);
            this.creatinfoBox.Controls.Add(this.dtpCreateTime);
            this.creatinfoBox.Controls.Add(this.label9);
            this.creatinfoBox.Enabled = false;
            this.creatinfoBox.Location = new System.Drawing.Point(8, 389);
            this.creatinfoBox.Name = "creatinfoBox";
            this.creatinfoBox.Size = new System.Drawing.Size(239, 70);
            this.creatinfoBox.TabIndex = 7;
            this.creatinfoBox.TabStop = false;
            this.creatinfoBox.Text = "创建信息";
            // 
            // tbModifiedTime
            // 
            this.tbModifiedTime.Location = new System.Drawing.Point(82, 43);
            this.tbModifiedTime.Name = "tbModifiedTime";
            this.tbModifiedTime.Size = new System.Drawing.Size(129, 21);
            this.tbModifiedTime.TabIndex = 5;
            this.tbModifiedTime.Text = "2016-04-02 23:11:59";
            // 
            // dtpModifiedTime
            // 
            this.dtpModifiedTime.Location = new System.Drawing.Point(211, 43);
            this.dtpModifiedTime.Name = "dtpModifiedTime";
            this.dtpModifiedTime.Size = new System.Drawing.Size(18, 21);
            this.dtpModifiedTime.TabIndex = 7;
            // 
            // tbCreateTime
            // 
            this.tbCreateTime.Location = new System.Drawing.Point(82, 17);
            this.tbCreateTime.Name = "tbCreateTime";
            this.tbCreateTime.Size = new System.Drawing.Size(129, 21);
            this.tbCreateTime.TabIndex = 5;
            this.tbCreateTime.Text = "2016-04-02 23:11:59";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "修改时间:";
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.Location = new System.Drawing.Point(211, 17);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(18, 21);
            this.dtpCreateTime.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "创建时间:";
            // 
            // numBox
            // 
            this.numBox.Controls.Add(this.retain_name_right);
            this.numBox.Controls.Add(this.retain_name_left);
            this.numBox.Controls.Add(this.retain_name);
            this.numBox.Controls.Add(this.nudStart);
            this.numBox.Controls.Add(this.nudBit);
            this.numBox.Controls.Add(this.label7);
            this.numBox.Controls.Add(this.Right_Name);
            this.numBox.Controls.Add(this.label6);
            this.numBox.Controls.Add(this.label4);
            this.numBox.Controls.Add(this.Left_Name);
            this.numBox.Controls.Add(this.label5);
            this.numBox.Enabled = false;
            this.numBox.Location = new System.Drawing.Point(8, 182);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(239, 148);
            this.numBox.TabIndex = 2;
            this.numBox.TabStop = false;
            this.numBox.Text = "序号";
            // 
            // retain_name_right
            // 
            this.retain_name_right.AutoSize = true;
            this.retain_name_right.Enabled = false;
            this.retain_name_right.Location = new System.Drawing.Point(134, 126);
            this.retain_name_right.Name = "retain_name_right";
            this.retain_name_right.Size = new System.Drawing.Size(83, 16);
            this.retain_name_right.TabIndex = 10;
            this.retain_name_right.Text = "原命名在后";
            this.retain_name_right.UseVisualStyleBackColor = true;
            // 
            // retain_name_left
            // 
            this.retain_name_left.AutoSize = true;
            this.retain_name_left.Checked = true;
            this.retain_name_left.Enabled = false;
            this.retain_name_left.Location = new System.Drawing.Point(9, 126);
            this.retain_name_left.Name = "retain_name_left";
            this.retain_name_left.Size = new System.Drawing.Size(83, 16);
            this.retain_name_left.TabIndex = 9;
            this.retain_name_left.TabStop = true;
            this.retain_name_left.Text = "原命名在前";
            this.retain_name_left.UseVisualStyleBackColor = true;
            // 
            // retain_name
            // 
            this.retain_name.AutoSize = true;
            this.retain_name.Location = new System.Drawing.Point(9, 104);
            this.retain_name.Name = "retain_name";
            this.retain_name.Size = new System.Drawing.Size(84, 16);
            this.retain_name.TabIndex = 8;
            this.retain_name.Text = "保留原命名";
            this.retain_name.UseVisualStyleBackColor = true;
            this.retain_name.CheckedChanged += new System.EventHandler(this.retain_name_CheckedChanged);
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(182, 74);
            this.nudStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(47, 21);
            this.nudStart.TabIndex = 7;
            this.nudStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBit
            // 
            this.nudBit.Location = new System.Drawing.Point(63, 74);
            this.nudBit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBit.Name = "nudBit";
            this.nudBit.Size = new System.Drawing.Size(48, 21);
            this.nudBit.TabIndex = 7;
            this.nudBit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "开始序号:";
            // 
            // Right_Name
            // 
            this.Right_Name.Location = new System.Drawing.Point(83, 47);
            this.Right_Name.Name = "Right_Name";
            this.Right_Name.Size = new System.Drawing.Size(146, 21);
            this.Right_Name.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "序号位数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "序号后字符:";
            // 
            // Left_Name
            // 
            this.Left_Name.Location = new System.Drawing.Point(83, 20);
            this.Left_Name.Name = "Left_Name";
            this.Left_Name.Size = new System.Drawing.Size(146, 21);
            this.Left_Name.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "序号前字符:";
            // 
            // replaceBox
            // 
            this.replaceBox.Controls.Add(this.tbReplaceText);
            this.replaceBox.Controls.Add(this.label3);
            this.replaceBox.Controls.Add(this.tbReplacedText);
            this.replaceBox.Controls.Add(this.label2);
            this.replaceBox.Location = new System.Drawing.Point(8, 96);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(239, 80);
            this.replaceBox.TabIndex = 2;
            this.replaceBox.TabStop = false;
            this.replaceBox.Text = "替换";
            // 
            // tbReplaceText
            // 
            this.tbReplaceText.Location = new System.Drawing.Point(83, 47);
            this.tbReplaceText.Name = "tbReplaceText";
            this.tbReplaceText.Size = new System.Drawing.Size(146, 21);
            this.tbReplaceText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "替换内容:";
            // 
            // tbReplacedText
            // 
            this.tbReplacedText.Location = new System.Drawing.Point(83, 20);
            this.tbReplacedText.Name = "tbReplacedText";
            this.tbReplacedText.Size = new System.Drawing.Size(146, 21);
            this.tbReplacedText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "被替内容:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 465);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "批量文件重命名工具";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.setBox.ResumeLayout(false);
            this.setBox.PerformLayout();
            this.extBox.ResumeLayout(false);
            this.extBox.PerformLayout();
            this.creatinfoBox.ResumeLayout(false);
            this.creatinfoBox.PerformLayout();
            this.numBox.ResumeLayout(false);
            this.numBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBit)).EndInit();
            this.replaceBox.ResumeLayout(false);
            this.replaceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView FilesList;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox creatinfoBox;
        private System.Windows.Forms.TextBox tbCreateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbBak;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox numBox;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.NumericUpDown nudBit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Right_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Left_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox replaceBox;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReplacedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox extBox;
        private System.Windows.Forms.RadioButton rbtnLower;
        private System.Windows.Forms.RadioButton rbtnUpper;
        private System.Windows.Forms.TextBox tbModifiedTime;
        private System.Windows.Forms.DateTimePicker dtpModifiedTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lnklblLastedVersion;
        private System.Windows.Forms.RadioButton retain_name_right;
        private System.Windows.Forms.RadioButton retain_name_left;
        private System.Windows.Forms.CheckBox retain_name;
        private System.Windows.Forms.GroupBox setBox;
        private System.Windows.Forms.RadioButton num_radioButton;
        private System.Windows.Forms.RadioButton replace_radioButton;
        private System.Windows.Forms.CheckBox creatinfo_checkBox;
        private System.Windows.Forms.CheckBox ext_checkBox;
    }
}

