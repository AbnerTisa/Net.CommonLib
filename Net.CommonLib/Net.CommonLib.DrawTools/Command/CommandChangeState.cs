/**********************************************************
** �ļ����� CommandChangeState.cs
** �ļ�����: Changing state of existing objects: move, resize, change properties.
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

using DrawTools.DocToolkit;
using System;
using System.Collections.Generic;

namespace DrawTools.Command
{
    public class CommandChangeState : Command
    {
        private List<DrawObject> listBefore;

        private List<DrawObject> listAfter;

        public CommandChangeState(GraphicsList graphicsList)
            : base(graphicsList)
        {
            FillList(graphicsList, ref listBefore);
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public void NewState(GraphicsList graphicsList)
        {
            FillList(graphicsList, ref listAfter);
        }

        public override void Undo()
        {
            ReplaceObjects(graphicsList, listBefore);
        }

        public override void Redo()
        {
            ReplaceObjects(graphicsList, listAfter);
        }

        private void ReplaceObjects(GraphicsList graphicsList, List<DrawObject> list)
        {
            for (int i = 0; i < graphicsList.Count; i++)
            {
                DrawObject replacement = null;

                foreach (DrawObject o in list)
                {
                    if (o.ID == graphicsList[i].ID)
                    {
                        replacement = o;
                        break;
                    }
                }

                if (replacement != null)
                {
                    graphicsList.Replace(i, replacement);
                }
            }
        }

        private void FillList(GraphicsList graphicsList, ref List<DrawObject> listToFill)
        {
            listToFill = new List<DrawObject>();

            foreach (DrawObject o in graphicsList.Selection)
            {
                listToFill.Add(o.Clone());
            }
        }
    }
}