using GymSystem.Core;
using OOP_Proje1.Core;
using System;
using System.Windows.Forms;

namespace WinFormsAppFront   // Sende ne yazıyorsa onu bırakabilirsin
{
    public partial class MemberForm : Form
    {
        private GymSystem.Core.GymSystem _system = null!;
        private Member _member = null!;

        // Designer'ın kullandığı parametresiz constructor
        public MemberForm()
        {
            InitializeComponent();
        }

        // Bizim kullandığımız constructor (LoginForm burayı çağıracak)
        public MemberForm(GymSystem.Core.GymSystem system, Member member) : this()
        {
            _system = system;
            _member = member;

            this.Text = $"Member Panel - {_member.AdSoyad}";

            MessageBox.Show(
                $"Welcome {member.AdSoyad}\n" +
                $"Package: {_member.UyelikPaketi?.Ad}\n" +
                $"Membership ends: {_member.UyelikBitisTarihi:d}",
                "Member Panel");
        }
    }
}
