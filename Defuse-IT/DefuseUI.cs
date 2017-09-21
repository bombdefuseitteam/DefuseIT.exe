using MetroFramework.Forms;
using System;

namespace Defuse_IT
{
    public partial class DefuseUI : MetroForm
    {
        public DefuseUI()
        {
            InitializeComponent();


            WebcamVLC.playlist.add("http://192.168.1.2:8080/video");
            WebcamVLC.playlist.play();
        }

        private void DefuseUI_Load(object sender, EventArgs e)
        {

        }

    }
}
