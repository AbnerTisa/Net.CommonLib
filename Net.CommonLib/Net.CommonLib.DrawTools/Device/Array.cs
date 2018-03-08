/**********************************************************
** �ļ����� Array.cs
** �ļ�����:Array�豸
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

using DrawTools.DocToolkit;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawTools.Device
{
    public class Array : DrawRectangle
    {
        private int _objectID;
        private bool _flag;
        private bool _showProperty;

        public Array()
            : this(0, 0, 1, 1)
        {
        }

        public Array(int x, int y, int width, int height)
            : base()
        {
            Rectangle = new Rectangle(x, y, width, height);

            _logicIDTail = "";
            _objectID = _objIdInc++;
            _flag = false;
            _showProperty = false;

            Initialize();
        }

        /// <summary>
        /// Clone this instance
        /// </summary>
        public override DrawObject Clone()
        {
            Array drawArray = new Array();
            _objIdInc--;
            drawArray.Rectangle = this.Rectangle;
            drawArray.Flag = this.Flag;

            FillDrawObjectFields(drawArray);
            return drawArray;
        }

        public override void AntiClockWiseDirection()
        { }

        public override void ClockWiseDirection()
        { }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, PenWidth);
            Brush brushout = new SolidBrush(Color.FromArgb(255, 0, 255, 255));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (!_flag)
            {
                Rectangle frect = new Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
                g.FillRectangle(brushout, frect);    //�������
                g.DrawRectangle(pen, Rectangle);       //�����
            }
            else
                g.DrawRectangle(pen, DrawRectangle.GetNormalizedRectangle(Rectangle));

            Brush brushin0 = new SolidBrush(Color.Red);
            StringFormat style = new StringFormat();
            style.Alignment = StringAlignment.Near;
            if (_showProperty)
            {
                g.DrawString(
                     LogicIDTail,
                     new Font("����", 9, FontStyle.Regular),
                     brushin0,
                     Rectangle, style);
            }
            pen.Dispose();
        }

        public int ObjectID
        {
            get { return _objectID; }
            set { _objectID = value; }
        }

        public Rectangle RectangleLs
        {
            get { return Rectangle; }
            set { Rectangle = value; }
        }

        public new string LogicIDTail
        {
            get { return _logicIDTail; }
            set { _logicIDTail = value; }
        }

        public bool Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        public bool ShowProperty
        {
            get { return _showProperty; }
            set { _showProperty = value; }
        }

        public override void ShowItemProperty(bool IsShow)
        {
            this._showProperty = IsShow;
        }

        public override Rectangle GetRectangle()
        {
            return Rectangle;
        }
    }
}