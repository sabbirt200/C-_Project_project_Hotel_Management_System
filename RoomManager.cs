using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class RoomManager : Form
    {
      
        private Panel homePanelReference; // Reference to the homepanel control in the home form

        public RoomManager(Panel homePanel)
        {
            InitializeComponent();
            homePanelReference = homePanel; // Assign the passed homepanel reference
            guna2DataGridView1.CellClick += DataGridView1_CellClick;
        }
        private void RoomManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_Management_SystemDataSet.RoomManager' table. You can move, or remove it, as needed.
            this.roomManagerTableAdapter.Fill(this.hotel_Management_SystemDataSet.RoomManager);

        }
         private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];
                string rowData = selectedRow.Cells[e.ColumnIndex].Value?.ToString();

                switch (e.RowIndex)
                {
                    case 0:
                        _101 form101 = new _101(rowData, homePanelReference);
                        form101.ShowInHomePanel();
                        break;
                    case 1:
                        _102 form102 = new _102(rowData, homePanelReference);
                        form102.ShowInHomePanel();
                        break;
                    case 2:
                        _103 form103 = new _103(rowData, homePanelReference);
                        form103.ShowInHomePanel();
                        break;
                    case 3:
                        _104 form104 = new _104(rowData, homePanelReference);
                        form104.ShowInHomePanel();
                        break;
                    case 4:
                        _201 form105 = new _201(rowData, homePanelReference);
                        form105.ShowInHomePanel();
                        break;
                    case 5:
                        _202 form106 = new _202(rowData, homePanelReference);
                        form106.ShowInHomePanel();
                        break;
                    case 6:
                        _203 form107 = new _203(rowData, homePanelReference);
                        form107.ShowInHomePanel();
                        break;
                    case 7:
                        _301 form108 = new _301(rowData, homePanelReference);
                        form108.ShowInHomePanel();
                        break;
                    case 8:
                        _302 form109 = new _302(rowData, homePanelReference);
                        form109.ShowInHomePanel();
                        break;
                    case 9:
                        _401 form110 = new _401(rowData, homePanelReference);
                        form110.ShowInHomePanel();
                        break;
                    case 10:
                        _402 form111 = new _402(rowData, homePanelReference);
                        form111.ShowInHomePanel();
                        break;
                    case 11:
                        _403 form112 = new _403(rowData, homePanelReference);
                        form112.ShowInHomePanel();
                        break;
                    
                    default:
                        // Handle cases for other row indices if needed
                        break;
                }
            }


        }
    }
}
