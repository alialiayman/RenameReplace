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

namespace RenameReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            dfsLog.Clear();
            var files = Directory.GetFiles(dfsFolder.Text).ToList();
            foreach (var file in files)
            {
                var newFileName = Regex.Replace(file, dfsSource.Text,
                    mtch =>
                    {
                        var result = mtch.Result(dfsDestination.Text);
                        if (dffOverwrite.Checked && files.Contains(result))
                        {
                            dfsLog.Text += Environment.NewLine + $"File {result} will Overwite: {file} after rename";
                        }
                        dfsLog.Text += Environment.NewLine + $"File will rename from {Path.GetFileName(file)} to {Path.GetFileName(result)}";
                        return result;
                    }, RegexOptions.IgnoreCase);
            }
            

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            dfsLog.Clear();
            var files = Directory.GetFiles(dfsFolder.Text).ToList();
            foreach (var file in files)
            {
                var newFileName = Regex.Replace(file, dfsSource.Text,
                    mtch =>
                    {
                        var result = mtch.Result(dfsDestination.Text);
                        if (dffOverwrite.Checked && files.Contains(result))
                        {
                            dfsLog.Text += Environment.NewLine + $"File {result} will Overwite: {file} after rename";
                            File.Delete(result);
                        }
                        dfsLog.Text += Environment.NewLine + $"File will rename from {Path.GetFileName(file)} to {Path.GetFileName(result)}";
                        return result;
                    }, RegexOptions.IgnoreCase);

                File.Move(file,newFileName);

            }
        }
    }
}
