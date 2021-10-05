using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomUI.Forms;


namespace Regex_Renamer
{
    public partial class formMain : CustomForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonMultipleRename_Click(object sender, EventArgs e)
        {
            String folderValue = textBoxFolder.Text;
            String regexPattern = textBoxRegex.Text;
            String regexReplace = textBoxReplace.Text;

            Regex regex = new Regex(regexPattern);

            String[] filesToProcess = Directory.GetFiles(folderValue, "*.*", SearchOption.AllDirectories);

            foreach(String file in filesToProcess)
            {
                System.Globalization.TextInfo ti = System.Globalization.CultureInfo.CurrentCulture.TextInfo;

                String fileName = ti.ToTitleCase(Path.GetFileNameWithoutExtension(file)) + Path.GetExtension(file).ToLower();

                if (checkBoxClearUnderscore.Checked)
                {
                    fileName = fileName.Replace("_", " ");
                }

                if (checkBoxClearDash.Checked)
                {
                    fileName = fileName.Replace("-", " ");
                }

                while(fileName.Contains("  "))
                {
                    fileName = fileName.Replace("  ", " ");
                }


                String filePath = Path.GetDirectoryName(file);

                Match regexResult = regex.Match(fileName);

                if (regexResult.Success)
                {
                    String newFileName = regex.Replace(fileName, regexReplace);

                    File.Move(file, $@"{filePath}\{newFileName}");
                }
                else
                {
                    //MessageBox.Show("This shouldn't happen");
                }
            }

            CustomMessageBox.ShowInformation("Done!", "Regex Renamer");
        }

    }
}
