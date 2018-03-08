/**********************************************************
** �ļ����� CommandDeleteAll.cs
** �ļ�����:Delete All command
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

using DrawTools.DocToolkit;
using System.Collections.Generic;

namespace DrawTools.Command
{
    public class CommandDeleteAll : Command
    {
        private List<DrawObject> cloneList;

        public CommandDeleteAll(GraphicsList graphiList)
            : base(graphiList)
        {
            cloneList = new List<DrawObject>();

            // Make clone of the whole list.
            // Add objects in reverse order because GraphicsList.Add
            // insert every object to the beginning.
            int n = graphicsList.Count;

            for (int i = n - 1; i >= 0; i--)
            {
                cloneList.Add(graphicsList[i].Clone());
            }
        }

        public override void Execute()
        {
            graphicsList.BomVerify.Clear();
            graphicsList.AGMVerify.Clear();
            //graphicsList.AGMDualVerify.Clear();
            graphicsList.TCMVerify.Clear();
            graphicsList.TVMVerify.Clear();
            graphicsList.SCVerify.Clear();
            DrawObject._objIdInc = 1;
            graphicsList.Clear();
            //LogHelper.DeviceDeviceLogInfo(string.Format("ɾ����վ:{0}�������豸������Ϣ",));
        }

        public override void Undo()
        {
            // Add all objects from clone list to list -
            // opposite to DeleteAll
            foreach (DrawObject o in cloneList)
            {
                graphicsList.Add(o);
            }
        }

        public override void Redo()
        {
            // Clear list - make DeleteAll again
            graphicsList.BomVerify.Clear();
            graphicsList.AGMVerify.Clear();
            //graphicsList.AGMDualVerify.Clear();
            graphicsList.TCMVerify.Clear();
            graphicsList.TVMVerify.Clear();
            DrawObject._objIdInc = 1;
            graphicsList.Clear();
        }
    }
}