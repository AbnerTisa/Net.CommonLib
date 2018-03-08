/**********************************************************
** �ļ����� ToolEllipse.cs
** �ļ�����:Ellipse Tool
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

using DrawTools.DocToolkit;
using System.Windows.Forms;

namespace DrawTools.DeviceTools
{
    /// <summary>
    /// Ellipse tool
    /// </summary>
    public class ToolEllipse : ToolRectangle
    {
        public ToolEllipse()
        {
            Cursor = new Cursor(GetType(), "Ellipse.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new DrawEllipse(e.X, e.Y, 1, 1));
        }
    }
}