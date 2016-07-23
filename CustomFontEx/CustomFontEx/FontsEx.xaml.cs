using System;
using Xamarin.Forms;

namespace CustomFontEx
{
    public partial class FontsEx : ContentPage
    {
        public FontsEx()
        {
            InitializeComponent();
        }

        public void OnIndexChanged(object sender, EventArgs args)
        {
            if (pkrSelFont.SelectedIndex != -1)
            {
                string sFontName = pkrSelFont.Items[pkrSelFont.SelectedIndex];
                string sFontFile = GetFontFileName(sFontName);
                string sFontDetails4Windows = "/Assets/Fonts/" + sFontFile + ".ttf#" + sFontName;
                Device.OnPlatform(
        iOS: () =>
        {
            lblItalics.FontFamily = sFontName;
            lblBold.FontFamily = sFontName;
            lblBoldMicro.FontFamily = sFontName;
            lblBiggestSize.FontFamily = sFontName;
            lblMultiAttribue.FontFamily = sFontName;
        },
        Android: () =>
        {
            CustomFontEffect.SetFontFileName(lblItalics, sFontFile);
            CustomFontEffect.SetFontFileName(lblBold, sFontFile);
            CustomFontEffect.SetFontFileName(lblBoldMicro, sFontFile);
            CustomFontEffect.SetFontFileName(lblBiggestSize, sFontFile);
            CustomFontEffect.SetFontFileName(lblMultiAttribue, sFontFile);
        },
        WinPhone: () =>
        {
            lblItalics.FontFamily = sFontDetails4Windows;
            lblBold.FontFamily = sFontDetails4Windows;
            lblBoldMicro.FontFamily = sFontDetails4Windows;
            lblBiggestSize.FontFamily = sFontDetails4Windows;
            lblMultiAttribue.FontFamily = sFontDetails4Windows;
        }
            );
            }
        }

        private string GetFontFileName(string sFontName) {
            var vReturnValue = "";
            switch (sFontName)
            {
                case "AbeatByKai":
                    vReturnValue = "abeatbyKaiRegular"; break;
                case "Great Vibes":
                    vReturnValue = "GreatVibes-Regular"; break;
                case "MRF Blooming Petunia":
                    vReturnValue = "MRF-BloomingPetunia"; break;
                case "Myriad Pro Light":
                    vReturnValue = "MyriadPro-Semibold"; break;
                case "Neon 80s":
                    vReturnValue = "Neon"; break;
                case "Waltograph UI":
                    vReturnValue = "waltographUI"; break;
            }
            return vReturnValue;
        }
    }
}
