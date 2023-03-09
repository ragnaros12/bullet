namespace WindowsFormsApp1
{
	partial class Form1
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Widt = new System.Windows.Forms.Label();
			this.Hieght = new System.Windows.Forms.Label();
			this.Angle = new System.Windows.Forms.Label();
			this.Speed = new System.Windows.Forms.Label();
			this.Shoot = new System.Windows.Forms.Button();
			this.InputWidth = new System.Windows.Forms.TextBox();
			this.InputHeight = new System.Windows.Forms.TextBox();
			this.InputAngle = new System.Windows.Forms.TextBox();
			this.InputSpeed = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.XPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.max = new System.Windows.Forms.Label();
			this.InputRadius = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.x = new System.Windows.Forms.TextBox();
			this.y = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(2, 2);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.IsXValueIndexed = true;
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(926, 559);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "TrajectoryGraph";
			// 
			// Widt
			// 
			this.Widt.AutoSize = true;
			this.Widt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Widt.Location = new System.Drawing.Point(935, 33);
			this.Widt.Name = "Widt";
			this.Widt.Size = new System.Drawing.Size(133, 24);
			this.Widt.TabIndex = 4;
			this.Widt.Text = "Длина ствола";
			// 
			// Hieght
			// 
			this.Hieght.AutoSize = true;
			this.Hieght.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Hieght.Location = new System.Drawing.Point(935, 68);
			this.Hieght.Name = "Hieght";
			this.Hieght.Size = new System.Drawing.Size(146, 24);
			this.Hieght.TabIndex = 5;
			this.Hieght.Text = "Высота лафета";
			// 
			// Angle
			// 
			this.Angle.AutoSize = true;
			this.Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Angle.Location = new System.Drawing.Point(935, 120);
			this.Angle.Name = "Angle";
			this.Angle.Size = new System.Drawing.Size(122, 24);
			this.Angle.TabIndex = 6;
			this.Angle.Text = "Угол вылета";
			// 
			// Speed
			// 
			this.Speed.AutoSize = true;
			this.Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Speed.Location = new System.Drawing.Point(935, 155);
			this.Speed.Name = "Speed";
			this.Speed.Size = new System.Drawing.Size(175, 24);
			this.Speed.TabIndex = 7;
			this.Speed.Text = "Скорость снаряда";
			// 
			// Shoot
			// 
			this.Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Shoot.Location = new System.Drawing.Point(307, 547);
			this.Shoot.Name = "Shoot";
			this.Shoot.Size = new System.Drawing.Size(248, 44);
			this.Shoot.TabIndex = 10;
			this.Shoot.Text = "Выстрел";
			this.Shoot.UseVisualStyleBackColor = true;
			this.Shoot.Click += new System.EventHandler(this.ShootClick);
			// 
			// InputWidth
			// 
			this.InputWidth.Location = new System.Drawing.Point(1132, 37);
			this.InputWidth.Name = "InputWidth";
			this.InputWidth.Size = new System.Drawing.Size(282, 20);
			this.InputWidth.TabIndex = 11;
			this.InputWidth.Text = "6,126";
			// 
			// InputHeight
			// 
			this.InputHeight.Location = new System.Drawing.Point(1132, 73);
			this.InputHeight.Name = "InputHeight";
			this.InputHeight.Size = new System.Drawing.Size(282, 20);
			this.InputHeight.TabIndex = 12;
			this.InputHeight.Text = "1,250";
			// 
			// InputAngle
			// 
			this.InputAngle.Location = new System.Drawing.Point(1132, 124);
			this.InputAngle.Name = "InputAngle";
			this.InputAngle.Size = new System.Drawing.Size(282, 20);
			this.InputAngle.TabIndex = 13;
			this.InputAngle.Text = "15";
			// 
			// InputSpeed
			// 
			this.InputSpeed.Location = new System.Drawing.Point(1132, 160);
			this.InputSpeed.Name = "InputSpeed";
			this.InputSpeed.Size = new System.Drawing.Size(282, 20);
			this.InputSpeed.TabIndex = 14;
			this.InputSpeed.Text = "700";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Time, this.XPosition, this.YPosition });
			this.dataGridView1.Location = new System.Drawing.Point(918, 343);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(488, 268);
			this.dataGridView1.TabIndex = 16;
			// 
			// Time
			// 
			this.Time.HeaderText = "Время";
			this.Time.Name = "Time";
			// 
			// XPosition
			// 
			this.XPosition.HeaderText = "Положение x";
			this.XPosition.Name = "XPosition";
			// 
			// YPosition
			// 
			this.YPosition.HeaderText = "Положение y";
			this.YPosition.Name = "YPosition";
			// 
			// max
			// 
			this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.max.Location = new System.Drawing.Point(918, 276);
			this.max.Name = "max";
			this.max.Size = new System.Drawing.Size(472, 64);
			this.max.TabIndex = 17;
			// 
			// InputRadius
			// 
			this.InputRadius.Location = new System.Drawing.Point(1132, 186);
			this.InputRadius.Name = "InputRadius";
			this.InputRadius.Size = new System.Drawing.Size(282, 20);
			this.InputRadius.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(934, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 24);
			this.label1.TabIndex = 19;
			this.label1.Text = "Радиус убойной силы";
			// 
			// x
			// 
			this.x.Location = new System.Drawing.Point(934, 253);
			this.x.Name = "x";
			this.x.Size = new System.Drawing.Size(160, 20);
			this.x.TabIndex = 20;
			// 
			// y
			// 
			this.y.Location = new System.Drawing.Point(1100, 253);
			this.y.Name = "y";
			this.y.Size = new System.Drawing.Size(160, 20);
			this.y.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(935, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 25);
			this.label2.TabIndex = 22;
			this.label2.Text = "Координаты x,y";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1418, 627);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.y);
			this.Controls.Add(this.x);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputRadius);
			this.Controls.Add(this.max);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.InputSpeed);
			this.Controls.Add(this.InputAngle);
			this.Controls.Add(this.InputHeight);
			this.Controls.Add(this.InputWidth);
			this.Controls.Add(this.Shoot);
			this.Controls.Add(this.Speed);
			this.Controls.Add(this.Angle);
			this.Controls.Add(this.Hieght);
			this.Controls.Add(this.Widt);
			this.Controls.Add(this.chart1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.TextBox InputRadius;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox x;
		private System.Windows.Forms.TextBox y;
		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.DataGridViewTextBoxColumn Time;
		private System.Windows.Forms.DataGridViewTextBoxColumn XPosition;
		private System.Windows.Forms.DataGridViewTextBoxColumn YPosition;

		private System.Windows.Forms.DataGridView dataGridView1;

		private System.Windows.Forms.Label Widt;

		private System.Windows.Forms.TextBox InputWidth;
		private System.Windows.Forms.TextBox InputHeight;
		private System.Windows.Forms.TextBox InputAngle;
		private System.Windows.Forms.TextBox InputSpeed;

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label max;
		private System.Windows.Forms.Label Hieght;
		private System.Windows.Forms.Label Angle;
		private System.Windows.Forms.Label Speed;
		private System.Windows.Forms.Button Shoot;
	}
}

