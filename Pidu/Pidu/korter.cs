using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
namespace Pidu
{
    class korter
    {
        private int maksimumsuurus = 10;
        List<string> inimesed = new List<string>();

        public void lisaInimene(string inimene)
        {
            if (kasMahubVeel() == true)
            {
                inimesed.Add(inimene);
            }else
            {
                var dialog = new MessageDialog("all full!!!!!");
                dialog.ShowAsync(); 
            }
            //inimesed.Add(inimene);
        }
        public void eemaldaInimene(string inimene)
        {
            inimesed.Remove(inimene);
        }

        public Boolean kasMahubVeel()
        {
            Boolean kontroll = false;
            if (inimesed.Count <= maksimumsuurus)
            {

                kontroll = true;
            }
            return kontroll;
        }

        public string kuvaInimesed()
        {
            string rahvas = "";
            for (int i = 0; i < inimesed.Count; i++)
            {
                rahvas = rahvas + inimesed[i] + System.Environment.NewLine;
            }
            return rahvas;
        }
    }
}