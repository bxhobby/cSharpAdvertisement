using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace advertisement
{
    public partial class FormVideo : Form
    {
        //ตัวแปรเก็บชื่อไฟล์วีดีโอ
        List<string> FileList = new List<string>();
        public FormVideo()
        {
            InitializeComponent();
        }

        // Check form already before open
        public bool isFormOpen(Type formType)
        {            
            foreach (Form form in Application.OpenForms)
                if (formType.Name == form.Name)
                    return true;
            return false;
        }

        // ปุ่มเลือกไฟล์วีดีโอ
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.mp4)|*.mp4";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in fileDialog.FileNames.ToList())
                {
                    if (!listVideo.Items.Contains(item))
                    {
                        listVideo.Items.Add(item);
                    }
                }
            }
        }

        // ปุ่มเล่น วีดีโอ
        private void iconButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in listVideo.Items)
            {
                FileList.Add(item.ToString());
            }
            if (FileList.Count == 0)
            {
                return;
            }
            var form2 = new FormMonitor2(FileList);
            if (!isFormOpen(form2.GetType()))
            {
                form2.Location = new Point(0, 0);
                Properties.Settings.Default.display = cmbDisplayList.Text;
                Properties.Settings.Default.Save();
                foreach (var screen in Screen.AllScreens)
                {
                    if (screen.DeviceName == cmbDisplayList.Text)
                    {
                        form2.Location = new Point(screen.Bounds.X, screen.Bounds.Y);
                    }

                    //Console.WriteLine("DisPlay Name : " + screen.DeviceName);
                    //Console.WriteLine("Size : " + screen.Bounds.ToString());
                    //Console.WriteLine("Type : " + screen.GetType().ToString());
                    //Console.WriteLine("Area : " + screen.WorkingArea.ToString());
                    //Console.WriteLine("Primary : " + screen.Primary.ToString());
                }
                form2.Show();
            }            
        }

        // เมื่อเปิด form video ให้โหลดการเลือกจอล่าสุดมาแสดง และแสดงจำนวนจอทั้งหมดที่พบใน cmbDisplay
        private void FormVideo_Load(object sender, EventArgs e)
        {
            foreach (var item in Screen.AllScreens)
            {
                cmbDisplayList.Text = Properties.Settings.Default.display;
                cmbDisplayList.Items.Add(item.DeviceName);
            }
        }

        private void listVideo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
