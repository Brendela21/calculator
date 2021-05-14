
namespace Homewrok_Calculator
{
    partial class Calculator
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
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(14, 105);
            this.btnMC.Margin = new System.Windows.Forms.Padding(5);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(60, 50);
            this.btnMC.TabIndex = 12;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(84, 105);
            this.btnMR.Margin = new System.Windows.Forms.Padding(5);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(60, 50);
            this.btnMR.TabIndex = 13;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Location = new System.Drawing.Point(154, 105);
            this.btnMPlus.Margin = new System.Windows.Forms.Padding(5);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(60, 50);
            this.btnMPlus.TabIndex = 14;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.Location = new System.Drawing.Point(224, 105);
            this.btnMMinus.Margin = new System.Windows.Forms.Padding(5);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(60, 50);
            this.btnMMinus.TabIndex = 15;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = true;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(293, 105);
            this.btnMS.Margin = new System.Windows.Forms.Padding(5);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(60, 50);
            this.btnMS.TabIndex = 29;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(14, 24);
            this.tbResult.Margin = new System.Windows.Forms.Padding(5);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(409, 53);
            this.tbResult.TabIndex = 30;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(206, 380);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(217, 45);
            this.btnResult.TabIndex = 48;
            this.btnResult.TabStop = false;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(110, 380);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(85, 45);
            this.button0.TabIndex = 47;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(14, 380);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(85, 45);
            this.buttonPoint.TabIndex = 46;
            this.buttonPoint.TabStop = false;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(302, 326);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(121, 45);
            this.buttonMinus.TabIndex = 45;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // button03
            // 
            this.button03.Location = new System.Drawing.Point(206, 326);
            this.button03.Margin = new System.Windows.Forms.Padding(4);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(85, 45);
            this.button03.TabIndex = 44;
            this.button03.TabStop = false;
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(110, 326);
            this.button02.Margin = new System.Windows.Forms.Padding(4);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(85, 45);
            this.button02.TabIndex = 43;
            this.button02.TabStop = false;
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 45);
            this.button1.TabIndex = 42;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(302, 272);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 45);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // button06
            // 
            this.button06.Location = new System.Drawing.Point(206, 272);
            this.button06.Margin = new System.Windows.Forms.Padding(4);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(85, 45);
            this.button06.TabIndex = 40;
            this.button06.TabStop = false;
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button05
            // 
            this.button05.Location = new System.Drawing.Point(110, 272);
            this.button05.Margin = new System.Windows.Forms.Padding(4);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(85, 45);
            this.button05.TabIndex = 39;
            this.button05.TabStop = false;
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button04
            // 
            this.button04.Location = new System.Drawing.Point(14, 272);
            this.button04.Margin = new System.Windows.Forms.Padding(4);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(85, 45);
            this.button04.TabIndex = 38;
            this.button04.TabStop = false;
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(302, 218);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(121, 45);
            this.buttonMultiply.TabIndex = 37;
            this.buttonMultiply.TabStop = false;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // button09
            // 
            this.button09.Location = new System.Drawing.Point(206, 218);
            this.button09.Margin = new System.Windows.Forms.Padding(4);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(85, 45);
            this.button09.TabIndex = 36;
            this.button09.TabStop = false;
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = true;
            this.button09.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button08
            // 
            this.button08.Location = new System.Drawing.Point(110, 218);
            this.button08.Margin = new System.Windows.Forms.Padding(4);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(85, 45);
            this.button08.TabIndex = 35;
            this.button08.TabStop = false;
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = true;
            this.button08.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button07
            // 
            this.button07.Location = new System.Drawing.Point(14, 218);
            this.button07.Margin = new System.Windows.Forms.Padding(4);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(85, 45);
            this.button07.TabIndex = 34;
            this.button07.TabStop = false;
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = true;
            this.button07.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(302, 164);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(121, 45);
            this.buttonDiv.TabIndex = 33;
            this.buttonDiv.TabStop = false;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(110, 164);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(85, 45);
            this.buttonCE.TabIndex = 32;
            this.buttonCE.TabStop = false;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(14, 164);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(85, 45);
            this.buttonC.TabIndex = 31;
            this.buttonC.TabStop = false;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(363, 105);
            this.buttonM.Margin = new System.Windows.Forms.Padding(5);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(60, 50);
            this.buttonM.TabIndex = 49;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Location = new System.Drawing.Point(206, 165);
            this.buttonRoot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(85, 45);
            this.buttonRoot.TabIndex = 50;
            this.buttonRoot.TabStop = false;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 434);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button03);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button06);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button04);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button09);
            this.Controls.Add(this.button08);
            this.Controls.Add(this.button07);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonRoot;
    }
}

