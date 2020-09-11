namespace Gambler
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gamble = new System.Windows.Forms.Button();
            this.lb_money = new System.Windows.Forms.Label();
            this.lb_rm = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "BetR";
            // 
            // btn_gamble
            // 
            this.btn_gamble.Location = new System.Drawing.Point(93, 228);
            this.btn_gamble.Name = "btn_gamble";
            this.btn_gamble.Size = new System.Drawing.Size(255, 89);
            this.btn_gamble.TabIndex = 1;
            this.btn_gamble.Text = "GAMBLE!";
            this.btn_gamble.UseVisualStyleBackColor = true;
            this.btn_gamble.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_money.Location = new System.Drawing.Point(129, 200);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(68, 24);
            this.lb_money.TabIndex = 2;
            this.lb_money.Text = "Money";
            // 
            // lb_rm
            // 
            this.lb_rm.AutoSize = true;
            this.lb_rm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rm.Location = new System.Drawing.Point(129, 166);
            this.lb_rm.Name = "lb_rm";
            this.lb_rm.Size = new System.Drawing.Size(125, 24);
            this.lb_rm.TabIndex = 3;
            this.lb_rm.Text = "Result Money";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_result.Location = new System.Drawing.Point(129, 100);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(116, 39);
            this.lb_result.TabIndex = 4;
            this.lb_result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 353);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_rm);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.btn_gamble);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cassino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gamble;
        private System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.Label lb_rm;
        private System.Windows.Forms.Label lb_result;
    }
}

