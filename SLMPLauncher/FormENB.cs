using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SLMPLauncher
{
    public partial class FormENB : Form
    {
        public static string pathENBLocalINI = FormMain.pathGameFolder + "enblocal.ini";
        public static string pathENBSeriesINI = FormMain.pathGameFolder + "enbseries.ini";
        string pathENBfolder = FormMain.pathGameFolder + @"Skyrim\ENB\";
        string compressMemory = "Сжимать видеопамять для уменьшение её объема, снижает производительность.";
        string confirmTitle = "Подтверждение";
        string noFileSelect = "Не выбран файл.";
        string occlusionCulling = "Отключения рендеринга скрытых объектов, может вызывать мерцания.";
        string removeENBFiles = "Удалить все файлы ENB?";
        string reservedMemory = "Резервирование памяти под эффекты ENB.";
        string waitBuffer = "Ожидание завершения кадра видеоадаптером, снижает производительность.";
        string expandMemory = "Сдвигает адресное пространство игры, может вызывать вылет при первой загрузке.";
        bool aa = false;
        bool af = false;
        bool autovram = false;
        bool compress = false;
        bool fps = false;
        bool oc = false;
        bool setupENB = false;
        bool waitbuffer = false;
        bool expandmemory = false;

        public FormENB()
        {
            InitializeComponent();
            FuncMisc.setFormFont(this);
            Directory.SetCurrentDirectory(FormMain.pathLauncherFolder);
            if (FormMain.numberStyle > 1)
            {
                imageBackgroundImage();
            }
            if (FormMain.langTranslate == "EN")
            {
                langTranslateEN();
            }
            toolTip1.SetToolTip(label3, reservedMemory);
            toolTip1.SetToolTip(comboBox3, reservedMemory);
            toolTip1.SetToolTip(button_Compress, compressMemory);
            toolTip1.SetToolTip(label9, compressMemory);
            toolTip1.SetToolTip(button_WaitBuffer, waitBuffer);
            toolTip1.SetToolTip(label6, waitBuffer);
            toolTip1.SetToolTip(label14, occlusionCulling);
            toolTip1.SetToolTip(button_OC, occlusionCulling);
            toolTip1.SetToolTip(label17, expandMemory);
            toolTip1.SetToolTip(buttonExpandMemory, expandMemory);
            refreshFileList();
            refreshAllValue();
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void imageBackgroundImage()
        {
            BackgroundImage = Properties.Resources.FormBackground;
            FuncMisc.textColor(this, System.Drawing.SystemColors.ControlLight, System.Drawing.Color.FromArgb(30, 30, 30), false);
        }
        private void langTranslateEN()
        {
            button_deleteAllENB.Text = "UnInstall";
            button_unpackENB.Text = "Install";
            compressMemory = "Compress video memory to reduce its volume, reduces performance.";
            confirmTitle = "Confirm";
            label10.Text = @"Files from Skyrim\ENB";
            label12.Text = "System settings";
            label13.Text = "Filtration:";
            label14.Text = "Occlusion culling:";
            label15.Text = "Auto video memory:";
            label16.Text = "Video memory:";
            label17.Text = "Shift memory:";
            label3.Text = "Reserved:";
            label4.Text = "Antialiasing:";
            label5.Text = "FPS limit:";
            label6.Text = "Wait busy renderer:";
            label9.Text = "Compress memory:";
            noFileSelect = "No file select.";
            occlusionCulling = "Disable the rendering of hidden objects, can cause flicker.";
            removeENBFiles = "Delete all ENB files?";
            reservedMemory = "Reservation of memory for ENB effects.";
            waitBuffer = "Waiting for the frame to complete the video adapter, reduces performance.";
            expandMemory = "Shifts the address space of the game, it can cause a crash on the first load.";
        }
        private void FormENB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button_Close_Click(this, new EventArgs());
            }
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void refreshAllValue()
        {
            setupENB = FuncSettings.checkENB();
            refreshMemory();
            refreshAA();
            refreshAF();
            refreshFPS();
            refresWaitBuffer();
            refresAutoDetect();
            refresCompressMemory();
            refresOcclusionCulling();
            refresbuttonExpandMemory();
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void refreshFileList()
        {
            if (Directory.Exists(pathENBfolder))
            {
                foreach (string line in Directory.GetFiles(pathENBfolder, "*.rar"))
                {
                    listBox1.Items.Add(Path.GetFileName(line));
                }
            }
        }
        private void button_unpackENB_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedItem.ToString().ToUpper().Contains("ENB"))
                {
                    FuncClear.removeENB();
                }
                else if (listBox1.SelectedItem.ToString().ToUpper().Contains("DOF"))
                {
                    FuncFiles.deleteAny(FormMain.pathGameFolder + @"ENBSeries\enbdepthoffield.fx.ini");
                }
                enbUnpack(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show(noFileSelect);
            }
        }
        private void enbUnpack(string filename)
        {
            FuncMisc.toggleButtons(this, false);
            listBox1.Enabled = false;
            FuncMisc.unpackRAR(pathENBfolder + filename);
            FuncMisc.toggleButtons(this, true);
            listBox1.Enabled = true;
            if (filename.ToUpper().Contains("ENB"))
            {
                FuncSettings.restoreENBLimit();
                FuncSettings.restoreENBAdapter();
                FuncSettings.restoreENBBorderless();
                FuncSettings.restoreENBVSync();
                FuncSettings.restoreENBVideoMemory();
            }
            refreshAllValue();
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_deleteAllENB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(removeENBFiles, confirmTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FuncClear.removeENB();
                FuncSettings.checkENB();
                refreshAllValue();
            }
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_AA_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "ANTIALIASING", "EnableEdgeAA", (!aa).ToString().ToLower());
            refreshAA();
        }
        private void refreshAA()
        {
            aa = FuncMisc.refreshButton(button_AA, pathENBLocalINI, "ANTIALIASING", "EnableEdgeAA", null, false);
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_AF_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "ENGINE", "ForceAnisotropicFiltering", (!af).ToString().ToLower());
            refreshAF();
        }
        private void refreshAF()
        {
            af = FuncMisc.refreshButton(button_AF, pathENBLocalINI, "ENGINE", "ForceAnisotropicFiltering", null, false);
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_FPS_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "LIMITER", "EnableFPSLimit", (!fps).ToString().ToLower());
            refreshFPS();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (setupENB && fps)
            {
                FormMain.predictFPS = FuncParser.stringToInt(comboBox1.SelectedItem.ToString());
                FuncSettings.physicsFPS();
            }
        }
        private void refreshFPS()
        {
            fps = FuncMisc.refreshButton(button_FPS, pathENBLocalINI, "LIMITER", "EnableFPSLimit", null, false);
            if (setupENB && fps)
            {
                FuncMisc.refreshComboBox(comboBox1, new List<double>() { 30, 60, 75, 90, 120, 144, 240 }, FuncParser.intRead(pathENBLocalINI, "LIMITER", "FPSLimit"), false, comboBox1_SelectedIndexChanged);
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }
            comboBox1.Enabled = setupENB && fps;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (setupENB)
            {
                FuncParser.iniWrite(pathENBLocalINI, "MEMORY", "ReservedMemorySizeMb", comboBox3.SelectedItem.ToString());
            }
        }
        private void refreshMemory()
        {
            if (setupENB)
            {
                comboBox3.Enabled = true;
                FuncMisc.refreshComboBox(comboBox3, new List<double>() { 64, 128, 256, 384, 512, 640, 768, 896, 1024 }, FuncParser.intRead(pathENBLocalINI, "MEMORY", "ReservedMemorySizeMb"), false, comboBox3_SelectedIndexChanged);
            }
            else
            {
                comboBox3.SelectedIndex = -1;
                comboBox3.Enabled = false;
            }
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_Compress_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "MEMORY", "EnableCompression", (!compress).ToString().ToLower());
            refresCompressMemory();
        }
        private void refresCompressMemory()
        {
            compress = FuncMisc.refreshButton(button_Compress, pathENBLocalINI, "MEMORY", "EnableCompression", null, false);
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_WaitBuffer_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "LIMITER", "WaitBusyRenderer", (!waitbuffer).ToString().ToLower());
            refresWaitBuffer();
        }
        private void refresWaitBuffer()
        {
            waitbuffer = FuncMisc.refreshButton(button_WaitBuffer, pathENBLocalINI, "LIMITER", "WaitBusyRenderer", null, false);
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void buttonExpandMemory_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "MEMORY", "ExpandSystemMemoryX64", (!expandmemory).ToString().ToLower());
            refresbuttonExpandMemory();
        }
        private void refresbuttonExpandMemory()
        {
            expandmemory = FuncMisc.refreshButton(buttonExpandMemory, pathENBLocalINI, "MEMORY", "ExpandSystemMemoryX64", null, false);
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_OC_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "PERFORMANCE", "EnableOcclusionCulling", (!oc).ToString().ToLower());
            refresOcclusionCulling();
        }
        private void refresOcclusionCulling()
        {
            oc = FuncMisc.refreshButton(button_OC, pathENBLocalINI, "PERFORMANCE", "EnableOcclusionCulling", null, false);
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void button_AutoMemory_Click(object sender, EventArgs e)
        {
            FuncParser.iniWrite(pathENBLocalINI, "MEMORY", "AutodetectVideoMemorySize", (!autovram).ToString().ToLower());
            refresAutoDetect();
        }
        private void refresAutoDetect()
        {
            autovram = FuncMisc.refreshButton(button_AutoMemory, pathENBLocalINI, "MEMORY", "AutodetectVideoMemorySize", null, false);
            FuncMisc.refreshNumericUpDown(numericUpDown1, pathENBLocalINI, "MEMORY", "VideoMemorySizeMb", numericUpDown1_ValueChanged);
            numericUpDown1.Enabled = setupENB && !autovram;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FuncParser.iniWrite(FormMain.pathLauncherINI, "ENB", "MemorySizeMb", numericUpDown1.Value.ToString());
            FuncSettings.restoreENBVideoMemory();
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            button_Close.BackgroundImage = Properties.Resources.buttonCloseGlow;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            button_Close.BackgroundImage = Properties.Resources.buttonClose;
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}