using Syncfusion.TreeView.Engine;
using TreeViewMaui.TemplateSelector;

namespace TreeViewMaui
{
    internal class ItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Template1 { get; set; }
        public DataTemplate Template2 { get; set; }
        public ItemTemplateSelector()
        {
            this.Template1 = new DataTemplate(typeof(Template1));
            this.Template2 = new DataTemplate(typeof(Template2));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var treeNodeView = item as TreeViewNode;
            if (treeNodeView == null)
            {
                return null;
            }

            if (treeNodeView.Level == 0)
            {
                return Template1;
            }
            else
            {
                return Template2;
            }
        }
    }
}
