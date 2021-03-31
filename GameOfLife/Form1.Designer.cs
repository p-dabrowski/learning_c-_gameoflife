
namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.wormsPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.worm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wormsAliveLabel = new System.Windows.Forms.Label();
            this.WormsDeadLabel = new System.Windows.Forms.Label();
            this.randomValueBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aliveNeighboursMinInput = new System.Windows.Forms.TextBox();
            this.aliveNeighboursMaxInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ageMaxInput = new System.Windows.Forms.TextBox();
            this.deadtimeMaxInput = new System.Windows.Forms.TextBox();
            this.seedsValue = new System.Windows.Forms.Label();
            this.stepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.randomValueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // wormsPanel
            // 
            this.wormsPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.wormsPanel.Location = new System.Drawing.Point(34, 32);
            this.wormsPanel.Name = "wormsPanel";
            this.wormsPanel.Size = new System.Drawing.Size(500, 250);
            this.wormsPanel.TabIndex = 0;
            this.wormsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(570, 72);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // worm
            // 
            this.worm.AutoSize = true;
            this.worm.Location = new System.Drawing.Point(570, 134);
            this.worm.Name = "worm";
            this.worm.Size = new System.Drawing.Size(41, 17);
            this.worm.TabIndex = 2;
            this.worm.Text = "Step:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Worms alive:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Worms dead:";
            // 
            // wormsAliveLabel
            // 
            this.wormsAliveLabel.AutoSize = true;
            this.wormsAliveLabel.Location = new System.Drawing.Point(669, 164);
            this.wormsAliveLabel.Name = "wormsAliveLabel";
            this.wormsAliveLabel.Size = new System.Drawing.Size(46, 17);
            this.wormsAliveLabel.TabIndex = 6;
            this.wormsAliveLabel.Text = "label3";
            // 
            // WormsDeadLabel
            // 
            this.WormsDeadLabel.AutoSize = true;
            this.WormsDeadLabel.Location = new System.Drawing.Point(672, 194);
            this.WormsDeadLabel.Name = "WormsDeadLabel";
            this.WormsDeadLabel.Size = new System.Drawing.Size(46, 17);
            this.WormsDeadLabel.TabIndex = 7;
            this.WormsDeadLabel.Text = "label4";
            // 
            // randomValueBar
            // 
            this.randomValueBar.Location = new System.Drawing.Point(427, 307);
            this.randomValueBar.Maximum = 99;
            this.randomValueBar.Name = "randomValueBar";
            this.randomValueBar.Size = new System.Drawing.Size(184, 56);
            this.randomValueBar.TabIndex = 8;
            this.randomValueBar.Value = 5;
            this.randomValueBar.Scroll += new System.EventHandler(this.randomValueBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seeds:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alive neighbours min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alive neighbours max:";
            // 
            // aliveNeighboursMinInput
            // 
            this.aliveNeighboursMinInput.Location = new System.Drawing.Point(180, 307);
            this.aliveNeighboursMinInput.Name = "aliveNeighboursMinInput";
            this.aliveNeighboursMinInput.Size = new System.Drawing.Size(50, 22);
            this.aliveNeighboursMinInput.TabIndex = 12;
            this.aliveNeighboursMinInput.Text = "2";
            // 
            // aliveNeighboursMaxInput
            // 
            this.aliveNeighboursMaxInput.Location = new System.Drawing.Point(180, 337);
            this.aliveNeighboursMaxInput.Name = "aliveNeighboursMaxInput";
            this.aliveNeighboursMaxInput.Size = new System.Drawing.Size(50, 22);
            this.aliveNeighboursMaxInput.TabIndex = 13;
            this.aliveNeighboursMaxInput.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max deadtime:";
            // 
            // ageMaxInput
            // 
            this.ageMaxInput.Location = new System.Drawing.Point(180, 367);
            this.ageMaxInput.Name = "ageMaxInput";
            this.ageMaxInput.Size = new System.Drawing.Size(50, 22);
            this.ageMaxInput.TabIndex = 16;
            this.ageMaxInput.Text = "10";
            // 
            // deadtimeMaxInput
            // 
            this.deadtimeMaxInput.Location = new System.Drawing.Point(180, 400);
            this.deadtimeMaxInput.Name = "deadtimeMaxInput";
            this.deadtimeMaxInput.Size = new System.Drawing.Size(50, 22);
            this.deadtimeMaxInput.TabIndex = 17;
            this.deadtimeMaxInput.Text = "25";
            // 
            // seedsValue
            // 
            this.seedsValue.AutoSize = true;
            this.seedsValue.Location = new System.Drawing.Point(617, 310);
            this.seedsValue.Name = "seedsValue";
            this.seedsValue.Size = new System.Drawing.Size(16, 17);
            this.seedsValue.TabIndex = 18;
            this.seedsValue.Text = "5";
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(672, 134);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(16, 17);
            this.stepLabel.TabIndex = 19;
            this.stepLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.seedsValue);
            this.Controls.Add(this.deadtimeMaxInput);
            this.Controls.Add(this.ageMaxInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aliveNeighboursMaxInput);
            this.Controls.Add(this.aliveNeighboursMinInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.randomValueBar);
            this.Controls.Add(this.WormsDeadLabel);
            this.Controls.Add(this.wormsAliveLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.worm);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.wormsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.randomValueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel wormsPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label worm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wormsAliveLabel;
        private System.Windows.Forms.Label WormsDeadLabel;
        private System.Windows.Forms.TrackBar randomValueBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox aliveNeighboursMinInput;
        public System.Windows.Forms.TextBox aliveNeighboursMaxInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ageMaxInput;
        private System.Windows.Forms.TextBox deadtimeMaxInput;
        private System.Windows.Forms.Label seedsValue;
        private System.Windows.Forms.Label stepLabel;
    }
}

