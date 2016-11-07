using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
namespace ButtonZ
{
    public class ButtonZ : System.Windows.Forms.Button
    {
    
        private Color color1 = Color.Green;
        private Color color2 = Color.DarkBlue;
        private Color m_hovercolor1 = Color.Yellow;
        private Color m_hovercolor2 = Color.DarkOrange;
        private int color1Transparent = 150;
        private int color2Transparent = 150;
        private Color clickcolor1 = Color.Yellow;
        private Color clickcolor2 = Color.Red;
        private int angle = 90;
        private int textX = 100;
        private int textY = 25;
        private String text = "";

        public ButtonZ()
        {
            this.Size = new System.Drawing.Size(200, 50);
            this.ForeColor = Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            text = "Verd";
        }


        //method mouse click
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (text == "Verd")
            {
                color1 = Color.Yellow;
                text = "Groc";               
                Invalidate();
                
            } else if (text == "Groc")
            {
                color1 = Color.Red;
                text = "Vermell";
                Invalidate();
            } else if (text == "Vermell")
            {
                color1 = Color.Green;
                text = "Verd";
                Invalidate();
            }
        
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (textX == 100 && textY == 25)
            {
                textX = ((this.Width) / 3) + 10;
                textY = (this.Height / 2) - 1;
            }
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);
            //drawing string & filling gradient rectangle 
            //Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            SolidBrush frcolor = null;
            Brush b = new SolidBrush(color1);
            if (text == "Verd")
            {
                frcolor = new SolidBrush(Color.White);
            } else if (text == "Groc")
            {
                frcolor = new SolidBrush(Color.Black);
            } else if (text == "Vermell")
            {
                frcolor = new SolidBrush(Color.White);
            }
            Point p = new Point(textX, textY);
            
            Border3DStyle borderStyle = Border3DStyle.SunkenInner;
            pe.Graphics.FillRectangle(b, ClientRectangle);
            pe.Graphics.DrawString(text, Font, frcolor, p);
            ControlPaint.DrawBorder3D(pe.Graphics, ClientRectangle, borderStyle);
            b.Dispose();
        }
    }
}