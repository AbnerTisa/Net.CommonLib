/**********************************************************
** �ļ����� ToolArray.cs
** �ļ�����:Array Tool
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

using System.Windows.Forms;

namespace DrawTools.DeviceTools
{
    public class ToolArray : ToolRectangle
    {
        public ToolArray()
        {
            Cursor = new Cursor(GetType(), "Ellipse.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new DrawTools.Device.Array(e.X, e.Y, 50, 50));
        }
    }
}