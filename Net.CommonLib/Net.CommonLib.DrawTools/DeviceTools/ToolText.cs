/**********************************************************
** �ļ����� ToolText.cs
** �ļ�����:Text Tool
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

using DrawTools.Device;
using System.Windows.Forms;

namespace DrawTools.DeviceTools
{
    public class ToolText : ToolRectangle
    {
        public ToolText()
        {
            Cursor = new Cursor(GetType(), "Ellipse.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new Text(e.X, e.Y, 80, 40));
        }
    }
}