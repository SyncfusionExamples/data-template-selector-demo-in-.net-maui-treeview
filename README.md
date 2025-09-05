# data-template-selector-demo-in-.net-maui-treeview
This repository demonstrates how to use the DataTemplateSelector concept with the .NET MAUI TreeView (SfTreeView) control. It provides a sample implementation that dynamically selects and applies different templates for tree nodes based on their level or type, enabling flexible and customized UI rendering for hierarchical data.

## Sample

### XAML

```xaml
<ContentPage.BindingContext>
    <local:FileManagerViewModel/>
</ContentPage.BindingContext>

<ContentPage.Resources>
    <ResourceDictionary>
        <local:ItemTemplateSelector x:Key="ItemTemplateSelector" />
    </ResourceDictionary>
</ContentPage.Resources>

<ContentPage.Content>
    <Grid>
        <syncfusion:SfTreeView x:Name="treeView" 
                                   AutoExpandMode="RootNodesExpanded"
                                   ChildPropertyName="SubFiles"
                                   ItemTemplateContextType="Node"
                                   ItemTemplate="{StaticResource ItemTemplateSelector}"
                                   ItemsSource="{Binding ImageNodeInfo}" >

        </syncfusion:SfTreeView>
    </Grid>
</ContentPage.Content>

```

### Template Selector

```csharp
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
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/ ) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
