namespace Lesson4
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BMINum = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(76, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMIの計算プログラム";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.height.Location = new System.Drawing.Point(12, 110);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(76, 20);
            this.height.TabIndex = 1;
            this.height.Text = "身長(m)";
            this.height.Click += new System.EventHandler(this.label2_Click);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weight.Location = new System.Drawing.Point(236, 110);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(79, 20);
            this.weight.TabIndex = 2;
            this.weight.Text = "体重(kg)";
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(16, 140);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(183, 19);
            this.WeightBox.TabIndex = 3;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(238, 140);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(193, 19);
            this.HeightBox.TabIndex = 4;
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(238, 179);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 5;
            this.solve.Text = "計算";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(330, 179);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "クリア";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "BMIの値";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "判定結果";
            // 
            // BMINum
            // 
            this.BMINum.Location = new System.Drawing.Point(133, 293);
            this.BMINum.Name = "BMINum";
            this.BMINum.Size = new System.Drawing.Size(272, 19);
            this.BMINum.TabIndex = 9;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(133, 360);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(272, 19);
            this.Result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.BMINum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "入出力画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BMINum;
        private System.Windows.Forms.TextBox Result;
    }
}

