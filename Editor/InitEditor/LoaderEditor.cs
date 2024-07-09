using UnityEditor;

namespace ET
{
    public static class LoaderEditor
    {
        [MenuItem("ET/Loader/Init")]
        public static void Init()
        {
            LinkSlnHelper.Run();
            
            // 刷新4个程序集的asmdef引用
            ScriptsReferencesHelper.Run();
            
            CodeModeChangeHelper.ChangeToCodeMode("ClientServer");
            
            // 设置GlobalConfig中的SceneName字段
            SceneNameSetHelper.Run();
            
            InitScriptHelper.Run();
            
            DefineHelper.EnableDefineSymbols("INITED", true);
        }
    }
}