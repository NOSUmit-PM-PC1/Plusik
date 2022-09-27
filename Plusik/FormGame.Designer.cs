namespace Plusik
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPLus = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPLus
            // 
            this.buttonPLus.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPLus.Location = new System.Drawing.Point(90, 66);
            this.buttonPLus.Name = "buttonPLus";
            this.buttonPLus.Size = new System.Drawing.Size(157, 161);
            this.buttonPLus.TabIndex = 0;
            this.buttonPLus.Text = "+";
            this.buttonPLus.UseVisualStyleBackColor = true;
            this.buttonPLus.Click += new System.EventHandler(this.buttonPLus_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.Location = new System.Drawing.Point(540, 66);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(157, 161);
            this.buttonMult.TabIndex = 1;
            this.buttonMult.Text = "x";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTarget.Location = new System.Drawing.Point(371, 66);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(55, 39);
            this.labelTarget.TabIndex = 2;
            this.labelTarget.Text = "15";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.ForeColor = System.Drawing.Color.Yellow;
            this.labelUser.Location = new System.Drawing.Point(365, 200);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(68, 73);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "1";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSteps.Location = new System.Drawing.Point(371, 289);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(36, 39);
            this.labelSteps.TabIndex = 4;
            this.labelSteps.Text = "0";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonPLus);
            this.Name = "FormGame";
            this.Text = "Игра Плюсик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPLus;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelSteps;
    }
}

