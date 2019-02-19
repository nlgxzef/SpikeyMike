using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeyMike
{
    public partial class SpikeyMikesMain : Form
    {
        public SpikeyMikesMain()
        {
            InitializeComponent();
        }

        private void ButtonSelectOBJ_Click(object sender, EventArgs e)
        {
            if (OpenOBJFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Do obj file
                    string text = File.ReadAllText(OpenOBJFile.FileName);

                    if (ReplaceObjectsCheck.Checked)
                    {
                        text = text.Replace("\no ", "\ng ");
                    }

                    foreach (ListViewItem i in ReplaceList.Items)
                    {
                        text = text.Replace(i.Text, i.SubItems[1].Text);
                    }

                    if (!File.Exists(OpenOBJFile.FileName + ".bak")) File.Copy(OpenOBJFile.FileName, OpenOBJFile.FileName + ".bak", false);

                    File.WriteAllText(OpenOBJFile.FileName, text);

                    // Do mtl file

                    string MTLFile = Path.Combine(Path.GetDirectoryName(OpenOBJFile.FileName), Path.GetFileNameWithoutExtension(OpenOBJFile.FileName) + ".mtl");

                    if (File.Exists(MTLFile))
                    {
                        text = File.ReadAllText(MTLFile);

                        foreach (ListViewItem i in ReplaceList.Items)
                        {
                            text = text.Replace(i.Text, i.SubItems[1].Text);
                        }

                        if (!File.Exists(MTLFile + ".bak")) File.Copy(MTLFile, MTLFile + ".bak", false);

                        File.WriteAllText(MTLFile, text);
                    }

                    MessageBox.Show("Done!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception:" + Environment.NewLine + ex.ToString());
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var i = new ListViewItem();

            i.Text = TextFind.Text;
            i.SubItems.Add(TextReplace.Text);

            ReplaceList.Items.Add(i);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in ReplaceList.SelectedItems)
            {
                ReplaceList.Items.Remove(i);
            }
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in ReplaceList.SelectedItems)
            {
                if (lvi.Index > 0)
                {
                    int index = lvi.Index - 1;
                    ReplaceList.Items.RemoveAt(lvi.Index);
                    ReplaceList.Items.Insert(index, lvi);
                }
            }
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in ReplaceList.SelectedItems)
            {
                if (lvi.Index < ReplaceList.Items.Count - 1)
                {
                    int index = lvi.Index + 1;
                    ReplaceList.Items.RemoveAt(lvi.Index);
                    ReplaceList.Items.Insert(index, lvi);
                }
            }
        }
    }
}
