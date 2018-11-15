<!-- default file list -->
*Files to look at*:

* [CellForegroundConverter.cs](./CS/SLGridExample/CellForegroundConverter.cs) (VB: [CellForegroundConverter.vb](./VB/SLGridExample/CellForegroundConverter.vb))
* [MainPage.xaml](./CS/SLGridExample/MainPage.xaml) (VB: [MainPage.xaml](./VB/SLGridExample/MainPage.xaml))
<!-- default file list end -->
# How to change focused row foreground


<p>This sample shows how to adjust the foreground of data rows in a grid.</p><p>Cell foreground is defined at the CellContentPresenterTemplate level as CellEditor's foreground brush. Its color may be changed via custom visual states. Another approach is to bind the Foreground property to a current row's state via a converter, as it is shown in this sample project.</p><p>Note that CellEditor's data context is represented by a <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGridGridCellDataMembersTopicAll"><u>GridCellData</u></a> class object. Therefore, it is possible to bind a cell's foreground to other data properties in order to achieve custom conditional cell formatting.</p><p>CellContentPresenterTemplate is applied via a custom TableView's <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGridDataViewBase_CellStyletopic"><u>CellStyle</u></a>. This way, all grid cells will use a new CellContentPresenterTemplate. It is possible to apply CellContentPresenterTemplate with custom foreground adjustment to individual columns by defining a custom CellStyle at the level of a particular column using the GridColumn.CellStyle property.</p><p>See also: <a href="https://www.devexpress.com/Support/Center/p/E3890">E3890: How to change focused row background</a></p>

<br/>


