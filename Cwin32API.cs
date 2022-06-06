using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace callXBFLibrary
{
    class Cwin32API
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern uint GetPrivateProfileString(
           string lpAppName,
           string lpKeyName,
           string lpDefault,
           StringBuilder lpReturnedString,
           uint nSize,
           string lpFileName);

        private string iniFileName;


        public Cwin32API(string fileName)
        {
            this.iniFileName = fileName;
        }

        /**
         * <p> Read Ini File Value </p>
         * 
         * @param name="section"
         * @param name="key"
         * @returns string
         * 
         **/
        public string readIniFileVal(string section, string key)
        {
            StringBuilder retStrBuilder = new StringBuilder(256);
            GetPrivateProfileString(
                section, 
                key, 
                "", 
                retStrBuilder, 
                256, 
                iniFileName);
            return retStrBuilder.ToString();
        }
    }

    
}
