﻿/* update 10/5/16
 * I created this file manually. 
 */ 
namespace MathProgram
{
    partial class MainForm
    {
        // required designer variable
        private System.ComponentModel.IContainer components = null;

        // clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region this code should be generated by Windows Form Designer
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.AreaCalculationsTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.areaResultBox = new System.Windows.Forms.TextBox();
            this.CalculateAreaBox = new System.Windows.Forms.Button();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.MultiplicationTableTabPage = new System.Windows.Forms.TabPage();
            this.GenerateMultTable = new System.Windows.Forms.Button();
            this.MultTableText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nsize_text = new System.Windows.Forms.TextBox();
            this.MiscFunctions = new System.Windows.Forms.TabPage();
            this.avgTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.GetAverage = new System.Windows.Forms.Button();
            this.GetMinValue = new System.Windows.Forms.Button();
            this.getMaxButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numListTextBox = new System.Windows.Forms.TextBox();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.tabForms.SuspendLayout();
            this.AreaCalculationsTabPage.SuspendLayout();
            this.MultiplicationTableTabPage.SuspendLayout();
            this.MiscFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabForms
            // 
            this.tabForms.Controls.Add(this.HomePage);
            this.tabForms.Controls.Add(this.AreaCalculationsTabPage);
            this.tabForms.Controls.Add(this.MultiplicationTableTabPage);
            this.tabForms.Controls.Add(this.MiscFunctions);
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.Location = new System.Drawing.Point(0, 0);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(550, 347);
            this.tabForms.TabIndex = 1;
            // 
            // AreaCalculationsTabPage
            // 
            this.AreaCalculationsTabPage.Controls.Add(this.label2);
            this.AreaCalculationsTabPage.Controls.Add(this.label1);
            this.AreaCalculationsTabPage.Controls.Add(this.areaResultBox);
            this.AreaCalculationsTabPage.Controls.Add(this.CalculateAreaBox);
            this.AreaCalculationsTabPage.Controls.Add(this.heightBox);
            this.AreaCalculationsTabPage.Controls.Add(this.widthBox);
            this.AreaCalculationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AreaCalculationsTabPage.Name = "AreaCalculationsTabPage";
            this.AreaCalculationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AreaCalculationsTabPage.Size = new System.Drawing.Size(542, 321);
            this.AreaCalculationsTabPage.TabIndex = 0;
            this.AreaCalculationsTabPage.Text = "Area Calculations";
            this.AreaCalculationsTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "width";
            // 
            // areaResultBox
            // 
            this.areaResultBox.Location = new System.Drawing.Point(69, 130);
            this.areaResultBox.Name = "areaResultBox";
            this.areaResultBox.Size = new System.Drawing.Size(157, 20);
            this.areaResultBox.TabIndex = 3;
            // 
            // CalculateAreaBox
            // 
            this.CalculateAreaBox.Location = new System.Drawing.Point(69, 100);
            this.CalculateAreaBox.Name = "CalculateAreaBox";
            this.CalculateAreaBox.Size = new System.Drawing.Size(157, 23);
            this.CalculateAreaBox.TabIndex = 2;
            this.CalculateAreaBox.Text = "Calculate Area of Square";
            this.CalculateAreaBox.UseVisualStyleBackColor = true;
            this.CalculateAreaBox.Click += new System.EventHandler(this.CalculateAreaBox_Click);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(69, 73);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(157, 20);
            this.heightBox.TabIndex = 1;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(69, 46);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(157, 20);
            this.widthBox.TabIndex = 0;
            // 
            // MultiplicationTableTabPage
            // 
            this.MultiplicationTableTabPage.Controls.Add(this.GenerateMultTable);
            this.MultiplicationTableTabPage.Controls.Add(this.MultTableText);
            this.MultiplicationTableTabPage.Controls.Add(this.label3);
            this.MultiplicationTableTabPage.Controls.Add(this.Nsize_text);
            this.MultiplicationTableTabPage.Location = new System.Drawing.Point(4, 22);
            this.MultiplicationTableTabPage.Name = "MultiplicationTableTabPage";
            this.MultiplicationTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MultiplicationTableTabPage.Size = new System.Drawing.Size(542, 321);
            this.MultiplicationTableTabPage.TabIndex = 1;
            this.MultiplicationTableTabPage.Text = "Multiplication Table";
            this.MultiplicationTableTabPage.UseVisualStyleBackColor = true;
            // 
            // GenerateMultTable
            // 
            this.GenerateMultTable.Location = new System.Drawing.Point(341, 24);
            this.GenerateMultTable.Name = "GenerateMultTable";
            this.GenerateMultTable.Size = new System.Drawing.Size(75, 23);
            this.GenerateMultTable.TabIndex = 3;
            this.GenerateMultTable.Text = "generate";
            this.GenerateMultTable.UseVisualStyleBackColor = true;
            this.GenerateMultTable.Click += new System.EventHandler(this.GenerateMultiplicationTable_Click);
            // 
            // MultTableText
            // 
            this.MultTableText.Location = new System.Drawing.Point(106, 69);
            this.MultTableText.Name = "MultTableText";
            this.MultTableText.ReadOnly = true;
            this.MultTableText.Size = new System.Drawing.Size(293, 230);
            this.MultTableText.TabIndex = 2;
            this.MultTableText.Text = "";
            this.MultTableText.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter N for NxN table";
            // 
            // Nsize_text
            // 
            this.Nsize_text.Location = new System.Drawing.Point(190, 28);
            this.Nsize_text.Name = "Nsize_text";
            this.Nsize_text.Size = new System.Drawing.Size(100, 20);
            this.Nsize_text.TabIndex = 0;
            this.Nsize_text.TextChanged += new System.EventHandler(this.Nsize_text_TextChanged);
            // 
            // MiscFunctions
            // 
            this.MiscFunctions.Controls.Add(this.avgTextBox);
            this.MiscFunctions.Controls.Add(this.minTextBox);
            this.MiscFunctions.Controls.Add(this.maxTextBox);
            this.MiscFunctions.Controls.Add(this.GetAverage);
            this.MiscFunctions.Controls.Add(this.GetMinValue);
            this.MiscFunctions.Controls.Add(this.getMaxButton);
            this.MiscFunctions.Controls.Add(this.label4);
            this.MiscFunctions.Controls.Add(this.numListTextBox);
            this.MiscFunctions.Location = new System.Drawing.Point(4, 22);
            this.MiscFunctions.Name = "MiscFunctions";
            this.MiscFunctions.Padding = new System.Windows.Forms.Padding(3);
            this.MiscFunctions.Size = new System.Drawing.Size(542, 321);
            this.MiscFunctions.TabIndex = 2;
            this.MiscFunctions.Text = "Misc. Functions";
            this.MiscFunctions.UseVisualStyleBackColor = true;
            // 
            // avgTextBox
            // 
            this.avgTextBox.Location = new System.Drawing.Point(178, 196);
            this.avgTextBox.Name = "avgTextBox";
            this.avgTextBox.Size = new System.Drawing.Size(122, 20);
            this.avgTextBox.TabIndex = 5;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(178, 149);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(122, 20);
            this.minTextBox.TabIndex = 5;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(178, 99);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(122, 20);
            this.maxTextBox.TabIndex = 5;
            // 
            // GetAverage
            // 
            this.GetAverage.Location = new System.Drawing.Point(25, 193);
            this.GetAverage.Name = "GetAverage";
            this.GetAverage.Size = new System.Drawing.Size(116, 23);
            this.GetAverage.TabIndex = 4;
            this.GetAverage.Text = "Get Average";
            this.GetAverage.UseVisualStyleBackColor = true;
            this.GetAverage.Click += new System.EventHandler(this.GetAverage_Click);
            // 
            // GetMinValue
            // 
            this.GetMinValue.Location = new System.Drawing.Point(25, 146);
            this.GetMinValue.Name = "GetMinValue";
            this.GetMinValue.Size = new System.Drawing.Size(116, 23);
            this.GetMinValue.TabIndex = 3;
            this.GetMinValue.Text = "Get Min Value";
            this.GetMinValue.UseVisualStyleBackColor = true;
            this.GetMinValue.Click += new System.EventHandler(this.GetMinValue_Click);
            // 
            // getMaxButton
            // 
            this.getMaxButton.Location = new System.Drawing.Point(25, 97);
            this.getMaxButton.Name = "getMaxButton";
            this.getMaxButton.Size = new System.Drawing.Size(116, 23);
            this.getMaxButton.TabIndex = 2;
            this.getMaxButton.Text = "Get Max Value";
            this.getMaxButton.UseVisualStyleBackColor = true;
            this.getMaxButton.Click += new System.EventHandler(this.GetMaxValue);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter a list of numbers either comma or space separated";
            // 
            // numListTextBox
            // 
            this.numListTextBox.Location = new System.Drawing.Point(22, 49);
            this.numListTextBox.Name = "numListTextBox";
            this.numListTextBox.Size = new System.Drawing.Size(478, 20);
            this.numListTextBox.TabIndex = 0;
            // 
            // HomePage
            // 
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "Home";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(542, 321);
            this.HomePage.TabIndex = 3;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 361);
            this.Controls.Add(this.tabForms);
            this.Name = "MainForm";
            this.Text = "Math Review 0.1";
            this.Load += new System.EventHandler(this.FormMath_Load);
            this.tabForms.ResumeLayout(false);
            this.AreaCalculationsTabPage.ResumeLayout(false);
            this.AreaCalculationsTabPage.PerformLayout();
            this.MultiplicationTableTabPage.ResumeLayout(false);
            this.MultiplicationTableTabPage.PerformLayout();
            this.MiscFunctions.ResumeLayout(false);
            this.MiscFunctions.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.TabPage AreaCalculationsTabPage;
        private System.Windows.Forms.TextBox areaResultBox;
        private System.Windows.Forms.Button CalculateAreaBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TabPage MultiplicationTableTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nsize_text;
        private System.Windows.Forms.RichTextBox MultTableText;
        private System.Windows.Forms.TabPage MiscFunctions;
        private System.Windows.Forms.TextBox avgTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Button GetAverage;
        private System.Windows.Forms.Button GetMinValue;
        private System.Windows.Forms.Button getMaxButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numListTextBox;
        private System.Windows.Forms.Button GenerateMultTable;
        private System.Windows.Forms.TabPage HomePage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private void FormMath_Load(object sender, System.EventArgs e)
        {

        }
    }
}