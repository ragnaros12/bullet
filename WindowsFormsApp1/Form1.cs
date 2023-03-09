using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ShootClick(object sender, EventArgs e)
		{
			chart1.Series[0].Points.Clear();
			double angle = Convert.ToDouble(InputAngle.Text) * Math.PI / 180;
			double speed = Convert.ToDouble(InputSpeed.Text);

			double d = Convert.ToDouble(InputWidth.Text);
			double h = Convert.ToDouble(InputHeight.Text);
			dataGridView1.Rows.Clear();
			max.Text = "";

			double maxX = 10;
			double maxY = 10;

			double radius = Convert.ToDouble(InputRadius.Text);
			double xPos = Convert.ToDouble(x.Text);
			double yPos = Convert.ToDouble(y.Text);

			bool isShoot = false;

			
			double y0 = h + d * Math.Sin(angle);
			double t = 0;
			double currentX;
			double currentY = y0;

			while(currentY >= 0)
			{
				currentX = speed * Math.Cos(angle) * t;
				currentY = y0 + speed * Math.Sin(angle) * t - 9.8 * t * t / 2;
				chart1.Series[0].Points.AddXY(currentX, currentY);

				if (Math.Pow(xPos - currentX, 2) + Math.Pow(yPos - currentY, 2) < radius * radius)
				{
					isShoot = true;
				}

				if (currentY > maxY)
				{
					maxX = currentX;
					maxY = currentY;
				}

				dataGridView1.Rows.Add(t, currentX, currentY);
				t += 0.1;
			}

			max.Text = "макс. точка x: " + maxX + " y: " + maxY + "\n" + (isShoot ? "Находится" : "Не находится");
		}
	}
}
