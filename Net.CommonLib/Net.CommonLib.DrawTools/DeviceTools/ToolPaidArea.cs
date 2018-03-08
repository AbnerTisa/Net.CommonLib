/**********************************************************
** �ļ����� ToolPaidArea.cs
** �ļ�����:PaidArea Tool
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
    public class ToolPaidArea : ToolRectangle
    {
        public ToolPaidArea()
        {
            Cursor = new Cursor(GetType(), "Line.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new PaidArea(e.X, e.Y, 150, 100));
        }
    }
}