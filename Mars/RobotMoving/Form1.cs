using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotMoving
{
    public partial class Form1 : Form
    {
        List<Rectangle> _rectangles = new List<Rectangle>();
        enum Position
        {
            N, S, E, W
        }

        private int _x1;
        private bool IsRobotOnthePlateu;
        private int _y1;
        private Position _objPosition1;
        private int _x2;
        private int _y2;
        private Position _objPosition2;
        private int _x3;
        private int _y3;
        private Position _objPosition3;
        public Form1()
        {

            InitializeComponent();
            _x1 = 30;
            _y1 = 300;
            _objPosition1 = Position.S;

            _x2 = 30;
            _y2 = 300;
            _objPosition2 = Position.S;

            _x3 = 30;
            _y3 = 300;
            _objPosition3 = Position.S;

            IsRobotOnthePlateu = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            foreach (var move in txt_Moves1.Text)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveForward1();
                        break;
                    case 'L':
                        this.SpinLeft1();
                        break;
                    case 'R':
                        this.SpinRight1();
                        break;
                    default:
                        break;
                }
            }
            foreach (var move in txt_Moves2.Text)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveForward2();
                        break;
                    case 'L':
                        this.SpinLeft2();
                        break;
                    case 'R':
                        this.SpinRight2();
                        break;
                    default:
                        break;
                }
            }
            foreach (var move in txt_Moves3.Text)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveForward3();
                        break;
                    case 'L':
                        this.SpinLeft3();
                        break;
                    case 'R':
                        this.SpinRight3();
                        break;
                    default:
                        break;
                }
            }




        }

        private void SpinLeft1()  //Assuming 90 degree
        {
            switch (this._objPosition1)
            {
                case Position.N:
                    this._objPosition1 = Position.W;
                    cb_D1.SelectedItem = this._objPosition1;
                    break;
                case Position.S:
                    this._objPosition1 = Position.E;
                    cb_D1.SelectedItem = this._objPosition1;
                    break;
                case Position.E:
                    this._objPosition1 = Position.N;
                    cb_D1.SelectedItem = this._objPosition1;
                    break;
                case Position.W:
                    this._objPosition1 = Position.S;
                    cb_D1.SelectedItem = this._objPosition1;
                    break;
                default:
                    break;
            }
        }
        private void SpinLeft2()
        {
            switch (this._objPosition2)
            {
                case Position.N:
                    this._objPosition2 = Position.W;
                    cb_D2.SelectedItem = this._objPosition2;
                    break;
                case Position.S:
                    this._objPosition2 = Position.E;
                    cb_D2.SelectedItem = this._objPosition2;
                    break;
                case Position.E:
                    this._objPosition2 = Position.N;
                    cb_D2.SelectedItem = this._objPosition2;
                    break;
                case Position.W:
                    this._objPosition2 = Position.S;
                    cb_D2.SelectedItem = this._objPosition2;
                    break;
                default:
                    break;
            }
        }
        private void SpinLeft3()  //Assuming 90 degree
        {
           
           
          
            switch (this._objPosition3)
            {
                case Position.N:
                    this._objPosition3 = Position.W;
                    cb_D3.SelectedItem = this._objPosition3;
                    break;
                case Position.S:
                    this._objPosition3 = Position.E;
                    cb_D3.SelectedItem = this._objPosition3;
                    break;
                case Position.E:
                    this._objPosition3 = Position.N;
                    cb_D3.SelectedItem = this._objPosition3;
                    break;
                case Position.W:
                    this._objPosition3 = Position.S;
                    cb_D3.SelectedItem = this._objPosition3;
                    break;
                default:
                    break;
            }
        }

        private void SpinRight1()  //Assuming 90 degree
        {
            switch (this._objPosition1)
            {
                case Position.N:
                    this._objPosition1 = Position.E;
                    cb_D1.SelectedItem = this._objPosition1.ToString();
                    break;
                case Position.S:
                    this._objPosition1 = Position.W;
                    cb_D1.SelectedItem = this._objPosition1.ToString();
                    break;
                case Position.E:
                    this._objPosition1 = Position.S;
                    cb_D1.SelectedItem = this._objPosition1.ToString();
                    break;
                case Position.W:
                    this._objPosition1 = Position.N;
                    cb_D1.SelectedItem = this._objPosition1.ToString();
                    break;
                default:
                    break;
            }
           
           
           
        }
        private void SpinRight2()  //Assuming 90 degree
        {
            switch (this._objPosition2)
            {
                case Position.N:
                    this._objPosition2 = Position.E;
                    cb_D2.SelectedItem = this._objPosition2.ToString();
                    break;
                case Position.S:
                    this._objPosition2 = Position.W;
                    cb_D2.SelectedItem = this._objPosition2.ToString();
                    break;
                case Position.E:
                    this._objPosition2 = Position.S;
                    cb_D2.SelectedItem = this._objPosition2.ToString();
                    break;
                case Position.W:
                    this._objPosition2 = Position.N;
                    cb_D2.SelectedItem = this._objPosition2.ToString();
                    break;
                default:
                    break;
            }
        }
        private void SpinRight3()  //Assuming 90 degree
        {
            switch (this._objPosition3)
            {
                case Position.N:
                    this._objPosition3 = Position.E;
                    cb_D3.SelectedItem = this._objPosition3.ToString();
                    break;
                case Position.S:
                    this._objPosition3 = Position.W;
                    cb_D3.SelectedItem = this._objPosition3.ToString();
                    break;
                case Position.E:
                    this._objPosition3 = Position.S;
                    cb_D3.SelectedItem = this._objPosition3.ToString();
                    break;
                case Position.W:
                    this._objPosition3 = Position.N;
                    cb_D3.SelectedItem = this._objPosition3.ToString();
                    break;
                default:
                    break;
            }
        }
        private void MoveForward1()     // Move forwar or back one point
        {
            switch (this._objPosition1)
            {
                case Position.N:  // move one point from y coordinate
                    this._y1 += 70;
                    cb_Y1.SelectedItem = this._y1;
                    break;
                case Position.S:  // move back one point from y coordinate
                    this._y1 -= 70;
                    if (this._y1 < 300)
                        this._y1 = 300;

                    cb_Y1.SelectedItem = this._y1;
                    break;
                case Position.E:  // move one point from x coordinate
                    this._x1 += 30;
                    cb_X1.SelectedItem = this._x1;
                    break;
                case Position.W:  // move back one point from x coordinate
                    this._x1 -= 30;
                    if (this._x1 < 30)
                        this._x1 = 30;
                    cb_X1.SelectedItem = this._x1;
                    break;
                default:
                    break;
            }
           

           
           
            this.Invalidate();
        }

        private void MoveForward2()
        {
            switch (this._objPosition2)
            {
                case Position.N:  // move one point from y coordinate
                    this._y2 += 70;
                    cb_Y2.SelectedItem = this._y2;
                    break;
                case Position.S:  // move back one point from y coordinate
                    this._y2 -= 70;
                    if (this._y2 < 300)
                        this._y2 = 300;
                    cb_Y2.SelectedItem = this._y2;
                    break;
                case Position.E:  // move one point from x coordinate
                    this._x2 += 30;
                    cb_X2.SelectedItem = this._x2;
                    break;
                case Position.W:  // move back one point from x coordinate
                    this._x2 -= 30;
                    if (this._x2 < 30)
                        this._x2 = 30;
                    cb_X2.SelectedItem = this._x2;
                    break;
                default:
                    break;
            }
            this.Invalidate();
        }
        private void MoveForward3()
        {
            switch (this._objPosition3)
            {
                case Position.N:  // move one point from y coordinate
                    this._y3 += 70;
                    cb_Y3.SelectedItem = this._y3;
                    break;
                case Position.S:  // move back one point from y coordinate
                    this._y3 -= 70;
                    if (this._y3 < 300)
                        this._y3 = 300;
                    cb_Y3.SelectedItem = this._y3;
                    break;
                case Position.E:  // move one point from x coordinate
                    this._x3 += 30;
                    cb_X3.SelectedItem = this._x3;
                    break;
                case Position.W:  // move back one point from x coordinate
                    this._x3 -= 30;
                    if (this._x3 < 30)
                        this._x3 = 30;
                    cb_X3.SelectedItem = this._x3;
                    break;
                default:
                    break;
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var rectangle = new Rectangle(0, 300, 1000, 1000);
            this._rectangles.Add(rectangle);          
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
            int x1 = Convert.ToInt32(cb_X1.SelectedItem);
            int x2 = Convert.ToInt32(cb_X2.SelectedItem);
            int x3 = Convert.ToInt32(cb_X3.SelectedItem);

            int y1 = Convert.ToInt32(cb_Y1.SelectedItem);
            int y2 = Convert.ToInt32(cb_Y2.SelectedItem);
            int y3 = Convert.ToInt32(cb_Y3.SelectedItem);
           
            if (IsRobotOnthePlateu==false && x1!=0 && x2!=0 && x3!=0)
            {

                _x1 = x1;
                _x2 = x2;
                _x3 = x3;
                _y1 = y1;
                _y2 = y2;
                _y3 = y3;
                e.Graphics.DrawImage(new Bitmap("robot9.png"), _x1, _y1, 128, 128);
                e.Graphics.DrawImage(new Bitmap("robot9.png"), _x2, _y2, 128, 128);
                e.Graphics.DrawImage(new Bitmap("robot9.png"), _x3, _y3, 128, 128);


                IsRobotOnthePlateu = true;





            }
            else if(IsRobotOnthePlateu)
            {
                _x1 = x1;
                _x2 = x2;
                _x3 = x3;
                _y1 = y1;
                _y2 = y2;
                _y3 = y3;
                e.Graphics.DrawImage(new Bitmap("robot9.png"), _x1, _y1, 128, 128);
                e.Graphics.DrawImage(new Bitmap("robot9.png"), _x2, _y2, 128, 128);
                e.Graphics.DrawImage(new Bitmap("robot9.png"), _x3, _y3, 128, 128);

               
            }
            





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
            timer1.Enabled = false;
            System.Object[] ItemObjectX = new System.Object[10];
            for (int i = 0; i < 10; i = i + 1)
            {
                ItemObjectX[i] = (i + 1) * 30;
            }
            System.Object[] ItemObjectY = new System.Object[7];
            for (int i = 0; i < 7; i = i + 1)
            {
                ItemObjectY[i] = ((i + 1) * 70)+230;
            }
            cb_X1.Items.AddRange(ItemObjectX);
            cb_X2.Items.AddRange(ItemObjectX);
            cb_X3.Items.AddRange(ItemObjectX);
            cb_Y1.Items.AddRange(ItemObjectY);
            cb_Y2.Items.AddRange(ItemObjectY);
            cb_Y3.Items.AddRange(ItemObjectY);

            cb_D1.Items.Add("N");
            cb_D1.Items.Add("S");
            cb_D1.Items.Add("E");
            cb_D1.Items.Add("W");


            cb_D2.Items.Add("N");
            cb_D2.Items.Add("S");
            cb_D2.Items.Add("E");
            cb_D2.Items.Add("W");

            cb_D3.Items.Add("N");
            cb_D3.Items.Add("S");
            cb_D3.Items.Add("E");
            cb_D3.Items.Add("W");

            cb_D1.SelectedItem = _objPosition1.ToString();
            cb_D2.SelectedItem = _objPosition2.ToString();
            cb_D3.SelectedItem = _objPosition3.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string D1 = (cb_D1.SelectedItem.ToString());
            string D2 = (cb_D2.SelectedItem.ToString());
            string D3 = (cb_D3.SelectedItem.ToString());
            if (D1 != "")
            {
                _objPosition1 = (Position)Enum.Parse(typeof(Position), D1);
                _objPosition2 = (Position)Enum.Parse(typeof(Position), D2);
                _objPosition3 = (Position)Enum.Parse(typeof(Position), D3);
            }
            this.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

            
        }
    }
}
