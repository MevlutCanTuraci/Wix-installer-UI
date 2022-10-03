using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace ExampleService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }


        protected override void OnStart(string[] args)
        {
            try
            {
                File.AppendAllText($"{AppDomain.CurrentDomain.BaseDirectory}log.txt", $"Servis başladı!");
            }
            catch (Exception ex)
            {
                File.AppendAllText($"{AppDomain.CurrentDomain.BaseDirectory}log.txt", $"Error! -> {ex.Message}");
            }

        }


        protected override void OnStop()
        {
            try
            {
                File.AppendAllText($"{AppDomain.CurrentDomain.BaseDirectory}log.txt", $"Servis durduruldu!");
            }
            catch (Exception ex)
            {
                File.AppendAllText($"{AppDomain.CurrentDomain.BaseDirectory}log.txt", $"Error! -> {ex.Message}");
            }
        }


        protected override void OnShutdown()
        {
            try
            {
                File.AppendAllText($"{AppDomain.CurrentDomain.BaseDirectory}log.txt", $"Servis zorla kapatıldı!");
            }
            catch (Exception ex)
            {
                File.AppendAllText($"{AppDomain.CurrentDomain.BaseDirectory}log.txt", $"Error! -> {ex.Message}");
            }
        }


    }
}