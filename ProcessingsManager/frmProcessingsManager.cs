using ProcessingsManager.UIL;
using ExportPlatform.BLL.VO;
using ExportPlatform.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessingsManager
{
    public partial class frmProcessingsManager : Form
    {
        private ProcessingXmlDao processingDao;
        private const int FIRST_PROCESSING = 1;

        public frmProcessingsManager()
        {
            InitializeComponent();
            this.processingDao = new ProcessingXmlDao();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ProcessingVO processing = processingDao.Get(FIRST_PROCESSING);
            LoadComponents(processing);
        }

        private void LoadComponents(ProcessingVO processing)
        {

        }

    }
}
