﻿using ClientDependency.Core;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.CheckboxTable.PropertyEditors
{
    [PropertyEditor(PropertyEditorAlias, "Checkbox Table", "~/App_Plugins/CheckboxTable/CheckboxTable.html", ValueType = "JSON")]
    [PropertyEditorAsset(ClientDependencyType.Css, "~/App_Plugins/CheckboxTable/CheckboxTable.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/CheckboxTable/CheckboxTable.js")]
    public class CheckboxTablePropertyEditor : PropertyEditor
    {
        public const string PropertyEditorAlias = "Our.Umbraco.CheckboxTable";

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new CheckboxTablePreValueEditor();
        }
    }
}
