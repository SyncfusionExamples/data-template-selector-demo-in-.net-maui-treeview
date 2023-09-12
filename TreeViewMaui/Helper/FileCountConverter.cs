using Syncfusion.TreeView.Engine;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMaui
{
    public class FileCountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null) return null;

            var treeViewNode = value as TreeViewNode;
            var count = treeViewNode != null && treeViewNode.HasChildNodes ? treeViewNode.ChildNodes.Count : 0;
            return "(" + count + " files)";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
