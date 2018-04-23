#region #SystemUsings
using System;
using System.Data.OleDb;
using System.Windows.Forms;
#endregion #SystemUsings

#region #DevExpressData
#endregion #DevExpressData

#region #SnapApi
using DevExpress.Snap.Core.API;
#endregion #SnapApi

#region #RichEditApi
using DevExpress.XtraRichEdit.API.Native;
#endregion #RichEditApi

using Snap_API.nwindDataSetTableAdapters;
using DevExpress.XtraEditors;
using System.Drawing;



namespace Snap_API {
    public partial class Form1 : XtraForm {        
        public Form1() {
            InitializeComponent();
          
        }
        public Form1(string role) {
            InitializeComponent();
            snapControl1.DataSource = GetDataSource();
            snapControl1.LoadDocumentTemplate("SnapTemplate.snx", SnapDocumentFormat.Snap);

            if(role == "Manager") {
                EditTemplate();
            }
        }

        private BindingSource GetDataSource() {           
            nwindDataSet dataSource = new nwindDataSet();
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb";

            ProductsTableAdapter products = new ProductsTableAdapter();
            products.Connection = connection;
            products.Fill(dataSource.Products);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            bindingSource.DataMember = "Products";

            return bindingSource;
        }

        private SnapList FindList() {
            SnapList list = null;
            foreach(Field field in snapControl1.Document.Fields) {

                list = snapControl1.Document.ParseField(field) as SnapList;
                if(object.ReferenceEquals(list, null))
                    continue;
                else {
                    break;
                }
            }
            return list;
        }
        private  void AddColumn(SnapList list, string columnName, string caption) {
            SnapDocument listHeader = list.ListHeader;
            Table listHeaderTable = listHeader.Tables[0];
            listHeaderTable.TableLayout = TableLayoutType.Fixed;
            TableCellCollection listHeaderCells = listHeaderTable.FirstRow.Cells;
            TableCell columnHeader = listHeaderCells.InsertAfter(listHeaderCells.Count - 1);
            listHeader.InsertText(columnHeader.ContentRange.Start, caption);
            CharacterProperties prop = listHeader.BeginUpdateCharacters(columnHeader.ContentRange);
            prop.Bold = true;
            prop.ForeColor = Color.YellowGreen;
            listHeader.EndUpdateCharacters(prop);

            SnapDocument listRow = list.RowTemplate;
            Table listRowTable = listRow.Tables[0];
            listRowTable.TableLayout = TableLayoutType.Fixed;
            TableCellCollection listRowTableCells = listRowTable.FirstRow.Cells;
            TableCell column = listRowTableCells.InsertAfter(listRowTableCells.Count - 1);
            listRow.CreateSnText(column.ContentRange.Start, columnName);
        }
        private void EditTemplate() {
            SnapList list = FindList();

            list.BeginUpdate();
         
            AddColumn(list, "Discontinued", "Discontinued");
            AddColumn(list, "UnitsInStock", "Units In Stock");
            AddColumn(list, "QuantityPerUnit", "Quantity Per Unit");

            list.EndUpdate();
            list.Field.Update();
        }
       
    }
}
