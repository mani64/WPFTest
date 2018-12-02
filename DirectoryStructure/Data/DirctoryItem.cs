using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfTreeView.DirectoryStructure.Data {
    class DirctoryItem {
        /// <summary>
        /// Type of the directory item
        /// </summary>
        public DrirectoryItemType Type { get; set; }
        /// <summary>
        /// The absolute path to this directory item
        /// </summary>
        public String FullPath { get; set; }
        /// <summary>
        /// The name of this directory item
        /// </summary>
        public String Name { get { return Type == DrirectoryItemType.drive ? FullPath : DirectoryStructure.GetFileFolderName(FullPath); } }


    }
}
