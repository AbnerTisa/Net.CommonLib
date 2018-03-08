/**********************************************************
** �ļ����� Command.cs
** �ļ�����:�����������
**
**---------------------------------------------------------
**�޸���ʷ��¼��
**�޸�ʱ��      �޸���    �޸����ݸ�Ҫ
**2016-02-02    xwj       ����
**
**********************************************************/

namespace DrawTools.Command
{
    /// <summary>
    /// Base class for commands used for Undo - Redo
    /// </summary>
    public abstract class Command
    {
        protected GraphicsList graphicsList;

        public Command(GraphicsList graphicsList)
        {
            this.graphicsList = graphicsList;
        }

        public abstract void Execute();

        public abstract void Undo();

        public abstract void Redo();
    }
}