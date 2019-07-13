using HelloWorldServiceContract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WCFHostWPFAppTest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceProcess = Process.Start("ConsoleApp1.exe");

            var address = new EndpointAddress("net.tcp://localhost:8808/service");
            var binding = new NetTcpBinding();
            var factory = new ChannelFactory<IHelloWorldService>(binding, address);
            var channel = factory.CreateChannel();

            this.Loaded += (_, __) =>
            {
                // サービス呼び出し
                var IHelloWorldService = channel.SayHello("test");
                Console.WriteLine("SayHello() = {0}", IHelloWorldService);

            };

            this.Closing += (_, __) =>
            {

                factory.Close();
                serviceProcess.Kill();
            };
        }
    }
}
