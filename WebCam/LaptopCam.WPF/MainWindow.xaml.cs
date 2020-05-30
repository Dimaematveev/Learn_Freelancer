using System;
using System.Windows;
//Сохраняет каждый десятый кадр
using System.IO;
using AForge.Video;//добавить библиотеку
using AForge.Video.DirectShow;//добавить библиотеку
using System.Drawing;

namespace LaptopCam.WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            getCamList();
            StartFoto();

            Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseVideoSource();
        }

        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        DirectoryInfo dir;
        string dirnew;
        private void StartFoto()
        {
            dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            
            dirnew = dir.CreateSubdirectory("temp").ToString() + "\\";
            if (DeviceExist)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                
                //  CloseVideoSource();
                videoSource.Start();
                var z = videoSource.VideoCapabilities;
            }
        }

        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                    throw new ApplicationException();
                DeviceExist = true;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
            }
        }
        int i = 0;
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ++i;
            if (i % 10 == 0)
            {
                FileStream fs = new FileStream(dirnew + i.ToString() + ".Jpeg", FileMode.Create, FileAccess.ReadWrite);
                Bitmap img = (Bitmap)eventArgs.Frame.Clone();
                Image im = img;
                img.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
        }
        private void CloseVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }
    }
}
