using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using xbfInfoLib;

namespace callXBFLibrary
{
    public partial class frmCall_XBF : Form
    {
        private Cwin32API ini;
        private string strConn;
        private string currDir;

        public frmCall_XBF()
        {
            InitializeComponent();

            currDir = Directory.GetCurrentDirectory();

            ini = new Cwin32API(currDir + "/xbfConfig.ini");
        }

        private void btnWriteXBF_Click(object sender, EventArgs e)
        {
            Boolean flagSQL = false;
            Boolean flagMSSQL = false;
            Boolean flagSecu = false;
            string sectionName = ini.readIniFileVal("config", "type");
            string strSrv = ini.readIniFileVal(sectionName, "Server");
            if (!Equals(strSrv, ""))
                flagSQL = true;
            if (flagSQL)
            {
                if (Equals(sectionName, "MSSQL"))
                    flagMSSQL = true;

                if (flagMSSQL)
                    strConn =
                        "dbType=0;"
                        + "Password=" + ini.readIniFileVal(sectionName, "Pwd") + ";"
                        + "Persist Security Info=True;"
                        + "User ID=" + ini.readIniFileVal(sectionName, "User") + ";"
                        + "Initial Catalog=" + ini.readIniFileVal(sectionName, "DB") + ";"
                        + "Data Source=" + ini.readIniFileVal(sectionName, "Server");
                else
                    strConn = "dbType=2;" 
                        + "Data Source=" + ini.readIniFileVal(sectionName, "Server") + ";"
                        + "User Id=" + ini.readIniFileVal(sectionName, "User") + ";"
                        + "Password=" + ini.readIniFileVal(sectionName, "Pwd") + ";"
                        + "Database=" + ini.readIniFileVal(sectionName, "DB") + ";"
                        + "Convert Zero Datetime=True";

            }
            else // MS Access
            {
                string strPWD = ini.readIniFileVal(sectionName, "Pwd");
                if (!Equals(strPWD, ""))
                    flagSecu = true;
                if (flagSecu)
                {
                    strConn =
                        "dbType=1;"
                        + "Data Source=" + ini.readIniFileVal(sectionName, "DB") + ";"
                        + "Persist Security Info=False;"
                        + "Jet OLEDB:Database Password=" + ini.readIniFileVal(sectionName, "Pwd");
                }
                else
                {
                    strConn =
                         "dbType=1;"
                        + "Data Source=" + ini.readIniFileVal(sectionName, "DB") + ";"
                        + "Persist Security Info=True";
                }
            }

            MessageBox.Show(strConn);
            

            xbfInfoLib.FormatClass xbf = new FormatClass();
            xbf.setFileInfo(strConn);
        }

        private void btnReadXBF_Click(object sender, EventArgs e)
        {
            xbfInfoLib.FormatClass xbf = new FormatClass();

            string filePath = currDir + "/" + edtFileName.Text;
            string strRet = xbf.getFileInfo(filePath);
            MessageBox.Show(strRet);
        }
    }
}