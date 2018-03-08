/**********************************************************
** �ļ����� ToolAGMChannelDual.cs
** �ļ�����:AGMChannelDual Tool
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
    public class ToolAGMChannelDual : ToolRectangle
    {
        public ToolAGMChannelDual()
        {
            Cursor = new Cursor(GetType(), "Ellipse.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new AGMChannelDual(e.X, e.Y, 71, 27));
        }
    }
}