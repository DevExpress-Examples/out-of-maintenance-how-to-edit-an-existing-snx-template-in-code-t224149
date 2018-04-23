using System;
using System.Collections.Generic;
using System.Linq;

namespace Snap_API {
    public partial class CategoryForm : DevExpress.XtraEditors.XtraForm {
        public CategoryForm() {
            InitializeComponent();
        }
        public string Role {
            get {
                return cbCategory.EditValue.ToString();
            }
            
        }
    }
}